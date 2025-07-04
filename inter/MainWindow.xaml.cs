using System;
using System.Collections.Generic;
using System.ComponentModel;
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
           

			double x = (f1 - f3) / (2 * (f1 - 2 * f2 + f3));

			Console.WriteLine(x);
			

			return x;
        }

		private void y0_TextChanged(object sender, TextChangedEventArgs e)
		{
			TypeConverter inputcheck = TypeDescriptor.GetConverter(typeof(double));
			if (inputcheck.IsValid(y0.Text) && inputcheck.IsValid(y1.Text) && inputcheck.IsValid(y2.Text))
			{
				double res = Interpolate(Convert.ToDouble(y0.Text), Convert.ToDouble(y1.Text), Convert.ToDouble(y2.Text));
				Result.Dispatcher.Invoke(new Action(delegate
				{
					Result.Text = res.ToString();
				}));
			}
			
			
		}

		private void y1_TextChanged(object sender, TextChangedEventArgs e)
		{
			TypeConverter inputcheck = TypeDescriptor.GetConverter(typeof(double));
			if (inputcheck.IsValid(y0.Text) && inputcheck.IsValid(y1.Text) && inputcheck.IsValid(y2.Text))
			{
				double res = Interpolate(Convert.ToDouble(y0.Text), Convert.ToDouble(y1.Text), Convert.ToDouble(y2.Text));
				Result.Dispatcher.Invoke(new Action(delegate
				{
					Result.Text = res.ToString();
				}));
			}
		}

		private void y2_TextChanged(object sender, TextChangedEventArgs e)
		{
			TypeConverter inputcheck = TypeDescriptor.GetConverter(typeof(double));
			if (inputcheck.IsValid(y0.Text) && inputcheck.IsValid(y1.Text) && inputcheck.IsValid(y2.Text))
			{
				double res = Interpolate(Convert.ToDouble(y0.Text), Convert.ToDouble(y1.Text), Convert.ToDouble(y2.Text));
				Result.Dispatcher.Invoke(new Action(delegate
				{
					Result.Text = res.ToString();
				}));
			}
		}
	}
}
