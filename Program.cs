using System;
using EjerciciosAplicada.Tarea1;

namespace EjerciciosAplicada
{
    class Program
    {
        
        static void Main(string[] args)

        {
            Console.WriteLine("\nElija una Opcion..\n\n");

            Console.WriteLine("1-Que imprima mi nombre.");
            Console.WriteLine("2-Agregue más mensajes.");
            Console.WriteLine("3-Perimetro poligono regular");
            Console.WriteLine("4-Grados a radianes.");
            Console.WriteLine("5-Convertir la temperatura");
            Console.WriteLine("6-Dolares y Euro.");
            Console.WriteLine("7-Numero par y Impar.");
            Console.WriteLine("8-Dia de la Semana.");
            Console.WriteLine("9-Perimetro y Area de poligono regular.");
            Console.WriteLine("10-Tabla de multiplicar.");
            Console.WriteLine("11-Multiplicar la potencia.");
            Console.WriteLine("12-La edad mayor y edad menor.");
            Console.WriteLine("13-Salir.");

            int op;
                string valor = "";
                valor = Console.ReadLine();
                op = Convert.ToInt32(valor);
                do
                {
                    switch (op)
                    {
                        case 1:
                        Console.WriteLine("Ejercicio 1");
                            Nombre_Mensaje mer = new Nombre_Mensaje();
                            mer.imprimir();
                            break;

                        case 2:
                        Console.WriteLine("Ejercicio 2");
                            Nombre_Mensaje im = new Nombre_Mensaje();
                            im.mostrar();
                        Console.ReadKey();
                            break;

                        case 3:
                            Console.WriteLine("Ejercicio 3");
                            Poligono poli = new Poligono();
                            poli.CarcularPerimetro();
                            break;
                        case 4:
                            Console.WriteLine("Ejercicio 4");
                            Radianes radi = new Radianes();
                            radi.CarcularRadianes();
                            break;
                        case 5:
                            Console.WriteLine("Ejercicio 5");
                            Temperatura tem = new Temperatura();
                            tem.carcularTemperatura();
                            break;
                        case 6:
                            Console.WriteLine("Ejercicio 6");
                            Radianes divisa = new Radianes();
                            divisa.CalcularDivisa();
                            break;
                        case 7:
                            Console.WriteLine("Ejercicio 7");
                            Poligono nu = new Poligono();
                            nu.NumeroPar_Impar();
                            break;
                        case 8:
                            Console.WriteLine("Ejercicio 8");
                            DiaSemana dia = new DiaSemana();
                            dia.Semana();
                            break;
                        case 9:
                            Console.WriteLine("Ejercicio 9");
                            Poligono ap = new Poligono();
                            ap.AreayPerimetro();
                            break;
                        case 10:
                            Console.WriteLine("Ejercicio 10");
                            Poligono tabla = new Poligono();
                            tabla.Tabla();
                            break;
                        case 11:
                            Console.WriteLine("Ejercicio 11");
                            Radianes poten = new Radianes();
                            poten.Potencia();
                            break;
                        case 12:
                            Console.WriteLine("Ejercicio 12");
                            DiaSemana da = new DiaSemana();
                            da.MedirEdad();
                            break;
                        case 13:
                            Console.WriteLine("Acaba de Salir....");
                            Environment.Exit(0);
                            break;

                    }

                } while (op >= 1 && op <= 13);

                Console.ReadKey();

            
        }
    }
}
