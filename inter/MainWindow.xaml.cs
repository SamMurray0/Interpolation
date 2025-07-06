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
           

			double x = (y0 - y2) / (2 * (y0 - 2 * y1 + y2));

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
				double numy0 = Convert.ToDouble(y0.Text);
				double numy1 = Convert.ToDouble(y1.Text);
				double numy2 = Convert.ToDouble(y2.Text);
				update(numy0, numy1, numy2);



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
				double numy0 = Convert.ToDouble(y0.Text);
				double numy1 = Convert.ToDouble(y1.Text);
				double numy2 = Convert.ToDouble(y2.Text);
				update(numy0, numy1, numy2);

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
				double numy0 = Convert.ToDouble(y0.Text);
				double numy1 = Convert.ToDouble(y1.Text);
				double numy2 = Convert.ToDouble(y2.Text);
				update(numy0, numy1, numy2);
				
				
			}
		}

		private void update(double y0, double y1, double y2)
		{
			double x = Interpolate(y0, y1, y2);
			Result.Text = x.ToString();
			WpfPlot1.Reset();

			double ymax = (x * x * (y0 / 2 - y1 + y2 / 2) + x * (-y0 / 2 + y2 / 2) + y1);
			
			double[] dataX = { -1, 0, 1, x };

			Array.Sort(dataX);
			int arrayPos = Array.IndexOf(dataX, x);
			double[] dataY = { y0, y1, y2, ymax };
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine(dataY[i]);
			}

			double nextVal = ymax;
			for (int i = arrayPos; i < 4; i++)
			{
				double temp = dataY[i];
				dataY[i] = nextVal;
				nextVal = temp;
			}

			var sp = WpfPlot1.Plot.Add.Scatter(dataX, dataY);
			sp.Smooth = true;
			WpfPlot1.Refresh();
		}
	}
	


}
