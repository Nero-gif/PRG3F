using Avalonia.Controls;

namespace comboBox;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void FruitComboBox_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (FruitComboBox.SelectedItem is ComboBoxItem selectedItem)
        {
            SelectedFruitTextBlock.Text = $"You selected: {selectedItem.Content}";
        }
    }
}
