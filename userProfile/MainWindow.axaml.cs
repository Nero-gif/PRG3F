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
            // var languageComboBox = this.Find<ComboBox>("LanguageComboBox");
            // var selectedLanguageItem = languageComboBox?.SelectedItem as ComboBoxItem;
            // string language = selectedLanguageItem?.Content?.ToString() ?? "Nezvoleno";
            //
            // string theme = "Nezvoleno";
            // if (this.Find<RadioButton>("LightThemeRadioButton")?.IsChecked == true)
            //     theme = "Světlý";
            // else if (this.Find<RadioButton>("DarkThemeRadioButton")?.IsChecked == true)
            //     theme = "Tmavý";
            // else if (this.Find<RadioButton>("BlueThemeRadioButton")?.IsChecked == true)
            //     theme = "Modrý";
            //
            // var selectedOptions = new List<string>();
            // if (this.Find<CheckBox>("EmailNotificationsCheckBox")?.IsChecked == true)
            //     selectedOptions.Add("E-mailová upozornění");
            // if (this.Find<CheckBox>("ShowTipsCheckBox")?.IsChecked == true)
            //     selectedOptions.Add("Zobrazovat tipy");
            // if (this.Find<CheckBox>("AutoSaveCheckBox")?.IsChecked == true)
            //     selectedOptions.Add("Automatické ukládání");
            //
            // string options = selectedOptions.Any() ? string.Join("\n", selectedOptions) : "Žádné volby nebyly zapnuty.";
            //
            // var previewWindow = new PreviewWindow(language, theme, options);
            // previewWindow.Show(this);
            
            //jazyk
            // TODO: tahle věc nefunguje, musí se to předělat, musí se nějak získat obsah vybraného itemu 
            // previewWindow.LanguageTextBlock.Text = LanguageComboBox.SelectedItem.ToString();
            // if (LanguageComboBox.SelectedItem.ToString() = "Čeština")
            // {
            //     
            // }else if (LanguageComboBox.SelectedItem.ToString() = "Angličtina")
            // {
            //     
            // }
            // else
            // {
            //     
            // }
            
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
