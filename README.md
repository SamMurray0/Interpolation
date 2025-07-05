# Description
Program to calculate x coordinate of the peak of a quadratic line given the y values at X= -1, 0 and 1.

To use the program enter the y values in the boxes labeled y0, y1 and y2 and the x value will be printed out on the screen.

# Proof of formula used
The original equations I found on this website:

https://www.pw.live/school-prep/exams/quadratic-interpolation-formula

The value of y at point x given 3 points on the quadratic curve is given by this equation:

y = y<sub>0</sub> × L<sub>0</sub>(x) + y<sub>1</sub> × L<sub>1</sub>(x) + y<sub>2</sub> × L<sub>2</sub>(x)))

Where,

y<sub>0</sub>, y<sub>1</sub>, and y<sub>2</sub> are “y-value” of the three known data point,
x<sub>0</sub>, x<sub>1</sub>, and x<sub>2</sub> are “x-value” of the three known data point, and
L<sub>0</sub>(x), L<sub>1</sub>(x), and L<sub>2</sub>(x) are the Lagrange basis polynomial.
Lagrange basis polynomials are defined as:

L<sub>0</sub> (x) = (x – x<sub>1</sub>) × (x – x<sub>2</sub>) / ((x<sub>0</sub> – x<sub>1</sub>) × (x<sub>0</sub> – x<sub>2</sub>))

L1 (x) = (x – x<sub>0</sub>) × (x – x<sub>2</sub>) / ((x<sub>1</sub> – x<sub>0</sub>) × (x<sub>1</sub> – x<sub>2</sub>))

L2 (x) = (x – x<sub>0</sub>) × (x – x<sub>1</sub>) / ((x2 – x<sub>0</sub> ) × (x<sub>2</sub> – x<sub>1</sub>))

Lagrange basis polynomials equation from website, substituting in -1, 0 and 1 for x<sub>0</sub>, X<sub>1</sub> and X<sub>2</sub> gives 

y = y<sub>0</sub>*(x<sup>2</sup> -x)/2 - y<sub>1</sub>*(x<sup>2</sup> +1)/1 + y<sub>2</sub>*(x<sup>2</sup> +x)/2
			  
Which expands to

y = x<sup>2</sup> (y<sub>0</sub>/2 - y<sub>1</sub> + y<sub>2</sub>/2) +x (-y<sub>0</sub>/2 + y<sub>2</sub>/2) -y<sub>1</sub>
			  
differentiate to find rate of change of y by x

dy/dx = 2x(y<sub>0</sub>/2 - y<sub>1</sub> +y<sub>2</sub>/2) + y<sub>2</sub>/2 - y<sub>0</sub>/2
		  
set differential equal to 0 to find the maxima

0 = 2x(y<sub>0</sub>/2 - y<sub>1</sub> +y<sub>2</sub>/2) + y<sub>2</sub>/2 - y<sub>0</sub>/2
			  
solve for x in terms of y0, y1 and y2

(y<sub>0</sub>/2 - y2/2) = 2x(y<sub>0</sub>/2 - y<sub>1</sub> + y<sub>2</sub>/2)

x = (y<sub>0</sub>/2 - y<sub>2</sub>/2)/2*(y<sub>0</sub>/2 - y<sub>1</sub> + y<sub>2</sub>/2)
			  
therefore the following equation gives the value of x where y is at a maximum or minumum

x = (y<sub>0</sub>-y<sub>2</sub>)/2(y<sub>0</sub> - 2y<sub>1</sub> + y<sub>2</sub>) 
