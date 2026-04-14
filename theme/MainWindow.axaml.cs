using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace theme;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public string theme = "Dark";
    private void SubmitClick(object? sender, RoutedEventArgs e)
    {
        ChosenSettings.Text = GetSummary();
    }

    public string GetSummary()
    {
        var allowed = GetAllowed();
        return $"{theme} theme was chosen. {allowed} were allowed.";
    }

    public string GetAllowed()
    {
        var output = "";

        if (sound.IsChecked == true)
        {
            output += idk(output) + "Sound";
        }

        if (tips.IsChecked == true)
        {
            output += idk(output) + "Tips";
        }

        if (save.IsChecked == true)
        {
            output += idk(output) + "Autosave";
        }

        if (output == "")
        {
            output = "Nothing";
        }

        return output;
    }

    public string idk(string allowed)
    {
        if (allowed != "")
        {
            return ", ";
        }

        return "";
    }

    private void lightTheme(object? sender, RoutedEventArgs e)
    {
        mainWindow.Background = Brushes.DimGray;
        theme = "Light";
    }

    private void darkTheme(object? sender, RoutedEventArgs e)
    {
        mainWindow.Background = Brushes.Black;
        theme = "Dark";
    }

    private void blueTheme(object? sender, RoutedEventArgs e)
    {
        mainWindow.Background = Brushes.Blue;
        theme = "Blue";
    }
}