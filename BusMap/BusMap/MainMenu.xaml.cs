using System;
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

namespace BusMap
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            ChangeNumberPeople();
        }

        private void BtnCloseMap_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChangeNumberPeople ()
        {
            txtNumberPeople.Text += " " + 10;
        }

        private void BtnClickDown_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Map_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SearchMap newSearchMap = new SearchMap();
            newSearchMap.ShowDialog();
        }

        private void BtnViewSeat_Click(object sender, RoutedEventArgs e)
        {
            SeatPeople newSeatPeople = new SeatPeople();
            newSeatPeople.ShowDialog();
        }

        private void BtnBuyTicker_Click(object sender, RoutedEventArgs e)
        {
            LoginApp newLoginApp = new LoginApp();
            newLoginApp.ShowDialog();
        }
    }
}
