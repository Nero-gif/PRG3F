using Avalonia.Controls;
using Avalonia.Interactivity;

namespace testLibrary;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ShowSummary_OnClick(object? sender, RoutedEventArgs e)
    {
        var summaryWindow = new SummaryWindow();

        if (BookComboBox.SelectedItem is ComboBoxItem {Content: not null } selectedItem)
        {

            summaryWindow.BookSelected.Text = selectedItem.Content.ToString();

            if (Lenght14.IsChecked ==true)
            {
                summaryWindow.Lenght.Text = "14 dní";
            } else if (Lenght30.IsChecked ==true)
            {
                summaryWindow.Lenght.Text = "30 dní";
            }else if (Lenght60.IsChecked ==true)
            {
                summaryWindow.Lenght.Text = "60 dní";
            }


            summaryWindow.Options.Text = "";
            if (OptionMail.IsChecked == true)
            {
                summaryWindow.Options.Text += "Notifikace na email\n";
            }
            if (OptionJacket.IsChecked == true)
            {
                summaryWindow.Options.Text += "Přebal na knihu\n";
            }
            if (OptionExtension.IsChecked == true)
            {
                summaryWindow.Options.Text += "Automatické prodloužení\n";
            }
            if (OptionConditions.IsChecked == true)
            {
                summaryWindow.Options.Text += "Souhlas s podmínkami\n";
            }
        }
        
        
        summaryWindow.Show();
    
    }
}