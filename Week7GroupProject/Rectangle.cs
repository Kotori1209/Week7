/* Rectangle.cs
 * Programmer: Bozhou Chem
 * Group Member: Bozhou, Charlie, Cyrus, Jacob, Tyler
 * Date: 10/8/2020
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 8
 * Purpose: This class requires the input of rectangle length and width from user,
 *          then computes its polygon diagonals, perimeter and area.
 */

using System;
using static System.Console;

namespace Week7GroupProject
{
    class Rectangle
    {
        // Data members, data fields, or characteristics
        public double rectangleLength;
        public double rectangleWidth;
        public double rectanglePolygonDiagonals;
        public double rectanglePerimeter;
        public double rectangleArea;

        // Default Constructor
        public Rectangle()
        {

        }

        // Constructor with two arguments
        public Rectangle(double length, double width)
        {
            rectangleLength = length;
            rectangleWidth = width;
            rectanglePolygonDiagonals = Math.Sqrt(length * length + width * width);
            rectanglePerimeter = 2 * (length + width);
            rectangleArea = length * width;
        }

        // Properties
        public double RectangleLength
        {
            get
            {
                return rectangleLength;
            }
            set
            {
                rectangleLength = value;
            }
        }
        public double RectangleWidth
        {
            get
            {
                return rectangleWidth;
            }
            set
            {
                rectangleWidth = value;
            }
        }
        public double RectanglePolygonDiagonals
        {
            get
            {
                return rectanglePolygonDiagonals;
            }
            set
            {
                rectanglePolygonDiagonals = value;
            }
        }
        public double RectanglePerimeter
        {
            get
            {
                return rectanglePerimeter;
            }
            set
            {
                rectanglePerimeter = value;
            }
        }
        public double RectangleArea
        {
            get
            {
                return rectangleArea;
            }
            set
            {
                rectangleArea = value;
            }
        }
        public override string ToString()
        {
            return "The length of the rectangle you entered is " + rectangleLength.ToString("F2") +
                    "\n" + "The width of the rectangle you entered is " + rectangleWidth.ToString("F2") +
                    "\n" + "The value of polygon diagonals of this rectangle is " +
                    rectanglePolygonDiagonals.ToString("F2") + "\n" +
                    "The perimeter of this rectangle is " +
                    rectanglePerimeter.ToString("F2") + "\n" + "The area of this rectangle is " +
                    rectangleArea.ToString("F2") + "\n";
        }
    }
}
