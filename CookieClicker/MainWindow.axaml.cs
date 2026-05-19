using System;
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
    
    public MainWindow()
    {
        InitializeComponent();
        
        var timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs eventArgs)
    {
        Variables.Instance.CookieCount += Variables.Instance.CpS.Value * Variables.Instance.CpSMultiplicator.Value;
        ValueUpdater();
    }

    private void Settings_OnClick(object? sender, RoutedEventArgs e)
    {
        var settingsWindow = new SettingsWindow(this);
        settingsWindow.Show();
    }

    private void Shop_OnClick(object? sender, RoutedEventArgs e)
    {
        var shopWindow = new ShopWindow();
        ShopUpdater(shopWindow);
        shopWindow.Show();
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
        
        shopWindow.CookieCount.Text = Variables.Instance.CookieCount + Variables.Instance.CookieName;

    }

    private void Cookie_OnClick(object? sender, RoutedEventArgs e)
    {
        Variables.Instance.ClickCount++;
        Variables.Instance.CookieCount += Variables.Instance.CpC.Value * Variables.Instance.CpCMultiplicator.Value;
        ValueUpdater();
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
}
