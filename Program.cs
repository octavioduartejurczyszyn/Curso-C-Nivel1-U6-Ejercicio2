using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
            // Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números que
            // forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor
            int n, porcentaje, maxporcentaje = 0, grupo = 0, cangruposdecre = 0 ;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Escriba un nro: ");
                n = int.Parse(Console.ReadLine());
                int con = 0, conImp = 0, maxn = n + 1, conmaxn = 0;
                while (n != 0)
                {
                    con++;
                    if (n % 2 != 0)
                         conImp++;
                    if (n < maxn)
                    {
                        maxn = n;
                        conmaxn++;
                    }
                Console.WriteLine("Escriba otro nro: ");
                n = int.Parse(Console.ReadLine());
                }
                    porcentaje = conImp * 100 / con;
                    if (porcentaje > maxporcentaje)
                    {
                        maxporcentaje = porcentaje;
                        grupo = x + 1;
                    }    
                    if (conmaxn == con)
                        cangruposdecre++;
            }
            
            Console.WriteLine("El grupo con mayor porcentaje de nros impares es: " + grupo);
            Console.WriteLine("La cantidad de grupos que están ordenados de forma decreciente son: " + cangruposdecre);
        }
    }
}
