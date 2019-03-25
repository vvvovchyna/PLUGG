using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestTask2
{
    class FitObjectIntoHole
    {
        MyObject myObject = new MyObject();
        Hole someHole = new Hole();

        public void PositiveAnswer(string myObjectChoice, string someHoleChoice)
        {
            Console.WriteLine("Your {0} will fit into the {1}.\n", myObjectChoice, someHoleChoice);
        }
        public void NegativeAnswer(string myObjectChoice, string someHoleChoice)
        {
            Console.WriteLine("Your {0} doesn't will fit into the {1}.\n", myObjectChoice, someHoleChoice);
        }

        public void ParallelepipedIntoRectangle()
        {
            if (someHole.Choice == "rectangle" && myObject.Choice == "parallelepiped")
            {
                if (((myObject.Height < someHole.Height) && (myObject.Width < someHole.Width)) || ((myObject.Height < someHole.Height) && (myObject.Length < someHole.Width))
                            || ((myObject.Length < someHole.Height) && (myObject.Height < someHole.Width)) || ((myObject.Length < someHole.Height) && (myObject.Width < someHole.Width))
                            || ((myObject.Length < someHole.Width) && (myObject.Width < someHole.Height)) || ((myObject.Height < someHole.Width) && (myObject.Width < someHole.Height)))
                {
                    PositiveAnswer(myObject.Choice, someHole.Choice);
                }
                else
                {
                    NegativeAnswer(myObject.Choice, someHole.Choice);
                }
            }
        }

        public void BallIntoRectangle()
        {
            if (someHole.Choice == "rectangle" && myObject.Choice == "ball")
            {
                if (someHole.Height > (myObject.Radius * 2) && someHole.Width > (myObject.Radius * 2))
                {
                    PositiveAnswer(myObject.Choice, someHole.Choice);
                }
                else
                {
                    NegativeAnswer(myObject.Choice, someHole.Choice);
                }
            }
        }

        public void CylinderIntoRectangle()
        {
            if (someHole.Choice == "rectangle" && myObject.Choice == "cylinder")
            {
                if ((someHole.Height > myObject.Height && someHole.Width > (myObject.Radius * 2)) || (someHole.Width > myObject.Height && someHole.Height > (myObject.Radius * 2)))
                {
                    PositiveAnswer(myObject.Choice, someHole.Choice);
                }
                else
                {
                    NegativeAnswer(myObject.Choice, someHole.Choice);
                }
            }
        }
        public void ParallelepipedIntoCircle()
        {
            if (someHole.Choice == "circle" && myObject.Choice == "parallelepiped")
            {
                myObject.DiagonalObject();
                if (myObject.Diagonal < (someHole.Radius * 2))
                {
                    PositiveAnswer(myObject.Choice, someHole.Choice);
                }
                else
                {
                    NegativeAnswer(myObject.Choice, someHole.Choice);
                }
            }
        }

        public void BallIntoCircle()
        {
            if (someHole.Choice == "circle" && myObject.Choice == "ball")
            {
                if (myObject.Radius < someHole.Radius)
                {
                    PositiveAnswer(myObject.Choice, someHole.Choice);
                }
                else
                {
                    NegativeAnswer(myObject.Choice, someHole.Choice);
                }
            }
        }

        public void CylinderIntoCircle()
        {
            if (someHole.Choice == "circle" && myObject.Choice == "cylinder")
            {
                myObject.DiagonalObject();
                if (myObject.Radius < someHole.Radius || myObject.Diagonal < someHole.Radius)
                {
                    PositiveAnswer(myObject.Choice, someHole.Choice);
                }
                else
                {
                    NegativeAnswer(myObject.Choice, someHole.Choice);
                }
            }
        }

        public void FitInto()
        {
            myObject.ChoiceInputObject();
            someHole.ChoiceInputHole();

            ParallelepipedIntoRectangle();
            BallIntoRectangle();
            CylinderIntoRectangle();

            ParallelepipedIntoCircle();
            BallIntoCircle();
            CylinderIntoCircle();
            FitInto();
        }
    }
}
