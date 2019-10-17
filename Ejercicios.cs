using System;

namespace AymeMacias3C
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Ejercicio10();
        }
        public void Ejercicio1()
        {
            int cantidad, número, mayor = 0;
            Console.Write("Cantidad de número: ");
            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese número: ");
                número = int.Parse(Console.ReadLine());
                if (mayor < número)
                {
                    mayor = número;
                }
            }
            Console.WriteLine("Número mayor es: " + mayor);
            Console.ReadKey();
        }




        public void Ejercicio2()
        {
            int tamaño;
            Console.Write("Ingrese tamaño del cuadro: ");
            tamaño = int.Parse(Console.ReadLine()); //linea superior
            for (int i = 1; i <= tamaño; i++)
            { Console.Write(" *"); }
            Console.WriteLine(" "); //linea central
            for (int i1 = 2; i1 < tamaño; i1++)
            {
                Console.Write(" *");
                for (int i2 = 2; i2 < tamaño; i2++)
                { Console.Write("  "); }
                Console.WriteLine(" *");
            } //linea iinferior 
            for (int i3 = 1; i3 <= tamaño; i3++)
            {
                Console.Write(" *");
            }
            Console.ReadKey();
        }




        public void Ejercicio3()
        {
            double cant, precio, total = 0;
            do
            {
                Console.Write("Introduzca la cantidad vendida: ");
                cant = int.Parse(Console.ReadLine());
                if (cant != 0)
                {
                    Console.Write("Introduzca el precio: ");
                    precio = double.Parse(Console.ReadLine());
                    precio = cant * precio;
                    total = total + precio;
                }
            } while (cant != 0);
            Console.WriteLine("El total de la factura es:" + total);
            Console.ReadKey();
        }




        public void Ejercicio4()
        {
            int H, S, A;
            String N;
            do {
                Console.Write("Introduzca el número de horas");
                H = int.Parse(Console.ReadLine());
                if (H<35)
                {
                    S = H * 15;
                }
                else
                {
                    A = H - 35;
                    S = (35 * 15) + (A * 22);
                }
                Console.WriteLine("El salario semanal es: " + S);
                Console.WriteLine("¿Quiere calcular otro salario?:");
                N = Console.ReadLine();
            } while (N != "no");
            Console.ReadKey();
        }




        public void Ejercicio5()
        {
            int num;
            Console.WriteLine("Ingrese tamaño de la pirámide: ");
            num = int.Parse(Console.ReadLine());
            for (int c = 0; c <= num; c++)
            {
                for (int c1 = num - c; c1 > 0; c1--)
                {
                    Console.Write(" ");
                }
                for (int c2 = 0; c2 < c; c2++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
                Console.ReadKey();
            }
        }




        public void Ejercicio6()
        {
            int num;
            Console.WriteLine("Ingrese tamaño del rombo: ");
            num = int.Parse(Console.ReadLine());
            for (int c = 0; c <= num; c++)
            {
                for (int c1 = num - c; c1 > 0; c1--)
                {
                    Console.Write(" ");
                }
                for (int c2 = 0; c2 < c; c2++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" ");
            }
            for (int c = 0; c <= num; c++)
            {
                for (int c1 = 0; c1 < c; c1++)
                {
                    Console.Write(" ");
                }
                for (int c2 = num - c; c2 > 0; c2--) 
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
                Console.ReadKey();
            }
            }
        
        



        public void Ejercicio7()
        {
            int num1=0, num2 = 101;
            do
            {
                num1 = num1 + 1;
                num2 = num2 - 1;
                    Console.WriteLine(+num1 + " " + num2);
            } while (num1 < 100);
            Console.ReadKey();
        }




        public void Ejercicio8()
        {
            int num, num1 = 0, num2 = 0;
            Console.Write("Escriba el número entero: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                num1 = num1 + 2;
                num2 = num2 + 3;
                Console.WriteLine(i + "   " + num1 + "   " + num2);
                Console.ReadKey();
            }
        }




        public void Ejercicio9()
        {
            int valor = 1, num, resul = 0;
            Console.Write("Ingrese valor de tabla: ");
            valor = int.Parse(Console.ReadLine());
            for (num = 1; num <= 15; num++)
            {
                resul = valor * num;
                Console.WriteLine(+valor + "x" + num + "=" + resul);
                Console.ReadKey();
            }
        }




        public void Ejercicio10()
        {
            int num;
            Boolean condición = true;
            while (condición)
            {
                Console.WriteLine("Seleccione una opción del menú: ");
                Console.WriteLine("1° Salir \n");
                Console.WriteLine("2° Sumatorio \n");
                Console.WriteLine("3°Factorial \n");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        condición = false;
                        break;
                    case 2:
                        new Program().Sumar();
                        break;
                    case 3:
                        new Program().Factorial();
                        break;
                }
            }
        }
        public void Sumar()
        {
            int num, S = 0;
            Console.Write("Ingrese número: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int c = 1; c <= num; c++)
                {
                    S = S + c;
                }
                Console.WriteLine("El total del sumatorio es: " + S);
                Console.ReadKey();
            }
        }
        public void Factorial()
        {
            int num, facto = 1;
            Console.WriteLine("Ingrese número para sacar factorial");
            num = int.Parse(Console.ReadLine());
            for (int c = 1; c <= num; c++)
            {
                facto = facto * c;
            }
            Console.WriteLine("El factorial del número es: " + facto);
            Console.ReadKey();
        }
    }
}


