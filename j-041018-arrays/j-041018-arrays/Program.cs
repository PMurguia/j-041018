using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j_041018_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.

            //int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 

            //for (int i = 0; i < numeros.Length ; i++)
            //{

            //    Console.WriteLine(numeros[i]);
            //}
            //    Console.ReadLine();


            //Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string.
            //Guardar cada uno de esos strings en la posición 0 , 1 y 2. Mostrar en pantalla en el orden:
            //primero posición 1, después posición 2 y por último posicion 0.

            //string[] arraystring = new string[3];
            //Console.WriteLine("Dime 3 palabras. ");
            //arraystring[0] = Console.ReadLine();
            //arraystring[1] = Console.ReadLine();
            //arraystring[2] = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine(arraystring[1]);
            //Console.WriteLine(arraystring[2]);
            //Console.WriteLine(arraystring[0]);

            //Console.ReadLine();



            // Crear un array de 10 ints. 
            //Usar un for para asignar los valores de 20 a 11 a las 10 posiciones (en orden descendente).
            //Usar un for para mostrar los 10 valores en pantalla.


            //int sumaNum = 20;
            //int[] numeros = new int[10];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i] = sumaNum);
            //    sumaNum--;
            //}
            //Console.ReadLine();




            //int sumaNum1 = 20;
            //int[] numeros1 = new int[10];
            //for(int i = 0; i < numeros1.Length; i++)
            //{
            //    numeros1[i] = sumaNum1;
            //    sumaNum1--;
            //}
            //for(int i = 0; i< numeros1.Length; i++)
            //{
            //    Console.WriteLine(numeros1[i]);
            //}
            //Console.ReadLine();


            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones.
            //Usar otro for para mostrarlos en pantalla.

            //int[] valors = new int[3];
            //for (int i = 0; i < valors.Length; i++)
            //{
            //    Console.WriteLine("Introduce un valor. ");
            //    valors[i] = Int32.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Los valores introducidos son: ");
            //for (int i = 0; i < valors.Length; i++)
            //{

            //    Console.WriteLine(valors[i]);
            //}
            //Console.ReadLine();


            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones.
            //Mirar los valores del array una vez tenga los 3 valores y mostrar en pantalla el más pequeño.

            //int[] valors2 = new int[3];
            //for(int i = 0; i < valors2.Length; i++)
            //{
            //    Console.WriteLine("Introduce un valor. ");
            //    valors2[i] = Int32.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("El valor más pequeño es " + valors2.Min());
            //Console.ReadLine();


            //Poner los nombres de los meses en un array de 12. 
            //Cuando el usuario introduce un número del 1 al 12, mostrar el nombre de ese mes en pantalla.

            //string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            //int numMes;

            //Console.WriteLine("Introduce un número del 1 al 12. ");
            //numMes = Int32.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine(meses[numMes]);
            //Console.ReadLine();



            //Hacer la media de 10 valores utilizando un array

            //int[] valors3 = { 3, 2, 8, 5, 9, 16, 8, 9, 82, 46 };
            //Console.WriteLine(valors3.Average());
            //Console.ReadLine();


            /**Crear un array de 11 ints. Usar un for para asignar 0 a cada posición.
             * Pedir al usuario que introduzca valores entre 0 y 10.
             * Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array. 
             * Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en pantalla los valores. 
             * Si introduce un número mayor que 10, decir que ese número es incorrecto. 
             * Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene.
             **/

            //int numCeros;
            //int[] ceros = new int[11];
            //for (int i = 0; i < ceros.Length; i++)
            //{
            //    ceros[i] = 0;
            //}


            //do
            //{
            //    Console.WriteLine("introduce un número. ");
            //    numCeros = Int32.Parse(Console.ReadLine());
            //    if (numCeros >= 0 && numCeros <= 10)
            //    {
            //    ceros[numCeros]++;

            //    }
            //    else if (numCeros > 10)
            //    {
            //        Console.WriteLine("Numero equivocado. ");
            //    }
            //}
            //while (numCeros >= 0);

            //for (int i = 0; i < ceros.Length; i++)
            //{
            //    Console.WriteLine(i + "\t" + ceros[i]);
            //}
            //Console.ReadLine();


            //Crear un array de 10 valores. Poner el valor 1 en cada una de la posición.
            //Pedir al usuario que introduzca un número entre 0 y 9. 
            //Cada vez que introduzca un valor entre 0 y 9, 
            //mostrar el valor de esa posición del array, y modificarlo multiplicando por 2.


            //int numCeros;


            //int[] ceros = new int[10];
            //for (int i = 0; i < ceros.Length; i++)
            //{
            //    ceros[i] = 1;
            //}

            //do
            //{
            //    Console.WriteLine("Introduce un número entre el 0 y el 9. ");
            //    numCeros = Int32.Parse(Console.ReadLine());
            //    if (numCeros >= 0 && numCeros <= 9)
            //    {
            //        ceros[numCeros] = numCeros*ceros[numCeros];
            //    }
            //    else if (numCeros>9)
            //    {
            //        Console.WriteLine("Número no válido. ");
            //    }

            //}
            //while (numCeros >= 0);
            //for (int i = 0; i < ceros.Length; i++)
            //{
            //    Console.WriteLine(i + "\t" + ceros[i]);
            //}
            //Console.ReadLine();

            //Programa que lee las edades de 20 alumnos (validado entre 18 y 35), 
            //las almacena en un array y calcula y escribe su media
            //(para probar, se pueden generar aleatoriamente entre 18 y 35)

            //int[] edades = new int[20];



            //for (int i = 0; i < edades.Length; i++)
            //{

            //Random random = new Random();
            //int contEdades = random.Next(18, 35);
            //edades[i] = random.Next(18, 35);


            //}
            //Console.WriteLine(edades.Min());
            //Console.ReadLine();




            //Cargar una tabla de 20 componentes enteros y calcular la suma de los componentes de posición par
            //y  el producto de los componentes de posición impar. Los valores se generarán aleatoriamente entre 1 y 100.


            //int[] edades = new int[20];
            //int pares = 0;
            //int impares = 1;

            //Random contEdades = new Random();

            //for (int i = 0; i < edades.Length; i++)
            //{
            //    edades[i] = contEdades.Next(1, 101);
            //    if (edades[i] % 2 == 0)
            //    {
            //        pares = pares + edades[i];
            //    }
            //    else
            //    {
            //        impares = impares * edades[i];
            //    }
            //    Console.WriteLine(edades[i] + "\t" + (pares) + "\t\t || " + (impares) );

            //}
            //Console.WriteLine();
            //Console.ReadLine();

            


            //Cargar una tabla de 20 elementos donde cada elemento almacenará un valor entre 1 y 9 (genéralos de forma aleatoria) y escribir,
            //además del contenido de la tabla, la cantidad de 1, cantidad de 2, cantidad de 3…, cantidad de 9 almacenados en ella.

            int[] elem = new int[20];
            int[] elemNum = new int[9];
            Random elemRandom = new Random();

            for (int i = 0; i < elem.Length; i++)
            {
                Console.WriteLine(elem[i] = elemRandom.Next(1, 9));
            }
            
            
            Console.ReadLine();

        }
    }
}
