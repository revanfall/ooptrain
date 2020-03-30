using System;

namespace ooptrain
{
    public sealed class Triangle:TwoSections
    {
        private string name;
        public Triangle(string s,int l, int w) : base(l, w)
        {
            name = s = "Triangle";
        }

        public override void Show()
        {
            Console.WriteLine("Lenght: " + Lenght);
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Type: "+name);
        }

        public override int Square()
        {
            return  Lenght * Width;
        }
    }
    }
