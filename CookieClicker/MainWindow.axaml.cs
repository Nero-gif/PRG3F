using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Threading;

namespace CookieClicker;

public class Variables
{
    private Variables() {}

    public static Variables Instance { get; } = new Variables();

    public double CookieCount { get; set; } = 0;
    public string CookieName { get; set; } = " cookies";

    public Upgrade CpS { get; } = new Upgrade { Level = 0, Price = 10, Value = 0 };
    public Upgrade CpC { get; } = new Upgrade { Level = 0, Price = 1, Value = 1 };
    public Upgrade CpCMultiplicator { get; } = new Upgrade { Level = 0, Price = 100, Value = 1 };
    public Upgrade CpSMultiplicator { get; } = new Upgrade { Level = 0, Price = 100, Value = 1 };
    public Upgrade ExtraEnergy { get; } = new Upgrade { Level = 0, Price = 1000, Value = 0 };
    public Upgrade Mode { get; } = new Upgrade { Level = 0, Price = 2000, Value = 0 };
    
    public int ClickCount { get; set; } = 0;
    public int UpgradeCount { get; set; } = 0;
}

public class Upgrade
{
    public int Level;
    public int Price;
    public double Value;
}

public partial class MainWindow : Window
{
    private readonly DispatcherTimer _cpsTimer = new();
    private readonly DispatcherTimer _extraEnergyTimer = new();
    private readonly List<ShopWindow> _shopWindows = new();
    private int _extraEnergyRemainingSeconds;
    private SettingsWindow? _settingsWindow;
    
    public MainWindow()
    {
        InitializeComponent();
        
        _cpsTimer.Interval = TimeSpan.FromSeconds(1);
        _cpsTimer.Tick += Timer_Tick;
        _cpsTimer.Start();

        _extraEnergyTimer.Interval = TimeSpan.FromSeconds(1);
        _extraEnergyTimer.Tick += ExtraEnergyTimer_Tick;
    }

    private void Timer_Tick(object? sender, EventArgs eventArgs)
    {
        Variables.Instance.CookieCount += Variables.Instance.CpS.Value * Variables.Instance.CpSMultiplicator.Value;
        ValueUpdater();
        UpdateOpenShopWindows();
    }

    private void ExtraEnergyTimer_Tick(object? sender, EventArgs eventArgs)
    {
        _extraEnergyRemainingSeconds--;

        if (_extraEnergyRemainingSeconds <= 0)
        {
            _extraEnergyTimer.Stop();
            _cpsTimer.Interval = TimeSpan.FromSeconds(1);
            EnergyBoostStatus.IsVisible = false;
            EnergyBoostStatus.Text = "";
            return;
        }

        UpdateEnergyBoostStatus();
    }

    public void ActivateExtraEnergy()
    {
        _extraEnergyRemainingSeconds = 15;
        _cpsTimer.Interval = TimeSpan.FromSeconds(0.05);
        UpdateEnergyBoostStatus();
        _extraEnergyTimer.Stop();
        _extraEnergyTimer.Start();
    }

    private void UpdateEnergyBoostStatus()
    {
        EnergyBoostStatus.Text = "Energy boost active. Remaining time: " + _extraEnergyRemainingSeconds + " seconds";
        EnergyBoostStatus.IsVisible = true;
    }

    private void Settings_OnClick(object? sender, RoutedEventArgs e)
    {
        _settingsWindow = new SettingsWindow(this);
        _settingsWindow.Show();
    }

    public void ShowVacekMode()
    {
        _settingsWindow?.ShowVacekMode();
    }

    private void Shop_OnClick(object? sender, RoutedEventArgs e)
    {
        var shopWindow = new ShopWindow(this);
        _shopWindows.Add(shopWindow);
        shopWindow.Closed += (_, _) => _shopWindows.Remove(shopWindow);
        ShopUpdater(shopWindow);
        shopWindow.Show();
    }

    private void UpdateOpenShopWindows()
    {
        foreach (var shopWindow in _shopWindows)
        {
            ShopUpdater(shopWindow);
        }
    }

    public static void ShopUpdater(ShopWindow shopWindow)
    {
        shopWindow.CpCLevel.Text = "Level: " + Variables.Instance.CpC.Level;
        shopWindow.CpCPrice.Text = "Price: " + Variables.Instance.CpC.Price;
        shopWindow.CpCValue.Text = "Value: " + Variables.Instance.CpC.Value;
        
        shopWindow.CpSLevel.Text = "Level: " + Variables.Instance.CpS.Level;
        shopWindow.CpSPrice.Text = "Price: " + Variables.Instance.CpS.Price;
        shopWindow.CpSValue.Text = "Value: " + Variables.Instance.CpS.Value;
        
        shopWindow.CpCMultiplicatorLevel.Text = "Level: " + Variables.Instance.CpCMultiplicator.Level;
        shopWindow.CpCMultiplicatorPrice.Text = "Price: " + Variables.Instance.CpCMultiplicator.Price;
        shopWindow.CpCMultiplicatorValue.Text = "Value: " + Variables.Instance.CpCMultiplicator.Value;
        
        shopWindow.CpSMultiplicatorLevel.Text = "Level: " + Variables.Instance.CpSMultiplicator.Level;
        shopWindow.CpSMultiplicatorPrice.Text = "Price: " + Variables.Instance.CpSMultiplicator.Price;
        shopWindow.CpSMultiplicatorValue.Text = "Value: " + Variables.Instance.CpSMultiplicator.Value;

        shopWindow.ExtraEnergyLevel.Text = "Level: " + Variables.Instance.ExtraEnergy.Level;
        shopWindow.ExtraEnergyPrice.Text = "Price: " + Variables.Instance.ExtraEnergy.Price;
        shopWindow.ExtraEnergyValue.Text = "Value: " + Variables.Instance.ExtraEnergy.Value;
        
        shopWindow.ModeLevel.Text = "Level: " + Variables.Instance.Mode.Level;
        shopWindow.ModePrice.Text = "Price: " + Variables.Instance.Mode.Price;
        shopWindow.ModeValue.Text = "Value: " + (Variables.Instance.Mode.Level > 0 ? "Bought" : "0");
        
        shopWindow.CookieCount.Text = Variables.Instance.CookieCount + Variables.Instance.CookieName;

    }

    private void Cookie_OnClick(object? sender, RoutedEventArgs e)
    {
        Variables.Instance.ClickCount++;
        Variables.Instance.CookieCount += Variables.Instance.CpC.Value * Variables.Instance.CpCMultiplicator.Value;
        ValueUpdater();
        UpdateOpenShopWindows();
    }

    public void ApplyMode(string cookieName, string imagePath)
    {
        Variables.Instance.CookieName = cookieName;

        using var imageStream = AssetLoader.Open(new Uri(imagePath));
        CookieImage.Source = new Bitmap(imageStream);

        ValueUpdater();
    }

    private void ValueUpdater()
    {
        CPS.Text = Variables.Instance.CpS.Value * Variables.Instance.CpSMultiplicator.Value + Variables.Instance.CookieName + " per second";
        CookieCount.Text = Variables.Instance.CookieCount + Variables.Instance.CookieName;
        CPC.Text = Variables.Instance.CpC.Value * Variables.Instance.CpCMultiplicator.Value + Variables.Instance.CookieName + " per click";
        ClickCount.Text = Variables.Instance.ClickCount + " clicks";
        UpgradeCount.Text = Variables.Instance.UpgradeCount + " upgrades bought";
    }

    private void ResetButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Variables.Instance.CookieCount = 0;
        Variables.Instance.CookieName = " cookies";
        Variables.Instance.CpS.Level = 0;
        Variables.Instance.CpS.Price = 10;
        Variables.Instance.CpS.Value = 0;
        Variables.Instance.CpC.Level = 0;
        Variables.Instance.CpC.Price = 1;
        Variables.Instance.CpC.Value = 1;
        Variables.Instance.CpCMultiplicator.Level = 0;
        Variables.Instance.CpCMultiplicator.Price = 100;
        Variables.Instance.CpCMultiplicator.Value = 1;
        Variables.Instance.CpSMultiplicator.Level = 0;
        Variables.Instance.CpSMultiplicator.Price = 100;
        Variables.Instance.CpSMultiplicator.Value = 1;
        Variables.Instance.ExtraEnergy.Level = 0;
        Variables.Instance.ExtraEnergy.Price = 1000;
        Variables.Instance.ExtraEnergy.Value = 0;
        Variables.Instance.Mode.Level = 0;
        Variables.Instance.Mode.Price = 2000;
        Variables.Instance.Mode.Value = 0;
        Variables.Instance.ClickCount = 0;
        Variables.Instance.UpgradeCount = 0;
        ValueUpdater();
        UpdateOpenShopWindows();
        _extraEnergyTimer.Stop();
        _cpsTimer.Interval = TimeSpan.FromSeconds(1);
        EnergyBoostStatus.IsVisible = false;
        EnergyBoostStatus.Text = "";
        _extraEnergyRemainingSeconds = 0;
        ApplyMode(" cookies", "avares://CookieClicker/Images/cookie.jpg");
    }
}
