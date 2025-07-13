using System;
using System.Collections.Generic;
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
			return x;
        }

		/// <summary>
		/// calls update function when text is changed and all text boxes contain valid doubles
		/// </summary>
		private void Y0_TextChanged(object sender, TextChangedEventArgs e)
		{
			TypeConverter inputcheck = TypeDescriptor.GetConverter(typeof(double));
			if (inputcheck.IsValid(y0.Text) && inputcheck.IsValid(y1.Text) && inputcheck.IsValid(y2.Text))
			{
				double numy0 = Convert.ToDouble(y0.Text);
				double numy1 = Convert.ToDouble(y1.Text);
				double numy2 = Convert.ToDouble(y2.Text);
				Update(numy0, numy1, numy2);
			}
		}

		/// <summary>
		/// calls update function when text is changed and all text boxes contain valid doubles
		/// </summary>
		private void Y1_TextChanged(object sender, TextChangedEventArgs e)
		{
			TypeConverter inputcheck = TypeDescriptor.GetConverter(typeof(double));
			if (inputcheck.IsValid(y0.Text) && inputcheck.IsValid(y1.Text) && inputcheck.IsValid(y2.Text))
			{
				double numy0 = Convert.ToDouble(y0.Text);
				double numy1 = Convert.ToDouble(y1.Text);
				double numy2 = Convert.ToDouble(y2.Text);
				Update(numy0, numy1, numy2);

			}
		}

		/// <summary>
		/// calls update function when text is changed and all text boxes contain valid doubles
		/// </summary>
		private void Y2_TextChanged(object sender, TextChangedEventArgs e)
		{
			TypeConverter inputcheck = TypeDescriptor.GetConverter(typeof(double));
			if (inputcheck.IsValid(y0.Text) && inputcheck.IsValid(y1.Text) && inputcheck.IsValid(y2.Text))
			{
				double numy0 = Convert.ToDouble(y0.Text);
				double numy1 = Convert.ToDouble(y1.Text);
				double numy2 = Convert.ToDouble(y2.Text);
				Update(numy0, numy1, numy2);
				
			}
		}

		/// <summary>
		/// function that calls interpolate and updates the graph
		/// </summary>
		/// <param name="y0">y value at x=-1</param>
		/// <param name="y1">y value at x=0</param>
		/// <param name="y2">y value at x=1</param>
		private void Update(double y0, double y1, double y2)
		{
			double x = Interpolate(y0, y1, y2);
			Result.Text = x.ToString();
			WpfPlot1.Reset();
			line(y0, y1, y2, x);
			
		}
		/// <summary>
		/// 
		/// draw the line on the screen
		/// </summary>
		/// <param name="y0">y value at x=-1</param>
		/// <param name="y1">y value at x=0</param>
		/// <param name="y2">y value at x=1</param>
		/// <param name="xmax">the x value of the max or min of y</param>
		private void line(double y0, double y1, double y2, double xmax)
		{
			WpfPlot1.Reset();
			double start = -1;
			double end = 1;
			if (xmax < start)
			{
				start = xmax;
			}
			else if (xmax > end) 
			{
				end = xmax;
			}
			List<double> dataX = new List<double>();
			List<double> dataY = new List<double>();
			for (double i = start; i < end; i += (end-start)/100)
			{
				dataX.Add(i);
				dataY.Add(i * i * (y0 / 2 - y1 + y2 / 2) + i * (-y0 / 2 + y2 / 2) + y1);
				dataY.Add(i * i * (y0 / 2 - y1 + y2 / 2) + i * (-y0 / 2 + y2 / 2) + y1);
			}

			var quadratic = WpfPlot1.Plot.Add.Scatter(dataX, dataY);
			
			quadratic.Smooth = true;
			WpfPlot1.Refresh();
			List<double> exDataX = new List<double> { -1, 0, 1, xmax };
			List<double> exDataY = new List<double>();
			foreach (double i in exDataX)
			{
				exDataY.Add(i * i * (y0 / 2 - y1 + y2 / 2) + i * (-y0 / 2 + y2 / 2) + y1);
			}
			var points = WpfPlot1.Plot.Add.ScatterPoints(exDataX, exDataY);
			points.MarkerSize = 10;
			WpfPlot1.Refresh();

		}
	}
	
}
