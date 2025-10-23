using OOP_Basics_CSharp.Models;
using OOP_Basics_CSharp.Services;
using System;

namespace OOP_Basics_CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            CRUD_Service service = new CRUD_Service();
           
            
            while (true)
            {
                Console.WriteLine("\n---------------------------------------------------------------");
                Console.WriteLine("\nchoose option 1 - 6");
                Console.WriteLine("1 - Add Circle");
                Console.WriteLine("2 - Add Rectangle");
                Console.WriteLine("3 - Remove Shape");
                Console.WriteLine("4 - Display All");
                Console.WriteLine("5 - Exit");
                Console.WriteLine("Enter your option : ");
                int options = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------");
                switch (options)
                {
                    case 1:
                        //addcircle
                        service.AddCircleArea();
                        break;
                    case 2:
                        //addrectangle
                        service.AddRectangleArea();
                        break;
                    case 3:
                        //removearea
                        Console.WriteLine("Enter the name of the shape you want to remove the area : ");
                        string name = Console.ReadLine();
                        service.RemoveArea(name);
                        break;
                    case 4:
                        //display
                        service.DisplayAll();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("error while choosing options!!.choose correct option!!");
                        break;
                }
            }
        }
    }
}
