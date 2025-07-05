using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace inter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		/// <summary>
		/// initialise the window
		/// </summary>
        public MainWindow()
        {
            InitializeComponent();


        }
		/// <summary>
		/// find the x value of the peak of the quadratic curve
		/// </summary>
		/// <param name="y0">value of y at x=-1</param>
		/// <param name="y1">value of y at x=0</param>
		/// <param name="y2">value of y at x=1</param>
		/// <returns>the x value of the peak</returns>
		public double Interpolate( double y0 , double y1 , double y2 )
        {
           

			double x = (y0 - y2) / (2 * (y0 - 2 * y1 + y1));

			Console.WriteLine(x);
			
			return x;
        }
		/// <summary>
		/// calls Interpolate when text is changed and all inputs are valid doubles and then updates the output text
		/// </summary>
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
		/// <summary>
		/// calls Interpolate when text is changed and all inputs are valid doubles and then updates the output text
		/// </summary>
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
		/// <summary>
		/// calls Interpolate when text is changed and all inputs are valid doubles and then updates the output text
		/// </summary>
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
