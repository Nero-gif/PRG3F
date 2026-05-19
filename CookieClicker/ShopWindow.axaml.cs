using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CookieClicker;

public partial class ShopWindow : Window
{
    public ShopWindow()
    {
        InitializeComponent();
    }

    private void CpC_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Variables.Instance.CookieCount >= Variables.Instance.CpC.Price)
        {
            Variables.Instance.CookieCount -= Variables.Instance.CpC.Price;
            Variables.Instance.CpC.Level++;
            Variables.Instance.CpC.Price = (int)(10 * Math.Pow(1.5, Variables.Instance.CpC.Level));
            Variables.Instance.CpC.Value++;
            Variables.Instance.UpgradeCount++;
            MainWindow.ShopUpdater(this);
        }
        else
        {
            var dialog = new Window
            {
                Title = "Not enough cookies",
                Width = 300,
                Height = 120,
                Content = new TextBlock
                {
                    Text = "You do not have enaught" + Variables.Instance.CookieName,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                }
            };

            dialog.ShowDialog(this);
        }
        
    }

    private void CpS_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Variables.Instance.CookieCount >= Variables.Instance.CpS.Price)
        {
            Variables.Instance.CookieCount -= Variables.Instance.CpS.Price;
            Variables.Instance.CpS.Level++;
            Variables.Instance.CpS.Price = (int)(10 * Math.Pow(1.5, Variables.Instance.CpS.Level));
            Variables.Instance.CpS.Value += .5;
            Variables.Instance.UpgradeCount++;
            MainWindow.ShopUpdater(this);
        }
        else
        {
            var dialog = new Window
            {
                Title = "Not enough cookies",
                Width = 300,
                Height = 120,
                Content = new TextBlock
                {
                    Text = "You do not have enaught" + Variables.Instance.CookieName,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                }
            };

            dialog.ShowDialog(this);
        }
    }

    private void CpCmultiplicator_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Variables.Instance.CookieCount >= Variables.Instance.CpCMultiplicator.Price)
        {
            Variables.Instance.CookieCount -= Variables.Instance.CpCMultiplicator.Price;
            Variables.Instance.CpCMultiplicator.Level++;
            Variables.Instance.CpCMultiplicator.Price = (int)(100 * Math.Pow(2, Variables.Instance.CpCMultiplicator.Level));
            Variables.Instance.CpCMultiplicator.Value ++; 
            Variables.Instance.UpgradeCount++;
            MainWindow.ShopUpdater(this);
        }
        else
        {
            var dialog = new Window
            {
                Title = "Not enough cookies",
                Width = 300,
                Height = 120,
                Content = new TextBlock
                {
                    Text = "You do not have enaught" + Variables.Instance.CookieName,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                }
            };

            dialog.ShowDialog(this);
        }
    }

    private void CpSmultiplicator_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Variables.Instance.CookieCount >= Variables.Instance.CpSMultiplicator.Price)
        {
            Variables.Instance.CookieCount -= Variables.Instance.CpSMultiplicator.Price;
            Variables.Instance.CpSMultiplicator.Level++;
            Variables.Instance.CpSMultiplicator.Price = (int)(100 * Math.Pow(2, Variables.Instance.CpSMultiplicator.Level));
            Variables.Instance.CpSMultiplicator.Value ++;  
            Variables.Instance.UpgradeCount++;
            MainWindow.ShopUpdater(this);
        }
        else
        {
            var dialog = new Window
            {
                Title = "Not enough cookies",
                Width = 300,
                Height = 120,
                Content = new TextBlock
                {
                    Text = "You do not have enaught" + Variables.Instance.CookieName,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                }
            };

            dialog.ShowDialog(this);
        }
    }
}
