using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{
    class MyObject
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Radius { get; set; }
        public double Diagonal { get; set; }
        public string Choice { get; set; }

        private string s;
        private double d;
        

        public void InputObjectRadius()
        {
            Console.WriteLine("\nInput {0}'s radius", Choice);
            s = Console.ReadLine();
            if (double.TryParse(s, out d))
            {
                Radius = Convert.ToDouble(s);
            }
            else
            {
                Console.WriteLine("Input only numbers!Please repeat!");
                InputObjectRadius();
            }
        }

        public void InputObjectWidth()
        {
            Console.WriteLine("\nInput {0}'s width", Choice);
            s = Console.ReadLine();
            if (double.TryParse(s, out d))
            {
                Width = Convert.ToDouble(s);
            }
            else
            {
                Console.WriteLine("Input only numbers!Please repeat!");
                InputObjectWidth();
            }
        }

        public void InputObjectHeight()
        {
            Console.WriteLine("Input {0}'s height", Choice);
            s = Console.ReadLine();
            if (double.TryParse(s, out d))
            {
                Height = Convert.ToDouble(s);
            }
            else
            {
                Console.WriteLine("Input only numbers!Please repeat!");
                InputObjectHeight();
            }
        }

        public void InputObjectLength()
        {
            Console.WriteLine("Input {0}'s length", Choice);
            s = Console.ReadLine();
            if (double.TryParse(s, out d))
            {
                Length = Convert.ToDouble(s);
            }
            else
            {
                Console.WriteLine("Input only numbers! Please repeat!");
                InputObjectLength();
            }
        } 

        public void DiagonalObject()
        {
            if ((Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Height, 2))) > (Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Length, 2))) 
                && (Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Height, 2))) > (Math.Sqrt(Math.Pow(Height, 2) * Math.Pow(Length, 2))))
            {
                Diagonal = (Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Height, 2)));
            }
            else if ((Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Length, 2))) > (Math.Sqrt(Math.Pow(Height, 2) * Math.Pow(Length, 2))))
            {
                Diagonal = (Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Length, 2)));
            }
            else
                Diagonal = (Math.Sqrt(Math.Pow(Height, 2) * Math.Pow(Length, 2)));
        }
        public void ChoiceInputObject()
        {
                Console.WriteLine("Select the object: \npress 1 - parallelepiped\npress 2 - ball\npress 3 - cylinder\n");
                s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                    {
                        Choice = "parallelepiped";
                        InputObjectWidth();
                        InputObjectHeight();
                        InputObjectLength();
                        break;
                    }
                    case "2":
                    {
                        Choice = "ball";
                        InputObjectRadius();
                        break;
                    }
                    case "3":
                    {
                        Choice = "cylinder";
                        InputObjectRadius();
                        InputObjectHeight();
                        break;
                    }

                default:
                        Console.WriteLine("Input only 1 or 2 or 3! Please repeat!\n");
                        ChoiceInputObject();
                        break;
                }
        }
    }
}
