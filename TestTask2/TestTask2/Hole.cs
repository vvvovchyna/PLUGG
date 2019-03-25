using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{
    class Hole
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public string Choice { get; set; }

        private string s;
        private double d;

        public void InputHoleRadius()
        {
            Console.WriteLine("Input {0}'s radius", Choice);
            s = Console.ReadLine();
            if (double.TryParse(s, out d))
            {
                Radius = Convert.ToDouble(s);
            }
            else
            {
                Console.WriteLine("Input only numbers! Please repeat!");
                InputHoleRadius();
            }
        }

        public void InputHoleWidth()
        {
            Console.WriteLine("Input {0}'s width", Choice);
            s = Console.ReadLine();
            if (double.TryParse(s, out d))
            {
                Width = Convert.ToDouble(s);
            }
            else
            {
                Console.WriteLine("Input only numbers! Please repeat!");
                InputHoleWidth();
            }
        }

        public void InputHoleHeight()
        {

            Console.WriteLine("Input {0}'s height", Choice);
            s = Console.ReadLine();
            if (double.TryParse(s, out d))
            {
                Height = Convert.ToDouble(s);
            }
            else
            {
                Console.WriteLine("Input only numbers! Please repeat!");
                InputHoleHeight();
            }
        }
        public void ChoiceInputHole()
        {
            Console.WriteLine("Select the hole: \npress 1 - rectangle\npress 2 - circle\n");
            s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    {
                        Choice = "rectangle";
                        InputHoleWidth();
                        InputHoleHeight();
                        break;
                    }
                case "2":
                    {
                        Choice = "circle";
                        InputHoleRadius();
                        break;
                    }
                
                default:
                    Console.WriteLine("Input only 1 or 2 ! Please repeat!\n");
                    ChoiceInputHole();
                    break;
            }
        }
    }
}
