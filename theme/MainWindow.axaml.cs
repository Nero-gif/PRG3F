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

    private void SubmitClick(object? sender, RoutedEventArgs e)
    {
        
    }

    private void lightTheme(object? sender, RoutedEventArgs e)
    {
        mainWindow.Background="White";
        this;
    }

    private void darkTheme(object? sender, RoutedEventArgs e)
    {
        
    }

    private void blueTheme(object? sender, RoutedEventArgs e)
    {
        
    }
}