using System;

namespace ooptrain
{
    public class Rectangle:TwoSections
    {
        private string name;
        public Rectangle()
        {
            Lenght = 0;
            Width = 0;
            name = null;

        }

        public Rectangle(string n,int l, int w) : base(l, w)
        {
            name = n = "прямоугольник";

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Type: "+name);
        }

        public override int Square()
        {
            return Lenght * Width;
        }
    }
}