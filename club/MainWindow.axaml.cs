using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace club;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SubmitButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (AgreesToRulesCheckBox.IsChecked == true)
        {
            var notebook = false;
            notebook = (bool)HasLaptopCheckBox.IsChecked;
            var club = "";
            club = GetClub();
            if (club != "")
            {
                OutputTextBlock.Text = GenerateSumarize(club, notebook);
            }
            else
            {
                OutputTextBlock.Text = "Musíte vybrat kroužek.";
            }

        }
        else
        {
            OutputTextBlock.Text = "Musíte souhlasit s pravidly kroužku.";
        }
    }

    public string GenerateSumarize(string club, bool notebook)
    {
        var name = NameTextBox.Text;
        var hasNotebook = "";
        if (notebook == true)
        {
            hasNotebook = "ano";
        }
        else
        {
            hasNotebook = "ne";
        }
        
        var final = $"{name} se přihlásil/a na kroužek {club}. Má vlastní notebook: {hasNotebook}.";
        return final;
    }

    public string GetClub()
    {
        var club = "";
        if (ProgrammingRadioButton.IsChecked == true)
        {
            club = "Programování";
        }
        else if (RoboticsRadioButton.IsChecked == true)
        {
            club = "Robotika";
        }
        else if (GraphicsRadioButton.IsChecked == true)
        {
            club = "Grafika";
        }
        else
        {
            OutputTextBlock.Text = "Musíte vybrat kroužek.";
            club = "";
        }

        return club;
    }
}