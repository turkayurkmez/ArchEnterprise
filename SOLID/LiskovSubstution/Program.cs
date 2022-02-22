using System;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Bir base class'dan türeyen bir derived class olsun. Derived class'ın instance'i base'in davranışını DEĞİŞTİRMEMELİ
             *  Bir base ile derived birbirleriyle yer değiştirebilmeli.
             */

            var rectangle = RectangleFactory(7, 9);
            var square = RectangleFactory(4); 

            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(square.GetArea());
        }

        static IGemoetry RectangleFactory(int unit, int height=1)
        {
            if (height!=1)
            {
                return new Rectangle { Width = unit, Height = height };

            }

            return new Square { UnitLength = unit };
        }


    }

    public interface IGemoetry
    {
        int GetArea();
    }

    public class Rectangle : IGemoetry
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }


    public class Square : IGemoetry 
    {
        public int UnitLength { get; set; }

        //public override int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        //public override int Height { get => base.Height; set { base.Width = value; base.Height = value; } }
        public int GetArea()
        {
            return UnitLength * UnitLength;
        }

    }

}
