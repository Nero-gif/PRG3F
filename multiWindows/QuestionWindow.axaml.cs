using Avalonia.Controls;
using Avalonia.Interactivity;

namespace multiWindows;

public partial class QuestionWindow : Window
{
    public QuestionWindow()
    {
        InitializeComponent();
    }

    private void OkButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var windowCount = this.FindControl<NumericUpDown>("WindowCount");
        if (windowCount != null)
        {
            int count = (int)windowCount.Value;
            var confirmationWindow = new ConfirmationWindow(count);
            confirmationWindow.Show();
        }
        Close();
    }
}
