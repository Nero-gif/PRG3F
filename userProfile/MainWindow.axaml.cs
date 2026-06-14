using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;

namespace userProfile
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void PreviewButton_OnClick(object? sender, RoutedEventArgs e)
        {
            var previewWindow = new PreviewWindow();
            
            //jazyk
            if (LanguageComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                previewWindow.LanguageTextBlock.Text = selectedItem.Content.ToString();
                if (selectedItem.Content.ToString() == "Angličtina")
                {
                    
                } else if (selectedItem.Content.ToString() == "Němčina")
                {
                    
                }
            }
            
            //motiv
            if (LightThemeRadioButton.IsChecked == true)
            {
                previewWindow.ThemeTextBlock.Text = "Světlý";
            } else if (BlueThemeRadioButton.IsChecked == true)
            {
                previewWindow.ThemeTextBlock.Text = "Modrý";
            }
            else
            {
                previewWindow.ThemeTextBlock.Text = "Tmavý";
            }
            
            //options
            previewWindow.OptionsTextBlock.Text = "";
            if (AutoSaveCheckBox.IsChecked == true)
            {
                previewWindow.OptionsTextBlock.Text += "Automatické ukládání\n";
            }

            if (EmailNotificationsCheckBox.IsChecked == true)
            {
                previewWindow.OptionsTextBlock.Text += "Upozornění na email\n";
            }

            if (ShowTipsCheckBox.IsChecked == true)
            {
                previewWindow.OptionsTextBlock.Text += "Nabízet tipy\n";
            }
           previewWindow.Show();
        }
    }
}
