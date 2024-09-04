using Sobrecarga_caso_estudio_02;
using System;
namespace Sobrecarga_caso_estudio_02
{
    public class Complejo
    {
        private double real;
        private double imaginario;
        public Complejo(double re, double im)
        {
            real = re; imaginario = im;
        }
        public void AsignarComplejo(double re, double im)
        {
            real = re; imaginario = im;
        }
        public static Complejo operator +(Complejo a, Complejo b)
        {
            return new Complejo(a.real + b.real, a.imaginario + b.imaginario);
        }
        public static Complejo operator -(Complejo a, Complejo b)
        {
            return new Complejo(a.real - b.real, a.imaginario - b.imaginario);
        }
        public override string ToString()
        {
            return (String.Format("{0}" + (imaginario >= 0 ? "+" : "") + "{1}i", real, imaginario));

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Complejo a = new Complejo(1.2, 2);
            Complejo b;
            Complejo c = new Complejo(1.5, 2);
            Complejo d;
            double real, imaginario;
            Console.WriteLine("Numero complejo: ");
            Console.WriteLine("re: ");
            real = double.Parse(Console.ReadLine());
            Console.WriteLine("im: ");
            imaginario = double.Parse(Console.ReadLine());
            a.AsignarComplejo(real, imaginario);
            b = a;
            d = a + b - c;
            d = d + new Complejo(5, 2);
            Console.WriteLine(d.ToString());
        }
    }

}
