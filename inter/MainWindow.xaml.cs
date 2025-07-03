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

namespace inter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double res = Interpolate(30, 189, 125);

        }

        public double Interpolate( double f1 , double f2 , double f3 )
        {
            double a, b, c, x=0;
//c = 200
			c = f2;
			//a = ((20 + 200) - 400)/2 = -90 
            a = ((f1 + f3) - 2.0*c)/2.0;
			//b = 200 +90 - 200 = 90
            b = f3 - a - c;
			
            x =  -b / (2 * a);

			double x1 = (f1 - f3) / (2 * (f1 - 2 * f2 + f3));

			Console.WriteLine(x);
			Console.WriteLine(x1);

			return x;
        }
    }
}
