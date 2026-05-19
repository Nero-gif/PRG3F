using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CookieClicker;

public class Variables
{
    private Variables() {}

    public static Variables Instance { get; } = new Variables();

    public int CookieCount { get; set; } = 0;
    public int CpS { get; set; } = 0;
    public int CpC { get; set; } = 1;
}


public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
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
        CookieCount.Text = Variables.Instance.CookieCount.ToString() + " Cookies";
    }
}