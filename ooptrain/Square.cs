using System;

namespace ooptrain
{
    
    public class SquareRect:TwoSections
    {
        private  string name;
    public SquareRect(int l):base(l)
    {
        name = "квадрат";
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Type: "+name);
    }
    
    public override int Square()
    {
        return  (int)Math.Pow((double)Lenght,(double)2);
    }
    }
}