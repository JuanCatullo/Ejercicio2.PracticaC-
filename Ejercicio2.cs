using System;

namespace Ejercicio_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string Linea;
            int PG, PP, PE, Total;
            Console.WriteLine("Ingrese los partidos ganados");
            Linea = Console.ReadLine();
            PG = int.Parse(Linea);
            Console.WriteLine("Ingrese la cantidad de partidos perdidos");
            Linea = Console.ReadLine();
            PP = int.Parse (Linea);
            Console.WriteLine("Ingrese la cantidad de partidos empatados");
            PE = int.Parse (Linea);

            Total = (PG * 3) + PE;

            Console.WriteLine("El puntaje obtenido en la temporada es de" + Total + "puntos");









        }
    }
}
