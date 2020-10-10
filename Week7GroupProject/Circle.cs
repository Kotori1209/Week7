/* Circle.cs
 * Programmer: Bozhou Chem
 * Group Member: Bozhou, Charlie, Cyrus, Jacob, Tyler
 * Date: 10/8/2020
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 8
 * Purpose: This class requires the input of circle radius from user,
 *          then computes its circumference and area.
 */

using System;
using static System.Console;

namespace Week7GroupProject
{
    class Circle
    {
        // Data members, data fields, or characteristics
        double circleRadius;
        double circleCircumference;
        double circleArea;

        public double PromptCircleRadius()
        {
            string inputValue;
            Write("Please enter the radius of your circle: ");
            inputValue = ReadLine();
            circleRadius = double.Parse(inputValue);
            return circleRadius;
        }
        public void CircleCompute(double circleRadius)
        {
            circleCircumference = 2 * Math.PI * circleRadius;
            circleArea = Math.PI * circleRadius * circleRadius;
            WriteLine("The radius of the circle you entered is " + circleRadius.ToString("F2") +
                   "\n" + "The circumference of this circle is " + circleCircumference.ToString("F2") +
                   "\n" + "The area of this circle is " + circleArea.ToString("F2") + "\n");
            return;
        }
    }
}
