# Description
Currently contains 2 different funtions to calculate the peak of a quadratic line given the y values at X= -1, 0 and 1

currently requires changing the values inside the code manually but will be updated with a UI
# Proof of formula used
The original equations I found on the website with adress

https://www.pw.live/school-prep/exams/quadratic-interpolation-formula

y = y 0 × L 0 (x) + y 1 × L 1 (x) + y 2 × L 2 (x)))

Where,

y<sub>0</sub>, y<sub>1</sub>, and y<sub>2</sub> are “y-value” of the three known data point,
x<sub>0</sub>, x<sub>1</sub>, and x<sub>2</sub> are “x-value” of the three known data point, and
L<sub>0</sub>(x), L<sub>1</sub>(x), and L<sub>2</sub>(x) are the Lagrange basis polynomial.
Lagrange basis polynomials are defined as:

L<sub>0</sub> (x) = (x – x<sub>1</sub>) × (x – x<sub>2</sub>) / ((x<sub>0</sub> – x<sub>1</sub>) × (x<sub>0</sub> – x<sub>2</sub>))

L1 (x) = (x – x<sub>0</sub>) × (x – x<sub>2</sub>) / ((x<sub>1</sub> – x<sub>0</sub>) × (x<sub>1</sub> – x<sub>2</sub>))

L2 (x) = (x – x<sub>0</sub>) × (x – x<sub>1</sub>) / ((x2 – x<sub>0</sub> ) × (x<sub>2</sub> – x<sub>1</sub>))

Lagrange basis polynomials equation from website, substituting in -1, 0 and 1 for x<sub>0</sub>, X<sub>1</sub> and X<sub>2</sub> 

y = y<sub>0</sub>*(x<sup>2</sup> -x)/2 - y<sub>1</sub>*(x<sup>2</sup> +1)/1 + y<sub>2</sub>*(x<sup>2</sup> +x)/2
			  
Expands to

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
