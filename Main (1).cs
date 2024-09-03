using System;

class Punto
{
    private double x, y;

    public Punto() {}

    public Punto(double cx, double cy)
    {
        x = cx;
        y = cy;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }
}

class Circulo
{
    private Punto centro;
    private double radio;

    protected void MsgEsNegativo()
    {
        Console.WriteLine("El radio es negativo. Se convierte a positivo.");
    }

    public Circulo() {}

    public Circulo(double cx, double cy, double r)
    {
        centro = new Punto(cx, cy);
        if (r < 0)
        {
            MsgEsNegativo();
            r = -r;
        }
        radio = r;
    }

    public double LongCircunferencia()
    {
        return 2 * Math.PI * radio;
    }

    public double AreaCirculo()
    {
        return Math.PI * radio * radio;
    }

    public double Radio
    {
        get { return radio; }
        set
        {
            if (value < 0)
            {
                MsgEsNegativo();
                value = -value;
            }
            radio = value;
        }
    }

    public Punto Centro
    {
        get { return centro; }
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Circulo c = new Circulo(100.0, 200.0, 10.0);
        double area = c.AreaCirculo();
        double circ = c.LongCircunferencia();
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Circunferencia: " + circ);
    }
}
