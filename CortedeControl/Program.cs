using System;

namespace CortedeControl
{
    class Program
    {
        static void Main(string[] args)
        {

            //CORTE DE CONTROL SE USA PARA LOTES DE DATOS AGRUPADOS
            //DE MANERA QUE SI CARGO TODAS LAS PERSONAS DEL CODIGO 3
            //NO PUEDO CARGAR OTRA EN EL MEDIO Y CARGAR DENUEVO
            //PERSONAS DEL 3, TENGO QUE CARGAR GRUPO POR GRUPO. 
            //legajo, edad, sueldo
            
            
            int legajo, edad; codigoEquipo
            float sueldo;
            Console.WriteLine("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el edad: ");
            edad = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo: ");
            codigodeEquipo = int.Parse(Console.ReadLine());
            

            while (sueldo > 0){

                equipoActual = codigodeEquipo;
                while(true){
                    Console.WriteLine("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el edad: ");
            edad = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de equipo: ");
            codigodeEquipo = int.Parse(Console.ReadLine());

                }
            



            }Console.WriteLine("Hello World!");
        }
    }
}
