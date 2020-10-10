/* Circle.cs
 * Programmer: Bozhou Chem
 * Group Member: Bozhou, Charlie, Cyrus, Jacob, Tyler
 * Date: 10/8/2020
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 8
 * Purpose: This class requires the input of cylinder radius and height from user,
 *          then computes its surface area and volume.
 */

using System;
using static System.Console;
namespace Week7GroupProject
{
    class Cylinder
    {
        // Data members, data fields, or characteristics
        public double cylinderRadius;
        public double cylinderHeight;
        public double cylinderSurfaceArea;
        public double cylinderVolume;

        // Default Constructor
        public Cylinder()
        {

        }

        // Constructor with two arguments
        public Cylinder(double radius, double height)
        {
            cylinderRadius = radius;
            cylinderHeight = height;
            cylinderSurfaceArea = 2 * Math.PI * radius * radius + 2 * Math.PI * radius * height;
            cylinderVolume = Math.PI * radius * radius * height;
        }

        // Properties
        public double CylinderRadius
        {
            get
            {
                return cylinderRadius;
            }
            set
            {
                cylinderRadius = value;
            }
        }
        public double CylinderHeight
        {
            get
            {
                return cylinderHeight;
            }
            set
            {
                cylinderHeight = value;
            }
        }
        public double CylinderSurfaceArea
        {
            get
            {
                return cylinderSurfaceArea;
            }
            set
            {
                cylinderSurfaceArea = value;
            }
        }
        public double CylinderVolume
        {
            get
            {
                return cylinderVolume;
            }
            set
            {
                cylinderVolume = value;
            }
        }
        public override string ToString()
        {
            return "The radius of the cylinder you entered is " + cylinderRadius.ToString("F2") +
                   "\n" + "The height of the cylinder you entered is " + cylinderHeight.ToString("F2") +
                   "\n" + "The surface area of this cylinder is " + cylinderSurfaceArea.ToString("F2") +
                   "\n" + "The volume of this cylinder is " + cylinderVolume.ToString("F2") + "\n";
        }
    }
}