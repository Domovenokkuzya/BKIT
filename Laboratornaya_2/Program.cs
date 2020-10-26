using System;
using System.Net.NetworkInformation;
namespace Laboratornaya_2
{
    interface IPrint
    {
        void Print();
    }
    public abstract class Geometricalfigure
    {
        public abstract string Square();
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;
        public override string ToString()
        {
            return this.Type + " площадью " + this.Square().ToString();
        }

    }

    public class Rectangle : Geometricalfigure, IPrint
    {
        private double Width;
        private double Height;
        public Rectangle(double W, double H)
        {
            this.Width = W;
            this.Height = H;
            this.Type = "Прямоугольник";
        }
        public override string Square()
        {
            return (Width * Height).ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }


    }

    public class Box : Rectangle, IPrint
    {
        private double Width;
        public Box(double size) : base(size, size)
        {
            this.Width = size;
            this.Type = "Квадрат";
        }
        public override string Square()
        {
            return (Width * Width).ToString(); ;
        }
        

    }
    public class Circle : Geometricalfigure, IPrint
    {
        public double Radius;
        double pi = 3.14;
        public Circle(double r)
        {
            this.Radius = r;
            this.Type = "Круг";
        }
        public override string Square()
        {
            return (pi * Radius * Radius).ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 4);
            Box b = new Box(5);
            Circle c = new Circle(5);
            r.Print();
            b.Print();
            c.Print();
            Console.ReadLine();
        }
    }
}
