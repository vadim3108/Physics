using System;
using System.Collections.Generic;
using System.Text;

namespace Physics
{
    public interface IVectorQuantity
    {
        public double Magnitude { get; set; }
        public Vector Direction { get; set; }
    }

    public class Force : IVectorQuantity
    {
        public double Magnitude { get; set; }
        public Vector Direction { get; set; }
        //F=m*a
        public ComputeForce(double mass, Acceleration acceleration)
        {

        }
    }

    public abstract class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    public class Speed: IVectorQuantity
    {
        public double Magnitude { get; set; }
        public Vector Direction { get; set; }
        //V=m/s
        //V=V+a*time
        //Vavg
    }

    public class Acceleration : IVectorQuantity
    {
        public double Magnitude { get; set; }
        public Vector Direction { get; set; }
        //a = F/m
    }


    public class PhysicalObject
    {
        public double Mass { get; set; }
        public Position Position { get; set; }
        public Force Force { get; set; }
        public Speed Speed { get; set; }
        public Acceleration Acceleration { get; set; }
    }

    
}

