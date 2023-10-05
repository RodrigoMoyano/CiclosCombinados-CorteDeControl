using System;

namespace CiclosConbinados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los ciclos conbinados sirven para realizar programas que requieran cargar datos por grupos
            //ej: cargar la edad de 10 grupos de 5 pesonas, lo cual si no conbinamos ciclos tendriamos que cargar
            //invidualmente 10 ciclos con 5 personas, pero si fueran mas de 10 grupos 100 o 1000,
            //lo que se hace es cargar un ciclo sea un for si tenemos la cantidad exacta o un while si no, 
            //para cargar grupos y otro ciclo dentro donde en este caso cargariamos la edad de cada persona.
            
            //FOR CON FOR
            
            //int prom, acu, n;
            // for (int y = 0; y < 10; y++)
            //{
            //    acu = 0;
            //    for (int x = 0; x < 20; x++)
            //    {
            //        Console.WriteLine("Ingrese la edad: ");
            //        n = int.Parse(Console.ReadLine());
            //        acu += n;
                    
                    
            //    }
            //    prom = acu / 20;
            //   Console.WriteLine("El promedio es: " + promedio);
            // }

            //FOR CON WHILE

        //for (int x = 0; x < 10; x++)
        //{
            
            
        //Console.WriteLine("Ingrese la edad:");
        // n = int.Parse(Console.ReadLine());
        //acu = 0;
        //con = 0;
        //while(n != 0){
        //    acu += n;
        //    con++
        //    Console.WriteLine("Ingrese la edad: ");
        //    n = int.Parse(Console.ReadLine());

        //     }
        // }
        //  prom = acu / con
        //  Console.WriteLine("El promedio es: "+ prom);
        //}
       // {
         
         //Console.WriteLine("Ingrese la edad:");
         //n = int.Parse(ReadLine());
         //while(n != 0){
         //acu = 0;
         //for (int x = 0; x < 20; x++)
         //{
         //  Console.WriteLine("Ingrese la edad:");
         //  n = int.Parse(ReadLine());
         //   acu += n;
         //   }
         //  prom = acu/20;
         //  Console.WriteLine("El promedio es:");
         //   Console.WriteLine("Ingrese 1 continuar o 0 para terminar.");
         //   }
            
            //WHILE CON WHILE
            Console.WriteLine("Ingrese la edad:");
            n = int.Parse(ReadLine());
            while(n > 0){
               acu = 0;
               con = 0;
              while(n != 0){
                  acu += 0;
                  con++;
                  Console.WriteLine("Ingrese la edad:");
               }
               prom = acu/20;
               Console.WriteLine("El promedio es:");

               Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar.");
               n = int.Parse(ReadLine());
        }    }



         
    }
}
