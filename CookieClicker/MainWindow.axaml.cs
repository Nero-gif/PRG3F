using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace CookieClicker;

public class Variables
{
    private Variables() {}

    public static Variables Instance { get; } = new Variables();

    public double CookieCount { get; set; } = 0;
    public double CpS { get; set; } = 0;
    public double CpC { get; set; } = 1;
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
        Variables.Instance.CookieCount += Variables.Instance.CpS;
        CookieCount.Text = Variables.Instance.CookieCount + " Cookies";
    }

    private void Settings_OnClick(object? sender, RoutedEventArgs e)
    {
        var settingsWindow = new SettingsWindow();
        settingsWindow.Show();
    }

    private void Shop_OnClick(object? sender, RoutedEventArgs e)
    {
        var shopWindow = new ShopWindow();
        shopWindow.Show();
    }

    private void Cookie_OnClick(object? sender, RoutedEventArgs e)
    {
        Variables.Instance.CookieCount += Variables.Instance.CpC;
        CookieCount.Text = Variables.Instance.CookieCount + " Cookies";
    }
}