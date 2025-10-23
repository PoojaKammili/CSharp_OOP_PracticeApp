using OOP_Basics_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Basics_CSharp.Models;

namespace OOP_Basics_CSharp.Services
{
    
    public class CRUD_Service
    {
        static List<Shape> shapes = new List<Shape>();
        public void AddCircleArea()
        {
            var shape = new Circle("circle",3);
            shapes.Add(shape);
            shape.CalculateArea();
        }
        public void AddRectangleArea()
        {
            var shape = new Rectangle("rectangle", 3, 5);
            shapes.Add(shape);
            shape.CalculateArea();
        }

        public void RemoveArea(string name)
        {
            var shape = shapes.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            shapes.Remove(shape);
            Console.WriteLine($"{name} removed successfully");
        }
        public void DisplayAll()
        {
            foreach (var shape in shapes)
            {
                shape.CalculateArea();
            }
        }
        
    }
}
