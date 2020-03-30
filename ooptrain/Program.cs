using System;

namespace ooptrain
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSections tw=new TwoSections(-9,-4);
            tw.Show();
            Triangle triangle=new Triangle("m;mk",-5,8);
            triangle.Show();
            Console.WriteLine(triangle.Square());
            Rectangle rec=new Rectangle("qwerty",10,-8);
            rec.Show();
            Console.WriteLine(rec.Square());
            SquareRect square=new SquareRect(-10);
            square.Show();
            Console.WriteLine(square.Square());

        }
    }
}