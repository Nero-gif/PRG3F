using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace userProfile
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void English(PreviewWindow previewWindow)
        {
            previewWindow.Header.Text = "Settings Preview";
            previewWindow.LanguageHeader.Text = "Language";
            previewWindow.ThemeHeader.Text = "Theme";
            previewWindow.OptionsHeader.Text = "Options";
            previewWindow.CloseButton.Content = "Close";

            if (LightThemeRadioButton.IsChecked == true)
            {
                previewWindow.ThemeTextBlock.Text = "Light";
            }
            else if (BlueThemeRadioButton.IsChecked == true)
            {
                previewWindow.ThemeTextBlock.Text = "Blue";
            }
            else
            {
                previewWindow.ThemeTextBlock.Text = "Dark";
            }

            //options
            previewWindow.OptionsTextBlock.Text = "";
            if (AutoSaveCheckBox.IsChecked == true)
            {
                previewWindow.OptionsTextBlock.Text += "Auto-save\n";
            }

            if (EmailNotificationsCheckBox.IsChecked == true)
            {
                previewWindow.OptionsTextBlock.Text += "Email notifications\n";
            }

            if (ShowTipsCheckBox.IsChecked == true)
            {
                previewWindow.OptionsTextBlock.Text += "Show tips\n";
            }
        }

        private void PreviewButton_OnClick(object? sender, RoutedEventArgs e)
        {
            var previewWindow = new PreviewWindow();

            //jazyk
            if (LanguageComboBox.SelectedItem is ComboBoxItem { Content: not null } selectedItem)
            {
                previewWindow.LanguageTextBlock.Text = selectedItem.Content.ToString();

                if (selectedItem.Content.ToString() == "Angličtina")
                {
                    English(previewWindow);
                }
                else
                {
                    if (selectedItem.Content.ToString() == "Němčina")
                    {
                        previewWindow.LanguageTextBlock.Text =
                            "Deutsch, německy neumim, takže to překládat nebudu.";
                    }

                    //motiv
                    if (LightThemeRadioButton.IsChecked == true)
                    {
                        previewWindow.ThemeTextBlock.Text = "Světlý";
                        previewWindow.Border.Background = Brushes.LightGray;
                        previewWindow.Header.Foreground = Brushes.Black;
                        previewWindow.LanguageHeader.Foreground = Brushes.Black;
                        previewWindow.ThemeHeader.Foreground = Brushes.Black;
                        previewWindow.OptionsHeader.Foreground = Brushes.Black;
                        previewWindow.LanguageTextBlock.Foreground = Brushes.Black;
                        previewWindow.ThemeTextBlock.Foreground = Brushes.Black;
                        previewWindow.OptionsTextBlock.Foreground = Brushes.Black;
                    }
                    else if (BlueThemeRadioButton.IsChecked == true)
                    {
                        previewWindow.ThemeTextBlock.Text = "Modrý";
                        previewWindow.Border.Background = Brushes.DarkBlue;
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
                }
            }

            previewWindow.Show();
        }
    }
}