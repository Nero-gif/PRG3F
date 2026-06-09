using Avalonia.Controls;
using Avalonia.Interactivity;

namespace userProfile
{
    public partial class PreviewWindow : Window
    {
        public PreviewWindow()
        {
            InitializeComponent();
            InitializeWindow();
        }

        public PreviewWindow(string language, string theme, string options)
        {
            InitializeComponent();
            InitializeWindow();

            var languageTextBlock = this.Find<TextBlock>("LanguageTextBlock");
            if (languageTextBlock != null) languageTextBlock.Text = language;

            var themeTextBlock = this.Find<TextBlock>("ThemeTextBlock");
            if (themeTextBlock != null) themeTextBlock.Text = theme;

            var optionsTextBlock = this.Find<TextBlock>("OptionsTextBlock");
            if (optionsTextBlock != null) optionsTextBlock.Text = string.IsNullOrWhiteSpace(options) ? "Žádné volby nebyly zapnuty." : options;
        }

        private void InitializeWindow()
        {
            var closeButton = this.Find<Button>("CloseButton");
            if (closeButton != null)
            {
                closeButton.Click += CloseButton_Click;
            }
        }

        private void CloseButton_Click(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
