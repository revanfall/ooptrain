using System;

namespace ooptrain
{
    public class TwoSections
    {
        protected int pre_lenght;
        protected int pre_width;

        public TwoSections(int l, int w)
        {
            Lenght=l;
            Width = w;
        }

        protected TwoSections()
        {
        }

        protected TwoSections(int l)
        {
            Lenght = Width = l;
        }

        public int Lenght
        {
            get { return pre_lenght;}
            set {
                if (value < 0)
                    pre_lenght = -value;
                else pre_lenght=value;
            }
        }

        public int Width
        {
            get { return pre_width; }
            set
            {
                if (value < 0)
                    pre_width = -value;
                else pre_width = value;
            }
        }

        public virtual void Show()
        {
            Console.WriteLine("Width: "+pre_width);
            Console.WriteLine("Height: "+pre_lenght);
        }

        public virtual int Square()
        {
            return 0;
        }

    }
}