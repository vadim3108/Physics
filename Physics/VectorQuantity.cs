using System;
using System.Collections.Generic;
using System.Text;

namespace Physics
{
    public abstract class VectorQuantity
    {
        public double Magnitude { get; set; }
        public Vector Direction { get; set; }
    }

    public abstract class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class Force : VectorQuantity
    {

    }


    public class PhysicalObject: IPosition, Force  
    {
    }
}

