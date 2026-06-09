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
            var previewButton = this.Find<Button>("PreviewButton");
            if (previewButton != null)
            {
                previewButton.Click += PreviewButton_Click;
            }
        }

        private void PreviewButton_Click(object? sender, RoutedEventArgs e)
        {
            var languageComboBox = this.Find<ComboBox>("LanguageComboBox");
            var selectedLanguageItem = languageComboBox?.SelectedItem as ComboBoxItem;
            string language = selectedLanguageItem?.Content?.ToString() ?? "Nezvoleno";

            string theme = "Nezvoleno";
            if (this.Find<RadioButton>("LightThemeRadioButton")?.IsChecked == true)
                theme = "Světlý";
            else if (this.Find<RadioButton>("DarkThemeRadioButton")?.IsChecked == true)
                theme = "Tmavý";
            else if (this.Find<RadioButton>("BlueThemeRadioButton")?.IsChecked == true)
                theme = "Modrý";

            var selectedOptions = new List<string>();
            if (this.Find<CheckBox>("EmailNotificationsCheckBox")?.IsChecked == true)
                selectedOptions.Add("E-mailová upozornění");
            if (this.Find<CheckBox>("ShowTipsCheckBox")?.IsChecked == true)
                selectedOptions.Add("Zobrazovat tipy");
            if (this.Find<CheckBox>("AutoSaveCheckBox")?.IsChecked == true)
                selectedOptions.Add("Automatické ukládání");

            string options = selectedOptions.Any() ? string.Join("\n", selectedOptions) : "Žádné volby nebyly zapnuty.";

            var previewWindow = new PreviewWindow(language, theme, options);
            previewWindow.Show(this);
        }

        private void PreviewButton_OnClick(object? sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
