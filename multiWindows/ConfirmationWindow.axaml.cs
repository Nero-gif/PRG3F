using System;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Threading;

namespace multiWindows;

public partial class ConfirmationWindow : Window
{
    private int _windowCount;

    public ConfirmationWindow(int initialCount)
    {
        InitializeComponent();
        var random = new Random();
        _windowCount = initialCount * random.Next(10, 1001);
        
        var infoTextBlock = this.FindControl<TextBlock>("InfoTextBlock");
        if (infoTextBlock != null)
        {
            infoTextBlock.Text = $"Počet generovaných oken: {_windowCount}";
        }

        StartCountdown();
    }

    private async void StartCountdown()
    {
        var countdownTextBlock = this.FindControl<TextBlock>("CountdownTextBlock");
        if (countdownTextBlock == null) return;

        for (int i = 5; i > 0; i--)
        {
            countdownTextBlock.Text = $"Otevírání oken za: {i}";
            await Task.Delay(1000);
        }

        OpenWindows();
        Close();
    }

    private void OpenWindows()
    {
        for (int i = 0; i < _windowCount; i++)
        {
            var newWindow = new Window
            {
                Title = $"Window {i + 1}",
                Width = 200,
                Height = 100,
                Content = new TextBlock { Text = $"This is window {i + 1}" }
            };
            newWindow.Show();
        }
    }
}
