using System;

namespace Ejercicio3plus
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int n = 1, con, Grupo = 0;
            
            while(n >= 0){
                Grupo++;
                con = 0;
                n = int.Parse(Console.ReadLine());
                while(n > 0){
                con++;
                n = int.Parse(Console.ReadLine());}
                Console.WriteLine("El grupo " + Grupo + " tiene " + con + " nros.");
                }

        
        
        
        }        
        
    
    
    }

        
               
   
}    
            
        
    

