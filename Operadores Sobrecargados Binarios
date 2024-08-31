using System;

public class TresD
{
    int x, y, z;

    public TresD()
    {
        x = y = z = 0;
    }

    public TresD(int i, int j, int k)
    {
        x = i;
        y = j;
        z = k;
    }

    public static TresD operator +(TresD op1, TresD op2)
    {
        TresD result = new TresD();
        result.x = op1.x + op2.x;
        result.y = op1.y + op2.y;
        result.z = op1.z + op2.z;
        return result;
    }

    public static TresD operator -(TresD op1, TresD op2)
    {
        TresD result = new TresD();
        result.x = op1.x - op2.x;
        result.y = op1.y - op2.y;
        result.z = op1.z - op2.z;
        return result;
    }

    public void Show()
    {
        Console.WriteLine(x + "," + y + "," + z);
    }
}

public class TresDDemo
{
    public static void Main()
    {
        TresD a = new TresD(1, 2, 3);
        TresD b = new TresD(10, 10, 10);
        TresD c;

        Console.Write("Aqui está a: ");
        a.Show();
        Console.WriteLine();

        Console.Write("Aqui está b: ");
        b.Show();
        Console.WriteLine();

        c = a + b;
        Console.Write("Resultado de a + b: ");
        c.Show();
        Console.WriteLine();

        c = a + b + c;
        Console.Write("Resultado de a + b + c: ");
        c.Show();
        Console.WriteLine();

        c = c - a;
        Console.Write("Resultado de c - a: ");
        c.Show();
        Console.WriteLine();

        c = c - b;
        Console.Write("Resultado de c - b: ");
        c.Show();
        Console.WriteLine();
    }
}
