using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OnGreetButtonClick(object sender, RoutedEventArgs args)
        {
            if (AcceptCheckBox.IsChecked == true && !string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                GreetingTextBlock.Text = $"Hello {NameTextBox.Text}";
            }
            else
            {
                GreetingTextBlock.Text = string.Empty;
            }
        }
    }
}
