using Avalonia.Controls;
using Avalonia.Interactivity;

namespace options;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void X_Settings_OnClick(object? sender, RoutedEventArgs e)
    {
        string optionsOut = "";
        if (Sounds.IsChecked == true)
        {
            optionsOut = optionsOut + "Sounds";
        }
        if (Subtitles.IsChecked == true)
        {
            if (optionsOut != "")
            {
                optionsOut = optionsOut + ", ";
            }
            optionsOut = optionsOut + "Subtitles";
        }
        if (Theme.IsChecked == true)
        {
            if (optionsOut != "")
            {
                optionsOut = optionsOut + ", ";
            }
            optionsOut = optionsOut + "Theme";
        }

        if (optionsOut != "")
        {
            optionsOut = optionsOut + " are enabled.";
        } 
        else
        {
            optionsOut = "No options are enabled.";
            
        }
        Settings.Text = optionsOut;
    }

    private void X_Travel_OnClick(object? sender, RoutedEventArgs e)
    {
        int distance = 666; 
        double walkPrice = 0; 
        double mhdPrice = 12; 
        double helicopterPrice = 1000; 
        
        if (sender is RadioButton rb)
        {
            double price = 0;
            string travelMethod = rb.Name;

            if (travelMethod == "Walk")
            {
                price = distance * walkPrice;
            }
            else if (travelMethod == "Mhd")
            {
                price = distance * mhdPrice;
            }
            else if (travelMethod == "Helicopter")
            {
                price = distance * helicopterPrice;
            }
            
            Travel.Text = $"You travel by {rb.Content} and it will cost you {price} CZK.";
        }
    }
}