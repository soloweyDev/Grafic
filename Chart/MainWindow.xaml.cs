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

namespace Chart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Window_Loaded();
        }
        private void Window_Loaded()
        {
            decimal[] Y = { 100.0M, 200.0M, 350.0M };
            int[] X = { 100, 200, 300 };
            Polyline polyline = new Polyline { Stroke = Brushes.Black};
            for (var i = 0; i < 3; ++i)
            {
                Point point = new Point
                {
                    X = X[i],
                    Y = (double)Y[i]
                };
                polyline.Points.Add(point);
            }

            gr.Children.Add(polyline);
        }
    }
}
