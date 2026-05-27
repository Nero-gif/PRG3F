using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieClicker
{
    public class GameState
    {
        public double Cookies { get; set; }
        public double CookiesPerClick { get; set; }
        public double CookiesPerSecond { get; set; }
        public int TotalClicks { get; set; }
        public int TotalUpgradesBought { get; set; }

        public Dictionary<string, int> Upgrades = new Dictionary<string, int>();

        public GameState()
        {
            Cookies = 0;
            CookiesPerClick = 1;
            CookiesPerSecond = 1;
            TotalClicks = 0;
            TotalUpgradesBought = 0;

            Upgrades.Add("Lepší kurzor", 0);
            Upgrades.Add("Dvojité kliknutí", 0);
            Upgrades.Add("Babička pekařka", 1);
            Upgrades.Add("Malá pekárna", 0);
            Upgrades.Add("Továrna na sušenky", 0);
        }

        public void click()
        {
            Cookies += CookiesPerClick;
            TotalClicks++;
        }

        public void addCursorUpgrade()
        {
            this.CookiesPerClick++;
            Upgrades["Lepší kurzor"]++;
        }

        public void addDoubleUpgrade()
        {
            this.CookiesPerClick += 5;
            Upgrades["Dvojité kliknutí"]++;
        }

        public void addGrannyUpgrade()
        {
            this.CookiesPerSecond++;
            Upgrades["Babička pekařka"]++;
        }

        public void addBakeryUpgrade()
        {
            this.CookiesPerClick += 5;
            Upgrades["Malá pekárna"]++;
        }

        public void addFactoryUpgrade()
        {
            this.CookiesPerClick += 25;
            Upgrades["Továrna na sušenky"]++;
        }

    }
}
