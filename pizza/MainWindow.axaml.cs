using Avalonia.Controls;
using Avalonia.Interactivity;

namespace pizza;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Confirm_OnClick(object? sender, RoutedEventArgs e)
    {
        var pizzaSize = "large";
        var price = 0;
        if (S.IsChecked == true)
        {
            pizzaSize = "small";
            price = 120;
        }
        else if (M.IsChecked == true)
        {
            pizzaSize = "medium";
            price = 150;
        }
        else if (L.IsChecked == true)
        {
            pizzaSize = "large";
            price = 190;
        }

        var extras = "";
        if (cheese.IsChecked == true)
        {
            extras = GenerateExtras("cheese", extras);
            price += 20;
        }
        if (ham.IsChecked == true)
        {
            extras = GenerateExtras("ham", extras);
            price += 20;
        }
        if (mushrooms.IsChecked == true)
        {
            extras = GenerateExtras("mushrooms", extras);
            price += 20;
        }
        if (olives.IsChecked == true)
        {
            extras = GenerateExtras("olives", extras);
            price += 20;
        }

        if (extras == "")
        {
            extras = "nothing";
        }
        
        output.Text = GenerateOutputMessage(pizzaSize, extras, price);
    }

    
    
    
    public string GenerateOutputMessage(string size, string extras, int price)
    {
        var customerName = name.Text;
        var final = $"Hello {customerName}, you have ordered a {size} pizza with extra {extras}. Price is {price} CZK";
        return final;
    }

    public string GenerateExtras(string add, string extras)
    {
        if (extras != "")
        {
            extras = extras + ", ";
        }
        extras = extras + add;
        return extras;
    }
}