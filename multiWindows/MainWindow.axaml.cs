using Avalonia.Controls;
using Avalonia.Interactivity;

namespace multiWindows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void NewWindow(object? sender, RoutedEventArgs e)
    {
        var questionWindow = new QuestionWindow();
        questionWindow.Show();
    }
}
