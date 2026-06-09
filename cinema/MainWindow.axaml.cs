using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace cinema;

public partial class MainWindow : Window
{
    private readonly List<ReservationWindow> _reservationWindows;

    public MainWindow()
    {
        InitializeComponent();
        _reservationWindows = new List<ReservationWindow>();
    }

    private void ShowReservationButton_OnClick(object? sender, RoutedEventArgs e)
    {
        
        
        var reservationWindow = new ReservationWindow(this);
        if (FilmComboBox.SelectedItem == null)
        {
            reservationWindow.FilmTextBlock.Text = "Movie was not selevted. User is an idiot";
            reservationWindow.SummaryHeader.Text = "User is an idiot";
        }
        else
        {
            reservationWindow.FilmTextBlock.Text = FilmComboBox.SelectionBoxItem.ToString();
        }
        
        if (StandardRadioButton.IsChecked == true)
        {
            reservationWindow.SeatTextBlock.Text = "Seat: Standard";
        }
        else if (PremiumRadioButton.IsChecked == true)
        {
            reservationWindow.SeatTextBlock.Text = "Seat: Premium";
        }
        
        if (PopcornCheckBox.IsChecked == true)
        {
            reservationWindow.ExtrasTextBlock.Text += "Popcorn, ";
        }
        if (DrinkCheckBox.IsChecked == true)
        {
            reservationWindow.ExtrasTextBlock.Text += "Drink, ";
        }
        if (GlassesCheckBox.IsChecked == true)
        {
            reservationWindow.ExtrasTextBlock.Text += "3D Glasses, ";
        }
        if (PopcornCheckBox.IsChecked == false && DrinkCheckBox.IsChecked == false && GlassesCheckBox.IsChecked == false)
        {
            reservationWindow.ExtrasTextBlock.Text = "No extras";
        }
        
        _reservationWindows.Add(reservationWindow);
        reservationWindow.Closed += (_, _) => _reservationWindows.Remove(reservationWindow);
        reservationWindow.Show();
    }
        
}