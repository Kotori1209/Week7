/* Program.cs
 * Programmer: Bozhou Chem
 * Group Member: Bozhou, Charlie, Cyrus, Jacob, Tyler
 * Date: 10/8/2020
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 8
 * Purpose: This assignment receives a choice of circle, rectangle and cylinder, then 
 *          prompt the user to input appropriate values, then computes the perimeter,
 *          area or volume for the user.
 */

using System;
using static System.Console;

namespace Week7GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            int choice;
            // Prompt the choices
            Write("Please enter the choice from Circle, Rectangle or Cylinder." + "\n" +
                      "(1 for Circle, 2 for Rectangle, 3 for Cylinder.)");
            inputValue = ReadLine();
            choice = int.Parse(inputValue);
            if(choice == 1)
            {
                Circle myCircle = new Circle();
                double radius = myCircle.PromptCircleRadius();
                myCircle.CircleCompute(radius);
            }

            //else if (choice == 2)
                //Rectangle myRectanle = new Rectangle();
            //else if (choice == 3)
                //Cylinder myCylinder = new Cylinder();
            else
                WriteLine("Rua!");

        }
    }
}
