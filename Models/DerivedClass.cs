using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_CSharp.Models
{
    public class Circle:Shape
    {
        public float Radius {  get; set; }
        public Circle(string name,float radius):base(name)
        {
            Radius = radius;
        }
        public override void CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius,2);
            Console.WriteLine($"area of circle : {area}");
        }

    }
    public class Rectangle:Shape
    {
        public double Length {  get; set; }
        public double Width {  get; set; }

        public Rectangle(string name,double length,double width) : base(name)
        {
            Length = length;
            Width = width;
        }
        public override void CalculateArea() 
        { 
            double area = Length * Width;
            Console.WriteLine($"area of reactangle : {area}");
        }

    }
}
