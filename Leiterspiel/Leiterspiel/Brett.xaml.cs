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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Leiterspiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class Brett : Window
    {
        public Brett()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            int column = Grid.GetColumn(figure);
            int row = Grid.GetRow(figure);           

            if (column > 0)
            {
                Grid.SetColumn(figure, column - 1);
            }
            else
            {
                if (row > 0)
                {
                    Grid.SetColumn(figure, 3);
                    Grid.SetRow(figure, row - 1);
                }
            }
        }
    }
}
