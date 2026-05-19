using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CookieClicker;

public partial class SettingsWindow : Window
{
    private readonly MainWindow? _mainWindow;

    public SettingsWindow()
    {
        InitializeComponent();
    }

    public SettingsWindow(MainWindow mainWindow) : this()
    {
        _mainWindow = mainWindow;
    }

    private void CookieModeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        ApplyMode(" cookies", "avares://CookieClicker/Images/cookie.jpg");
        SelectMode(CookieModeCard);
    }

    private void VacekModeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        ApplyMode(" Vacků", "avares://CookieClicker/Images/vacek.jpg");
        SelectMode(VacekModeCard);
    }

    private void ApplyMode(string cookieName, string imagePath)
    {
        if (_mainWindow is null)
        {
            return;
        }

        _mainWindow.ApplyMode(cookieName, imagePath);
    }

    private void SelectMode(Border selectedCard)
    {
        CookieModeCard.Classes.Set("selected", selectedCard == CookieModeCard);
        VacekModeCard.Classes.Set("selected", selectedCard == VacekModeCard);
    }
}
