// Este programa define una clase `CFecha` que maneja fechas, incluyendo la asignación, validación y obtención de fechas.
// La clase `CFecha` incluye métodos para verificar si un año es bisiesto, validar si una fecha es correcta,
// y asignar y obtener una fecha. La clase `Program` contiene el método `Main`, que sirve como punto de entrada
// del programa y demuestra el uso de la clase `CFecha` al asignar, validar y mostrar una fecha.

using System;

public class CFecha
{
    private int dia, mes, ano; // Variables privadas para almacenar el día, mes y año de la fecha

    // Método protegido para determinar si el año actual es bisiesto
    protected bool Bisiesto()
    {
        // Un año es bisiesto si es divisible por 4, pero no por 100, o es divisible por 400
        return ((ano % 4 == 0) && (ano % 100 != 0) || (ano % 400 == 0));
    }

    // Método público para asignar una fecha
    public void AsignarFecha(int dd, int mm, int aaaa)
    {
        dia = dd;   // Asigna el día
        mes = mm;   // Asigna el mes
        ano = aaaa; // Asigna el año
    }

    // Método público para obtener la fecha actual
    public void ObtenerFecha(out int dd, out int mm, out int aaaa)
    {
        dd = dia;   // Devuelve el día
        mm = mes;   // Devuelve el mes
        aaaa = ano; // Devuelve el año
    }

    // Método público para verificar si la fecha asignada es correcta
    public bool FechaCorrecta()
    {
        bool diaCorrecto, mesCorrecto, anoCorrecto;

        // Verifica si el año es mayor o igual a 1582 (inicio del calendario gregoriano)
        anoCorrecto = (ano >= 1582);

        // Verifica si el mes está en el rango válido (1 a 12)
        mesCorrecto = (mes >= 1) && (mes <= 12);

        // Verifica la validez del día basado en el mes
        switch (mes)
        {
            case 2: // Febrero
                if (Bisiesto()) // Si es un año bisiesto
                    diaCorrecto = (dia >= 1 && dia <= 29); // Febrero puede tener 29 días
                else
                    diaCorrecto = (dia >= 1 && dia <= 28); // Febrero tiene 28 días en años no bisiestos
                break;
            case 4: case 6: case 9: case 11: // Meses con 30 días
                diaCorrecto = (dia >= 1 && dia <= 30); // Verifica si el día está en el rango válido para estos meses
                break;
            default: // Para todos los otros meses (enero, marzo, mayo, julio, agosto, octubre, diciembre)
                diaCorrecto = (dia >= 1 && dia <= 31); // Estos meses tienen hasta 31 días
                break;
        }

        // La fecha es correcta si el día, mes y año son válidos
        return diaCorrecto && mesCorrecto && anoCorrecto;
    }
}

class Program
{
    // Método Main: punto de entrada del programa
    // Este programa crea una instancia de la clase CFecha, asigna una fecha, verifica su validez
    // y luego imprime la fecha asignada junto con un mensaje indicando si la fecha es correcta.
    static void Main(string[] args)
    {
        // Crear una instancia de CFecha
        CFecha fecha = new CFecha();

        // Asignar una fecha (29 de febrero de 2024, que es un año bisiesto)
        fecha.AsignarFecha(29, 2, 2024);

        // Verificar si la fecha asignada es correcta
        bool correcta = fecha.FechaCorrecta();
        Console.WriteLine("La fecha es correcta: " + correcta);

        // Obtener la fecha asignada
        int dd, mm, aaaa;
        fecha.ObtenerFecha(out dd, out mm, out aaaa);
        Console.WriteLine($"Fecha asignada: {dd}/{mm}/{aaaa}");
    }
}
