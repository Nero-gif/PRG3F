using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CookieClicker;

/// <summary>
/// Interakční logika pro vobchod.xaml
/// </summary>
public partial class vobchod : Window
{

    List<Label> labels = new List<Label>();
    GameState gameState;
    //public vobchod()
    //{
    //    InitializeComponent();
    //}


    public vobchod(GameState gameState)
    {
        InitializeComponent();
        this.gameState = gameState;
        lbl1.Content = (gameState.Upgrades["Lepší kurzor"] * 1.2 * 15 + 15) + " susenek";
        lbl2.Content = (gameState.Upgrades["Dvojité kliknutí"] * 1.2 * 30 + 30) + " susenek";
        lbl3.Content = (gameState.Upgrades["Babička pekařka"] * 1.2 * 45 + 45) + " susenek";
        lbl4.Content = (gameState.Upgrades["Malá pekárna"] * 1.2 * 60 + 60) + " susenek";
        lbl5.Content = (gameState.Upgrades["Továrna na sušenky"] * 1.2 * 75 + 75) + " susenek";
    }

    public void runTransaction(String key, int value)
    {
        labels = [lbl1, lbl2, lbl3, lbl4, lbl5];
        if (gameState.Cookies >= (gameState.Upgrades[key] * 1.2 * value + value))
        {
            gameState.Cookies -= (gameState.Upgrades[key] * 1.2 * value + value);
            gameState.Upgrades[key]++;
            labels[value / 15 - 1].Content = (gameState.Upgrades[key] * 1.2 * value + value) + " susenek";
        }
    }

    private void btn1_Click(object sender, RoutedEventArgs e) //lepsi kurzor
    {
        runTransaction("Lepší kurzor", 15);
    }

    private void btn2_Click(object sender, RoutedEventArgs e)//double cick
    {
        runTransaction("Dvojité kliknutí", 30);
    }

    private void btn3_Click(object sender, RoutedEventArgs e) //babka
    {
        runTransaction("Babička pekařka", 45);
    }

    private void btn4_Click(object sender, RoutedEventArgs e)//mala pekarna
    {
        runTransaction("Malá pekárna", 60);
    }

    private void btn5_Click(object sender, RoutedEventArgs e)//tovarna
    {
        runTransaction("Továrna na sušenky", 75);
    }
}
