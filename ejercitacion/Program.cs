using System;

namespace ejercitacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conImpar, con, grupoMax = 0, Min, Ordenados = 0;
            double prom, promMax= -1;
            bool BanOrdenados;
            
            for (int x = 0; x < 5; x++)
            {con = 0;
             conImpar = 0;
             BanOrdenados = true;
             n = int.Parse(Console.ReadLine());
             Min = n;

                while(n != 0){
                con++;
                if(n / 2 != 0){
                conImpar++;}
                if(n <= Min)
                Min = n;
                else
                BanOrdenados = false;
                n = int.Parse(Console.ReadLine());
                }
                prom = (conImpar * 100) / con;
                if(prom > promMax){
                 promMax = prom;
                 grupoMax = x + 1;
                 }
                 if(BanOrdenados)
                 Ordenados++;


                
            }Console.WriteLine("El grupo con mayor cantidad de nros impares es el: " + grupoMax);
            Console.WriteLine("La cantidad de grupos ordenados de mayor a menor son: " + Ordenados);


            
        }
    }
}
