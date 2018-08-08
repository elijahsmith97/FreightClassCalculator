/**
 * Author: Elijah Smith
 * Date Completed: 6/25/2018
 * Version: 1.0
 * This program uses Freight Class calculations to convert suggested Density into the correct Freight Class.
 */

using FreightClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FreightClassCalc
{
    int INCHES_TO_FEET = 1728;
    double h;
    double w;
    double d;
    double wt;
    double density;
    double freightClass;
    double cubeFeet;
    double cubeInches;

    public double getDensity(double height, double width, double depth, double weight, ref DimensionClass dimension)
    {
        h = height;
        w = width;
        d = depth;
        wt = weight;

        cubeInches = h * w * d;
        dimension.dimension = cubeInches;
        dimension.weight = weight;
        cubeFeet = cubeInches / INCHES_TO_FEET;
        density = wt / cubeFeet;
        return System.Math.Round(density, 2);
    }

    public double getDensity(List<DimensionClass> list)
    {
        var shipmentDimensions = list.Sum(x => x.dimension);
        var shipmentWeight = list.Sum(x => x.weight);
        cubeFeet = shipmentDimensions / INCHES_TO_FEET;
        density = shipmentWeight / cubeFeet;
        return System.Math.Round(density, 2);
    }
    
    public double getFreightClass(double density)
    {
        if (density >= 50)
            freightClass = 50;
        else if (density < 50 && density >= 35)
            freightClass = 55;
        else  if (density < 35 && density >= 30)
            freightClass = 60;
        else if (density < 30 && density >= 22)
            freightClass = 65;
        else if (density < 22 && density >= 15)
            freightClass = 70;
        else if (density < 15 && density >= 13)
            freightClass = 77.5;
        else if (density < 13 && density >= 12)
            freightClass = 85;
        else if (density < 12 && density >= 10)
            freightClass = 92.5;
        else if (density < 10 && density >= 9)
            freightClass = 100;
        else if (density < 9 && density >= 8)
            freightClass = 110;
        else if (density < 8 && density >= 7)
            freightClass = 125;
        else if (density < 7 && density >= 6)
            freightClass = 150;
        else if (density < 6 && density >= 5)
            freightClass = 175;
        else if (density < 5 && density >= 4)
            freightClass = 200;
        else if (density < 4 && density >= 3)
            freightClass = 250;
        else if (density < 3 && density >= 2)
            freightClass = 300;
        else if (density < 2 && density >= 1)
            freightClass = 400;
        else
            freightClass = 500;

        return freightClass;
    }
}
