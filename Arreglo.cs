using System;
namespace Arreglo
{
    class Program
    {
        static void Main(String[] args){
            //Variables iniciales
            float[] Numeros = new float[10];
            bool Condition = true; 
            bool ConditionInsert;
            float InsertNum;
            do{
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Bienvenidos! - ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ingrese 10 Numeros y obtendra el Mayor y el Menor");
                for(int i = 0; i < Numeros.Length; ++i){
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Ingresa el valor #{0}:", i+1);
                    Console.ForegroundColor = ConsoleColor.White;
                    //De no ser un valor numérico lanzara falso
                    ConditionInsert = float.TryParse(Console.ReadLine(), out InsertNum);
                    /*De ser verdadero, el arreglo en la posición 'i' tomara
                    el valor ingresado*/
                    if(ConditionInsert == true){
                        Numeros[i] = InsertNum;
                    }else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor no numérico");
                        /*este permitira que el se mantenga misma posicion 
                        hasta que se cumpla correctamente la condición 
                        de arriba*/
                        i -= 1;
                    }
                }
                /*variables que toman el valor de la primera posicion del 
                arreglo para luego ser comparados y obtener el mayor y el menor.
                Tambien se pueden utilizar las funciones .Max() & .Min(). 
                Ejemplo: Numeros.Max();  | Numeros.Min();
                En este caso para proyectar la parte logica lo coloque así*/
                float Mayor = Numeros[0];
                float Menor = Numeros[0];
                for(int i = 0; i < Numeros.Length; i++){
                    if(Numeros[i] > Mayor){
                        Mayor = Numeros[i];
                    }else if(Numeros[i] < Menor){
                        Menor = Numeros[i];
                    }
                }
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("El número Mayor es: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Mayor +"\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("El número Menor es: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Menor);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nSi desea salir pulse '1'");
                Console.ForegroundColor = ConsoleColor.White;
        
                string Continuar = Console.ReadLine();
                //Si se inserta '1'
                if(Continuar == "1"){
                    /*Cambia la condición a falso, de modo que se 
                        cerrará el programa.*/
                    Condition = false;
                    Console.Clear();
                    Console.WriteLine("Hasta luego! :)");
                }else //Sino
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Reiniciando... ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Pulse alguna tecla.");
                }
                Console.ReadKey();
                Console.Clear();
            }while (Condition);         
        }
    }    
}
