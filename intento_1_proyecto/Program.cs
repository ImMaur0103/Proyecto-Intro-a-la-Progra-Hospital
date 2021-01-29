using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace intento_1_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 20);
            Console.Title = "Farmacia";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Hospital Romulo_Gallegos = new Hospital();
            Hospital Simon_Bolivar = new Hospital();
            Hospital Cruz_Roja = new Hospital();
            Hospital Andres_Bello = new Hospital();
            Hospital Militar = new Hospital();
            Hospital Guatire = new Hospital();
            string[] hospitales = new string[6];
            Usuario Administrador = new Usuario();
            medicamento[] meykos = new medicamento[6];
            meykos[0] = new medicamento();
            meykos[1] = new medicamento();
            meykos[2] = new medicamento();
            meykos[3] = new medicamento();
            meykos[4] = new medicamento();
            meykos[5] = new medicamento();
            Usuario[] usuario = new Usuario[7];
            usuario[0] = new Usuario();
            usuario[1] = new Usuario();
            usuario[2] = new Usuario();
            usuario[3] = new Usuario();
            usuario[4] = new Usuario();
            usuario[5] = new Usuario();
            usuario[6] = new Usuario();
            if (true)
            {
                Administrador.admin = true;
                Administrador.doctor = false;
                Administrador.paciente = false;
                Administrador.usuario = "admin";
                Administrador.contraseña = "12345678";
            }//aqui se creo el usuario administrador, se introdujo dentro del if por estetica de codigo
            if (true)
            {
                for (int j = 0; j < 6; j++)
                {
                    meykos[j].precio = 30.99;
                    meykos[j].stock = 100;
                }
                meykos[0].nombre = "dermacortine";
                meykos[1].nombre = "Ibuprofeno";
                meykos[2].nombre = "Paracetamol";
                meykos[3].nombre = "pepto bismol";
                meykos[4].nombre = "acetaminophen";
                meykos[5].nombre = "aspirina";

                meykos[0].tipo = "Liquido";
                meykos[1].tipo = "Pastillas";
                meykos[2].tipo = "Pastillas";
                meykos[3].tipo = "Liquido";
                meykos[4].tipo = "Pastillas";
                meykos[5].tipo = "Pastillas";
            }//se crean los medicamentos
            if (true)
            {
                Romulo_Gallegos.medicos();
                Simon_Bolivar.medicos();
                Cruz_Roja.medicos();
                Andres_Bello.medicos();
                Militar.medicos();
                Guatire.medicos();
                hospitales[0] = "Romulo gallegos";
                hospitales[1] = "Simon Bolivar";
                hospitales[2] = "Cruz Roja";
                hospitales[3] = "Andres Bello";
                hospitales[4] = "Militar";
                hospitales[5] = "Guatire";
            }//se crean los hospitales
            ConsoleKeyInfo escape;
            int vendidos = 0;
            int iteraciones = 0;
            int intentos_fallidos = 0;
            int usuario_bloqueado = 0;
            int usuarios_c = 0;
            double Ganancias = 0;
            bool usuarios_creados = false;
            string x;
            void Reportes(int u)
            {
                while(true)
                {
                    Romulo_Gallegos.medicos1();
                    Simon_Bolivar.medicos1();
                    Cruz_Roja.medicos1();
                    Andres_Bello.medicos1();
                    Militar.medicos1();
                    Guatire.medicos1();
                    int hospial1 = 0;
                    int hospial2 = 0;
                    int hospial3 = 0;
                    int hospial4 = 0;
                    int hospial5 = 0;
                    int hospial6 = 0;
                    int opcion = 0;
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("1. Por hospital");
                    Console.WriteLine("2. Por especialidad");
                    Console.WriteLine("3. General");
                    Console.WriteLine("4. Salir");
                    try
                    {
                        opcion = Convert.ToInt16(Console.ReadLine());
                    }
                    catch { }
                    while(opcion ==1 )
                    {
                        int opcion1 = 0;
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("hospitales");
                        for (int a = 1; a <= 6; a++)
                        {
                            Console.WriteLine("{0}", a + ". " + hospitales[a - 1]);
                        }
                        Console.WriteLine("si desea salir precione 7");
                        opcion1 = int.Parse(Console.ReadLine());
                        while (opcion1 > 0 && opcion1 < 7)
                        {
                            ConsoleKeyInfo tecla;
                            Console.Clear();
                            Console.Beep();
                            if (opcion1 == 1)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion1 - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Romulo_Gallegos.medicos_especiales[a - 1] + " medicos de " + Romulo_Gallegos.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Romulo_Gallegos.total_medicos + " medicos");
                                Console.Write("En total hay " + Romulo_Gallegos.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Romulo_Gallegos.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion1 == 2)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion1 - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Simon_Bolivar.medicos_especiales[a - 1] + " medicos de " + Simon_Bolivar.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Simon_Bolivar.total_medicos + " medicos");
                                Console.Write("En total hay " + Simon_Bolivar.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Simon_Bolivar.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion1 == 3)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion1 - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Cruz_Roja.medicos_especiales[a - 1] + " medicos de " + Cruz_Roja.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Cruz_Roja.total_medicos + " medicos");
                                Console.Write("En total hay " + Cruz_Roja.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Cruz_Roja.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion1 == 4)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion1 - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Andres_Bello.medicos_especiales[a - 1] + " medicos de " + Andres_Bello.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Andres_Bello.total_medicos + " medicos");
                                Console.Write("En total hay " + Andres_Bello.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Andres_Bello.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion1 == 5)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion1 - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Militar.medicos_especiales[a - 1] + " medicos de " + Militar.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Militar.total_medicos + " medicos");
                                Console.Write("En total hay " + Militar.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Militar.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion1 == 6)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion1 - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Guatire.medicos_especiales[a - 1] + " medicos de " + Guatire.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Guatire.total_medicos + " medicos");
                                Console.Write("En total hay " + Guatire.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Guatire.total_sillaruedas + " silla de ruedas");
                            }
                            Console.WriteLine();
                            Console.WriteLine("si desea salir precione esc");
                            tecla = Console.ReadKey();
                            if (tecla.Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }
                        if (opcion1 == 7)
                        {
                            break;
                        }
                    }
                    while (opcion == 2)
                    {
                        int opcion1 = 0;
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("especialidades ");
                        Console.Write("1. Traumatologia ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[0] + Simon_Bolivar.medicos_especiales[0] + Cruz_Roja.medicos_especiales[0] + Andres_Bello.medicos_especiales[0] + Militar.medicos_especiales[0] + Guatire.medicos_especiales[0]));
                        Console.Write("2. pediatría ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[1] + Simon_Bolivar.medicos_especiales[1] + Cruz_Roja.medicos_especiales[1] + Andres_Bello.medicos_especiales[1] + Militar.medicos_especiales[1] + Guatire.medicos_especiales[1]));
                        Console.Write("3. anestesiología ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[2] + Simon_Bolivar.medicos_especiales[2] + Cruz_Roja.medicos_especiales[2] + Andres_Bello.medicos_especiales[2] + Militar.medicos_especiales[2] + Guatire.medicos_especiales[2]));
                        Console.Write("4. oftalmología ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[3] + Simon_Bolivar.medicos_especiales[0] + Cruz_Roja.medicos_especiales[3] + Andres_Bello.medicos_especiales[3] + Militar.medicos_especiales[3] + Guatire.medicos_especiales[3]));
                        Console.Write("5. ginecología ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[4] + Simon_Bolivar.medicos_especiales[4] + Cruz_Roja.medicos_especiales[4] + Andres_Bello.medicos_especiales[4] + Militar.medicos_especiales[4] + Guatire.medicos_especiales[4]));
                        Console.Write("6. fisioterapia ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[5] + Simon_Bolivar.medicos_especiales[5] + Cruz_Roja.medicos_especiales[5] + Andres_Bello.medicos_especiales[5] + Militar.medicos_especiales[5] + Guatire.medicos_especiales[5]));
                        Console.WriteLine("7. Salir");
                        try
                        {
                            opcion1 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch { }
                        if(opcion1 == 7)
                        {
                            break;
                        }
                        else if(opcion1 == 1)
                        {
                            hospial1 = Romulo_Gallegos.medicos_especiales[0];
                            hospial2 = Simon_Bolivar.medicos_especiales[0];
                            hospial3 = Cruz_Roja.medicos_especiales[0];
                            hospial4 = Andres_Bello.medicos_especiales[0];
                            hospial5 = Militar.medicos_especiales[0];
                            hospial6 = Guatire.medicos_especiales[0];
                            if(hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                            {
                                Console.WriteLine(hospitales[0] + " Con " + hospial1);
                            }
                            else if(hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                            {
                                Console.WriteLine(hospitales[1] + " Con " + hospial2);
                            }
                            else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                            {
                                Console.WriteLine(hospitales[2] + " Con " + hospial3);
                            }
                            else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                            {
                                Console.WriteLine(hospitales[4] + " Con " + hospial5);
                            }
                            else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                            {
                                Console.WriteLine(hospitales[5] + " Con " + hospial6);
                            }
                            else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                            {
                                Console.WriteLine(hospitales[3] + " Con " + hospial4);
                            }
                            Console.ReadLine();
                        }
                        else if (opcion1 == 2)
                        {
                            hospial1 = Romulo_Gallegos.medicos_especiales[1];
                            hospial2 = Simon_Bolivar.medicos_especiales[1];
                            hospial3 = Cruz_Roja.medicos_especiales[1];
                            hospial4 = Andres_Bello.medicos_especiales[1];
                            hospial5 = Militar.medicos_especiales[1];
                            hospial6 = Guatire.medicos_especiales[1];
                            if (hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                            {
                                Console.WriteLine(hospitales[0] + " Con " + hospial1);
                            }
                            else if (hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                            {
                                Console.WriteLine(hospitales[1] + " Con " + hospial2);
                            }
                            else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                            {
                                Console.WriteLine(hospitales[2] + " Con " + hospial3);
                            }
                            else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                            {
                                Console.WriteLine(hospitales[4] + " Con " + hospial5);
                            }
                            else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                            {
                                Console.WriteLine(hospitales[5] + " Con " + hospial6);
                            }
                            else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                            {
                                Console.WriteLine(hospitales[3] + " Con " + hospial4);
                            }
                            Console.ReadLine();
                        }
                        else if (opcion1 == 3)
                        {
                            hospial1 = Romulo_Gallegos.medicos_especiales[2];
                            hospial2 = Simon_Bolivar.medicos_especiales[2];
                            hospial3 = Cruz_Roja.medicos_especiales[2];
                            hospial4 = Andres_Bello.medicos_especiales[2];
                            hospial5 = Militar.medicos_especiales[2];
                            hospial6 = Guatire.medicos_especiales[2];
                            if (hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                            {
                                Console.WriteLine(hospitales[0] + " Con " + hospial1);
                            }
                            else if (hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                            {
                                Console.WriteLine(hospitales[1] + " Con " + hospial2);
                            }
                            else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                            {
                                Console.WriteLine(hospitales[2] + " Con " + hospial3);
                            }
                            else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                            {
                                Console.WriteLine(hospitales[4] + " Con " + hospial5);
                            }
                            else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                            {
                                Console.WriteLine(hospitales[5] + " Con " + hospial6);
                            }
                            else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                            {
                                Console.WriteLine(hospitales[3] + " Con " + hospial4);
                            }
                            Console.ReadLine();
                        }
                        else if (opcion1 == 4)
                        {
                            hospial1 = Romulo_Gallegos.medicos_especiales[3];
                            hospial2 = Simon_Bolivar.medicos_especiales[3];
                            hospial3 = Cruz_Roja.medicos_especiales[3];
                            hospial4 = Andres_Bello.medicos_especiales[3];
                            hospial5 = Militar.medicos_especiales[3];
                            hospial6 = Guatire.medicos_especiales[3];
                            if (hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                            {
                                Console.WriteLine(hospitales[0] + " Con " + hospial1);
                            }
                            else if (hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                            {
                                Console.WriteLine(hospitales[1] + " Con " + hospial2);
                            }
                            else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                            {
                                Console.WriteLine(hospitales[2] + " Con " + hospial3);
                            }
                            else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                            {
                                Console.WriteLine(hospitales[4] + " Con " + hospial5);
                            }
                            else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                            {
                                Console.WriteLine(hospitales[5] + " Con " + hospial6);
                            }
                            else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                            {
                                Console.WriteLine(hospitales[3] + " Con " + hospial4);
                            }
                            Console.ReadLine();
                        }
                        else if (opcion1 == 5)
                        {
                            hospial1 = Romulo_Gallegos.medicos_especiales[4];
                            hospial2 = Simon_Bolivar.medicos_especiales[4];
                            hospial3 = Cruz_Roja.medicos_especiales[4];
                            hospial4 = Andres_Bello.medicos_especiales[4];
                            hospial5 = Militar.medicos_especiales[4];
                            hospial6 = Guatire.medicos_especiales[4];
                            if (hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                            {
                                Console.WriteLine(hospitales[0] + " Con " + hospial1);
                            }
                            else if (hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                            {
                                Console.WriteLine(hospitales[1] + " Con " + hospial2);
                            }
                            else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                            {
                                Console.WriteLine(hospitales[2] + " Con " + hospial3);
                            }
                            else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                            {
                                Console.WriteLine(hospitales[4] + " Con " + hospial5);
                            }
                            else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                            {
                                Console.WriteLine(hospitales[5] + " Con " + hospial6);
                            }
                            else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                            {
                                Console.WriteLine(hospitales[3] + " Con " + hospial4);
                            }
                            Console.ReadLine();
                        }
                        else if (opcion1 == 6)
                        {
                            hospial1 = Romulo_Gallegos.medicos_especiales[5];
                            hospial2 = Simon_Bolivar.medicos_especiales[5];
                            hospial3 = Cruz_Roja.medicos_especiales[5];
                            hospial4 = Andres_Bello.medicos_especiales[5];
                            hospial5 = Militar.medicos_especiales[5];
                            hospial6 = Guatire.medicos_especiales[5];
                            if (hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                            {
                                Console.WriteLine(hospitales[0] + " Con " + hospial1);
                            }
                            else if (hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                            {
                                Console.WriteLine(hospitales[1] + " Con " + hospial2);
                            }
                            else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                            {
                                Console.WriteLine(hospitales[2] + " Con " + hospial3);
                            }
                            else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                            {
                                Console.WriteLine(hospitales[4] + " Con " + hospial5);
                            }
                            else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                            {
                                Console.WriteLine(hospitales[5] + " Con " + hospial6);
                            }
                            else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                            {
                                Console.WriteLine(hospitales[3] + " Con " + hospial4);
                            }
                            Console.ReadLine();
                        }
                    }
                    while(opcion == 3)
                    {
                        int total_medicos = Romulo_Gallegos.total_medicos + Simon_Bolivar.total_medicos + Cruz_Roja.total_medicos + Andres_Bello.total_medicos + Militar.total_medicos + Guatire.total_medicos;
                        int opcion1 = 0;
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("1. total de medicos disponibles " + total_medicos);
                        Console.Write("2. Total en Traumatologia ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[0] + Simon_Bolivar.medicos_especiales[0] + Cruz_Roja.medicos_especiales[0] + Andres_Bello.medicos_especiales[0] + Militar.medicos_especiales[0] + Guatire.medicos_especiales[0]));
                        Console.Write("3. Total en pediatría ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[1] + Simon_Bolivar.medicos_especiales[1] + Cruz_Roja.medicos_especiales[1] + Andres_Bello.medicos_especiales[1] + Militar.medicos_especiales[1] + Guatire.medicos_especiales[1]));
                        Console.Write("4. Total en anestesiología ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[2] + Simon_Bolivar.medicos_especiales[2] + Cruz_Roja.medicos_especiales[2] + Andres_Bello.medicos_especiales[2] + Militar.medicos_especiales[2] + Guatire.medicos_especiales[2]));
                        Console.Write("5. Total en oftalmología ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[3] + Simon_Bolivar.medicos_especiales[0] + Cruz_Roja.medicos_especiales[3] + Andres_Bello.medicos_especiales[3] + Militar.medicos_especiales[3] + Guatire.medicos_especiales[3]));
                        Console.Write("6. Total en ginecología ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[4] + Simon_Bolivar.medicos_especiales[4] + Cruz_Roja.medicos_especiales[4] + Andres_Bello.medicos_especiales[4] + Militar.medicos_especiales[4] + Guatire.medicos_especiales[4]));
                        Console.Write("7. Total en fisioterapia ");
                        Console.WriteLine((Romulo_Gallegos.medicos_especiales[5] + Simon_Bolivar.medicos_especiales[5] + Cruz_Roja.medicos_especiales[5] + Andres_Bello.medicos_especiales[5] + Militar.medicos_especiales[5] + Guatire.medicos_especiales[5]));
                        Console.WriteLine();
                        Console.WriteLine(hospitales[0] + " tiene " + Romulo_Gallegos.total_medicos + " medicos");
                        Console.WriteLine(hospitales[1] + " tiene " + Simon_Bolivar.total_medicos + " medicos");
                        Console.WriteLine(hospitales[2] + " tiene " + Cruz_Roja.total_medicos + " medicos");
                        Console.WriteLine(hospitales[3] + " tiene " + Andres_Bello.total_medicos + " medicos");
                        Console.WriteLine(hospitales[4] + " tiene " + Militar.total_medicos + " medicos");
                        Console.WriteLine(hospitales[5] + " tiene " + Guatire.total_medicos + " medicos");
                        Console.WriteLine();
                        hospial1 = Romulo_Gallegos.total_sillaruedas;
                        hospial2 = Simon_Bolivar.total_sillaruedas;
                        hospial3 = Cruz_Roja.total_sillaruedas;
                        hospial4 = Andres_Bello.total_sillaruedas;
                        hospial5 = Militar.total_sillaruedas;
                        hospial6 = Guatire.total_sillaruedas;
                        if (hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[0] + " tiene mas sillas de ruedas con " + hospial1);
                        }
                        else if (hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[1] + " tiene mas sillas de ruedas con " + hospial2);
                        }
                        else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[2] + " tiene mas sillas de ruedas con " + hospial3);
                        }
                        else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[4] + " tiene mas sillas de ruedas con " + hospial5);
                        }
                        else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                        {
                            Console.WriteLine("El hospital " + hospitales[5] + " tiene mas sillas de ruedas con " + hospial6);
                        }
                        else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[3] + " tiene mas sillas de ruedas con " + hospial4);
                        }
                        Console.WriteLine();
                        hospial1 = Romulo_Gallegos.total_camillas;
                        hospial2 = Simon_Bolivar.total_camillas;
                        hospial3 = Cruz_Roja.total_camillas;
                        hospial4 = Andres_Bello.total_camillas;
                        hospial5 = Militar.total_camillas;
                        hospial6 = Guatire.total_camillas;
                        if (hospial1 >= hospial2 && hospial1 >= hospial3 && hospial1 >= hospial4 && hospial1 >= hospial5 && hospial1 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[0] + " tiene mas camillas con " + hospial1);
                        }
                        else if (hospial2 >= hospial1 && hospial2 >= hospial3 && hospial2 >= hospial4 && hospial2 >= hospial5 && hospial2 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[1] + " tiene mas camillas con " + hospial2);
                        }
                        else if (hospial3 >= hospial2 && hospial3 >= hospial1 && hospial3 >= hospial4 && hospial3 >= hospial5 && hospial3 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[2] + " tiene mas camillas con " + hospial3);
                        }
                        else if (hospial5 >= hospial1 && hospial5 >= hospial3 && hospial5 >= hospial4 && hospial5 >= hospial2 && hospial5 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[4] + " tiene mas camillas con " + hospial5);
                        }
                        else if (hospial6 >= hospial2 && hospial6 >= hospial1 && hospial6 >= hospial4 && hospial6 >= hospial5 && hospial6 >= hospial3)
                        {
                            Console.WriteLine("El hospital " + hospitales[5] + " tiene mas camillas con " + hospial6);
                        }
                        else if (hospial4 >= hospial2 && hospial4 >= hospial1 && hospial4 >= hospial3 && hospial4 >= hospial5 && hospial4 >= hospial6)
                        {
                            Console.WriteLine("El hospital " + hospitales[3] + " tiene mas camillas con " + hospial4);
                        }
                        if(usuario[u].doctor)
                        {
                            Console.WriteLine();
                            Console.WriteLine("total de ventas " + vendidos + " productos");
                            Console.WriteLine("Ganancias: " + Ganancias);
                        }
                        Console.WriteLine("8. Salir");
                        try
                        {
                            opcion1  = Convert.ToInt16(Console.ReadLine());
                        }
                        catch { }
                        if (opcion1 == 8)
                        {
                            break;
                        }
                    }
                    if(opcion == 4)
                    {
                        break;
                    }
                }
            }
            while (true)
            {
                Console.Clear();
                if(iteraciones > 0)
                {
                    Console.WriteLine("Si desea cerrar el programa precione escape");
                    escape = Console.ReadKey();
                    if (escape.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    Console.Clear();
                }
                Console.WriteLine(DateTime.Now.ToString());
                Console.WriteLine("Log-In");
                Console.Beep();
                Console.Write("Usuario: ");
                string usua = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Contraseña: ");
                string contra = Console.ReadLine();
                while ((Administrador.usuario == usua) && (Administrador.contraseña == contra))
                {
                    int administrador = 0;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("Bienvenido administrador");
                    Console.WriteLine("1. Crear usuario");
                    if (usuarios_creados)
                    {
                        Console.WriteLine("2. Editar usuarios");
                        Console.WriteLine("3. Modificar farmacia");
                        Console.WriteLine("4. Ver farmacia");
                        Console.WriteLine("5. Ver hospitales");
                        Console.WriteLine("6. Log-out");
                    }
                    else
                    {
                        Console.WriteLine("2. Modificar farmacia");
                        Console.WriteLine("3. Ver farmacia");
                        Console.WriteLine("4. Ver hospitales");
                        Console.WriteLine("5. Log-out");
                    }
                    try
                    {
                        administrador = Convert.ToInt16(Console.ReadLine());
                    }
                    catch
                    { }
                    if ((administrador == 5 && usuarios_creados == false) || (administrador == 6 && usuarios_creados))
                    {
                        break;
                    }
                    if (administrador == 1)
                    {
                        Console.Clear();
                        Console.Beep();
                        Console.Write("Ingrese nombre: ");
                        usuario[usuarios_c].nombre = Console.ReadLine();
                        Console.Write("Ingrese apellido: ");
                        usuario[usuarios_c].apellido = Console.ReadLine();
                        Console.Write("Ingrese usuario: ");
                        usuario[usuarios_c].usuario = Console.ReadLine();
                        int cont = -1;
                        do
                        {
                            cont++;
                            if (cont > 0)
                            {
                                Console.WriteLine("Las contraseñas no coinsiden");
                            }
                            Console.Write("Ingrese contraseña: ");
                            contra = Console.ReadLine();

                            Console.Write("Confirme la contraseña: ");
                            x = Console.ReadLine();
                            if (contra == x)
                            {
                                usuario[usuarios_c].contraseña = contra;
                            }
                        }
                        while (contra != x);
                        Console.Write("Ingrese rol, medico o paciente: ");
                        x = Console.ReadLine();
                        if ((x == "medico") || (x == "Medico") || (x == "med") || (x == "doctor") || (x == "Doctor") || (x == "doc"))
                        {
                            usuario[usuarios_c].doctor = true;
                            usuario[usuarios_c].paciente = false;
                        }
                        else if ((x == "paciente") || (x == "Paciente") || (x == "pac") || (x == "Cliente") || (x == "cliente"))
                        {
                            usuario[usuarios_c].doctor = false;
                            usuario[usuarios_c].paciente = true;
                        }
                        if (usuario[usuarios_c].paciente)
                        {
                            string respuesta;
                            Console.WriteLine("Cuenta con un seguro medico?");
                            Console.Write("Si/No ");
                            respuesta = Console.ReadLine();
                            if(respuesta == "si" || respuesta == "s")
                            {
                                usuario[usuarios_c].Seguro = true;
                            }
                            if (respuesta == "no" || respuesta == "n")
                            {
                                usuario[usuarios_c].Seguro = false;
                            }
                        }
                        usuarios_c++;
                        usuarios_creados = true;
                        contra = Administrador.contraseña;
                    }
                    while (administrador == 2 && usuarios_creados)
                    {
                        Console.Clear();
                        Console.Beep();
                        int opcion = 0;
                        for (int a = 1; a <= 7; a++)
                        {
                            if (usuario[a - 1].usuario != null)
                            {
                                Console.Write(a + ". " + usuario[a - 1].usuario);
                                if (!usuario[a - 1].bloqueado)
                                {
                                    Console.WriteLine(" Desbloqueado");
                                }
                                else
                                {
                                    Console.WriteLine(" Bloqueado");
                                }
                            }
                        }
                        Console.WriteLine("8. regresar");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        while (opcion > 0 && opcion < 8)
                        {
                            Console.Clear();
                            int opcion1 = 0;
                            bool entro = false;
                            Console.WriteLine("1. Cambiar contraseña");
                            Console.WriteLine("2. Bloquear/desbloquear");
                            opcion1 = Convert.ToInt16(Console.ReadLine());
                            while (opcion1 == 1)
                            {
                                Console.Clear();
                                int cont = 0;
                                do
                                {
                                    if (cont > 0)
                                    {
                                        Console.WriteLine("Las contraseñas no coinsiden");
                                    }
                                    Console.Write("Ingrese contraseña: ");
                                    contra = Console.ReadLine();

                                    Console.Write("Confirme la contraseña: ");
                                    x = Console.ReadLine();
                                    if (contra == x)
                                    {
                                        usuario[opcion - 1].contraseña = contra;
                                    }
                                    cont++;
                                }
                                while (contra != x);
                                contra = Administrador.contraseña;
                                opcion1 = 0;
                                entro = true;
                            }
                            while (opcion1 == 2)
                            {
                                int opcion2 = 0;
                                Console.WriteLine("1. Bloquear");
                                Console.WriteLine("2. Desbloquear");
                                opcion2 = Convert.ToInt16(Console.ReadLine());
                                if (opcion2 == 1)
                                {
                                    usuario[opcion - 1].bloqueado = true;
                                    opcion1 = 0;
                                }
                                else if (opcion2 == 2)
                                {
                                    usuario[opcion - 1].bloqueado = false;
                                    opcion1 = 0;
                                }
                                entro = true;
                            }
                            if (entro)
                            {
                                opcion = 0;
                            }
                        }
                        if (opcion == 8)
                        {
                            administrador = 0;
                        }
                    }
                    while ((administrador == 2 && usuarios_creados == false) || (administrador == 3 && usuarios_creados))
                    {
                        int opcion = 0;
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("Medicamentos:");
                        for (int a = 0; a < 6; a++)
                        {
                            if (meykos[a].nombre != null)
                            {
                                Console.WriteLine((a + 1) + ". " + meykos[a].nombre);
                            }
                        }
                        Console.WriteLine("7. Regresar");
                        opcion = Convert.ToInt16(Console.ReadLine());
                        while(opcion > 0 && opcion < 7)
                        {
                            int opcion_1 = 0;
                            Console.WriteLine("Que desea cambiar?");
                            Console.WriteLine("1. precio");
                            Console.WriteLine("2. Inventario");
                            opcion_1 = Convert.ToInt16(Console.ReadLine());
                            if(opcion_1 != 1 && opcion_1 != 2)
                            {
                                continue;
                            }
                            if(opcion_1 == 1)
                            {
                                Console.Write("ingrese precio nuevo: ");
                                try
                                {
                                    meykos[opcion - 1].precio = Convert.ToDouble(Console.ReadLine());
                                }
                                catch { }
                                break;
                            }
                            else if(opcion_1 == 2)
                            {
                                Console.Write("ingrese la cantidad que hay en el invemtario: ");
                                meykos[opcion - 1].stock = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                        }
                        if (opcion == 7)
                        {
                            break;
                        }
                    }
                    while ((administrador == 3 && usuarios_creados == false) || (administrador == 4 && usuarios_creados))
                    {
                        ConsoleKeyInfo tecla;
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("Bienvenido a meykos");
                        Console.WriteLine();
                        for (int a = 1; a <= 6; a++)
                        {
                            Console.Write("{0}",a + ". " + meykos[a - 1].nombre);
                            Console.WriteLine(" " + meykos[a - 1].precio + "Q " + meykos[a-1].stock + " disponibles");
                            Console.WriteLine();
                        }
                        Console.WriteLine("si desea salir precione esc");
                        tecla = Console.ReadKey();
                        if (tecla.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    while ((administrador == 4 && usuarios_creados == false) || (administrador == 5 && usuarios_creados))
                    {
                        int opcion = 0;
                        Console.Clear();
                        Console.Beep();
                        Console.WriteLine("hospitales");
                        for (int a = 1; a <= 6; a++)
                        {
                            Console.WriteLine("{0}", a + ". " + hospitales[a -1]);
                        }
                        Console.WriteLine("si desea salir precione 7");
                        opcion = int.Parse(Console.ReadLine());
                        while (opcion > 0 && opcion < 7)
                        {
                            ConsoleKeyInfo tecla;
                            Console.Clear();
                            Console.Beep();
                            if (opcion == 1)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Romulo_Gallegos.medicos_especiales[a - 1] + " medicos de " + Romulo_Gallegos.especialidad[a -1]);
                                }
                                Console.WriteLine("En total hay: " + Romulo_Gallegos.total_medicos + " medicos");
                                Console.Write("En total hay " + Romulo_Gallegos.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Romulo_Gallegos.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion == 2)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Simon_Bolivar.medicos_especiales[a - 1] + " medicos de " + Simon_Bolivar.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Simon_Bolivar.total_medicos + " medicos");
                                Console.Write("En total hay " + Simon_Bolivar.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Simon_Bolivar.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion == 3)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Cruz_Roja.medicos_especiales[a - 1] + " medicos de " + Cruz_Roja.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Cruz_Roja.total_medicos + " medicos");
                                Console.Write("En total hay " + Cruz_Roja.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Cruz_Roja.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion == 4)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Andres_Bello.medicos_especiales[a - 1] + " medicos de " + Andres_Bello.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Andres_Bello.total_medicos + " medicos");
                                Console.Write("En total hay " + Andres_Bello.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Andres_Bello.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion == 5)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Militar.medicos_especiales[a - 1] + " medicos de " + Militar.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Militar.total_medicos + " medicos");
                                Console.Write("En total hay " + Militar.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Militar.total_sillaruedas + " silla de ruedas");
                            }
                            else if (opcion == 6)
                            {
                                Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                for (int a = 1; a <= 6; a++)
                                {
                                    Console.WriteLine("Hay " + Guatire.medicos_especiales[a - 1] + " medicos de " + Guatire.especialidad[a - 1]);
                                }
                                Console.WriteLine("En total hay: " + Guatire.total_medicos + " medicos");
                                Console.Write("En total hay " + Guatire.total_camillas + " de camillas");
                                Console.Write(" y un total de " + Guatire.total_sillaruedas + " silla de ruedas");
                            }
                            Console.WriteLine();
                            Console.WriteLine("si desea salir precione esc");
                            tecla = Console.ReadKey();
                            if (tecla.Key == ConsoleKey.Escape)
                            {
                                break;
                            }
                        }
                        if (opcion == 7)
                        {
                            break;
                        }
                    }
                }
                for (int a = 0; a <= 6; a++)
                {
                    if ((usuario[a].usuario == usua) && (usuario[a].contraseña == contra))
                    {
                        while(usuario[a].paciente && !usuario[a].bloqueado)
                        {
                            int productos = 0;
                            int paciente = 0;
                            int compras1 = 0, compras2 = 0;
                            string compra1 = "", compra2 = "";
                            double precio = 0;
                            Console.Clear();
                            Console.Beep();
                            Console.WriteLine("Bienvenido " + usuario[a].nombre + usuario[a].apellido);
                            Console.WriteLine("1. Comprar en farmacia");
                            Console.WriteLine("2. Reportes de hospital");
                            Console.WriteLine("3. Si desea salir ingrese 3");
                            paciente = int.Parse(Console.ReadLine());
                            if (paciente == 3)
                            {
                                break;
                            }
                            while(paciente == 1)
                            {
                                int[] invalido = new int[6];
                                double descuento = 0;
                                int opcion = 0;
                                Console.Clear();
                                Console.Beep();
                                Console.WriteLine("Bienvenido a meykos");
                                Console.WriteLine();
                                for (int i = 1; i <= 6; i++)
                                {
                                    if(meykos[i - 1].stock == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        switch (i)
                                        {
                                            case 1:
                                                {
                                                    invalido[i - 1] = i;
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    invalido[i - 1] = i;
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    invalido[i - 1] = i;
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    invalido[i - 1] = i;
                                                    break;
                                                }
                                            case 5:
                                                {
                                                    invalido[i - 1] = i;
                                                    break;
                                                }
                                            case 6:
                                                {
                                                    invalido[i - 1] = i;
                                                    break;
                                                }
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.Write("{0}", i + ". " + meykos[i - 1].nombre);
                                    Console.WriteLine(" " + meykos[i - 1].precio + "Q");
                                    Console.WriteLine();
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("7. No comprar");
                                Console.WriteLine();
                                Console.WriteLine("8. Comprar");
                                Console.WriteLine();
                                Console.Write("Ingrese el numero del medicamento que desea: ");
                                try
                                {
                                    opcion = int.Parse(Console.ReadLine());
                                }
                                catch { }
                                for(int i = 0; i < 6; i++)
                                {
                                    if (invalido[i] == opcion)
                                    {
                                        Console.WriteLine("ese medicamento se encuentra agotado");
                                        Console.ReadLine();
                                        opcion = 0;
                                        break;
                                    }
                                }
                                if(opcion == 7)
                                {
                                    break;
                                }
                                else if(opcion == 0)
                                {
                                    continue;
                                }
                                if(opcion > 0 && opcion < 7)
                                {
                                    productos++;
                                    vendidos++;
                                    meykos[opcion - 1].stock--;
                                    precio = precio + meykos[opcion - 1].precio;
                                    if(productos == 1)
                                    {
                                        compra1 = meykos[opcion - 1].nombre;
                                        compras1 = opcion - 1;
                                    }
                                    else
                                    {
                                        compra2 = meykos[opcion - 1].nombre;
                                        compras2 = opcion - 1;
                                    }
                                }
                                if ((opcion == 8 && compra1 != "") || productos == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine(DateTime.Now.ToString());
                                    Console.WriteLine(usuario[a].nombre + " " + usuario[a].apellido);
                                    Console.WriteLine(compra1 + " en presentacion de " + meykos[compras1].tipo + " = " + meykos[compras1].precio + "Q");
                                    if (compra2 != "")
                                    {
                                        Console.WriteLine(compra2 + " en presentacion de " + meykos[compras2].tipo + " = " + meykos[compras2].precio + "Q");
                                    }
                                    if (usuario[a].Seguro)
                                    {
                                        descuento = precio * 0.25;
                                        Console.WriteLine("Precio " + precio + "Q");
                                        Console.WriteLine("descuento " + descuento + "Q");
                                        Console.WriteLine("total " + (precio - descuento) + "Q");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Total " + precio + "Q");
                                    }
                                    Console.ReadLine();
                                    Ganancias = Ganancias + precio;
                                    break;
                                }
                            }
                            if(paciente == 2)
                            {
                                Reportes(a);
                            }
                        }
                        while (usuario[a].doctor && !usuario[a].bloqueado)
                        {
                            int doctor = 0;
                            Console.Clear();
                            Console.Beep();
                            Console.WriteLine("Bienvenido " + "doctor " + usuario[a].nombre + usuario[a].apellido);
                            Console.WriteLine("1. Reportes de hospital");
                            Console.WriteLine("2. Modificar hospital");
                            Console.WriteLine("3. Si desea salir ingrese 3");
                            try
                            {
                                doctor = int.Parse(Console.ReadLine());
                            }
                            catch { }
                            if (doctor == 1)
                            {
                                Reportes(a);
                            }
                            else if(doctor == 3)
                            {
                                break;
                            }
                            while(doctor == 2)
                            {
                                int opcion = 0;
                                Console.Clear();
                                Console.Beep();
                                Console.WriteLine("hospitales");
                                for (int i = 1; i <= 6; i++)
                                {
                                    Console.WriteLine("{0}", i + ". " + hospitales[i - 1]);
                                }
                                Console.WriteLine("si desea salir precione 7");
                                opcion = int.Parse(Console.ReadLine());
                                while (opcion > 0 && opcion < 7)
                                {
                                    ConsoleKeyInfo tecla;
                                    Console.Clear();
                                    Console.Beep();
                                    if (opcion == 1)
                                    {
                                        Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                        for (int i = 1; i <= 6; i++)
                                        {
                                            Console.Write("Medicos de " + Romulo_Gallegos.especialidad[i - 1] + ":");
                                            Romulo_Gallegos.medicos_especiales[i - 1] = Convert.ToInt16(Console.ReadLine());
                                            Console.WriteLine();
                                        }
                                        Console.Write("Camillas: ");
                                        Romulo_Gallegos.total_camillas = Convert.ToInt16(Console.ReadLine());
                                        Console.Write("Sillas de ruedas: ");
                                        Romulo_Gallegos.total_sillaruedas = Convert.ToInt16(Console.ReadLine());
                                    }
                                    else if (opcion == 2)
                                    {
                                        Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                        for (int i = 1; i <= 6; i++)
                                        {
                                            Console.Write("Medicos de " + Simon_Bolivar.especialidad[i - 1] + ":");
                                            Simon_Bolivar.medicos_especiales[i - 1] = Convert.ToInt16(Console.ReadLine());
                                            Console.WriteLine();
                                        }
                                        Console.Write("Camillas: ");
                                        Simon_Bolivar.total_camillas = Convert.ToInt16(Console.ReadLine());
                                        Console.WriteLine();
                                        Console.Write("Sillas de ruedas: ");
                                        Simon_Bolivar.total_sillaruedas = Convert.ToInt16(Console.ReadLine());
                                    }
                                    else if (opcion == 3)
                                    {
                                        Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                        for (int i = 1; i <= 6; i++)
                                        {
                                            Console.Write("Medicos de " + Cruz_Roja.especialidad[i - 1] + ":");
                                            Cruz_Roja.medicos_especiales[i - 1] = Convert.ToInt16(Console.ReadLine());
                                            Console.WriteLine();
                                        }
                                        Console.Write("Camillas: ");
                                        Cruz_Roja.total_camillas = Convert.ToInt16(Console.ReadLine());
                                        Console.WriteLine();
                                        Console.Write("Sillas de ruedas: ");
                                        Cruz_Roja.total_sillaruedas = Convert.ToInt16(Console.ReadLine());
                                    }
                                    else if (opcion == 4)
                                    {
                                        Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                        for (int i = 1; i <= 6; i++)
                                        {
                                            Console.Write("Medicos de " + Andres_Bello.especialidad[i - 1] + ":");
                                            Andres_Bello.medicos_especiales[i - 1] = Convert.ToInt16(Console.ReadLine());
                                            Console.WriteLine();
                                        }
                                        Console.Write("Camillas: ");
                                        Andres_Bello.total_camillas = Convert.ToInt16(Console.ReadLine());
                                        Console.WriteLine();
                                        Console.Write("Sillas de ruedas: ");
                                        Andres_Bello.total_sillaruedas = Convert.ToInt16(Console.ReadLine());
                                    }
                                    else if (opcion == 5)
                                    {
                                        Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                        for (int i = 1; i <= 6; i++)
                                        {
                                            Console.Write("Medicos de " + Militar.especialidad[i - 1] + ":");
                                            Militar.medicos_especiales[i - 1] = Convert.ToInt16(Console.ReadLine());
                                            Console.WriteLine();
                                        }
                                        Console.Write("Camillas: ");
                                        Militar.total_camillas = Convert.ToInt16(Console.ReadLine());
                                        Console.WriteLine();
                                        Console.Write("Sillas de ruedas: ");
                                        Militar.total_sillaruedas = Convert.ToInt16(Console.ReadLine());
                                    }
                                    else if (opcion == 6)
                                    {
                                        Console.WriteLine("Hospital " + hospitales[opcion - 1]);
                                        for (int i = 1; i <= 6; i++)
                                        {
                                            Console.Write("Medicos de " + Guatire.especialidad[i - 1] + ":");
                                            Guatire.medicos_especiales[i - 1] = Convert.ToInt16(Console.ReadLine());
                                            Console.WriteLine();
                                        }
                                        Console.Write("Camillas: ");
                                        Guatire.total_camillas = Convert.ToInt16(Console.ReadLine());
                                        Console.WriteLine();
                                        Console.Write("Sillas de ruedas: ");
                                        Guatire.total_sillaruedas = Convert.ToInt16(Console.ReadLine());
                                    }
                                    Romulo_Gallegos.medicos1();
                                    Simon_Bolivar.medicos1();
                                    Cruz_Roja.medicos1();
                                    Andres_Bello.medicos1();
                                    Militar.medicos1();
                                    Guatire.medicos1();
                                    Console.WriteLine();
                                    Console.WriteLine("si desea salir precione esc");
                                    tecla = Console.ReadKey();
                                    if (tecla.Key == ConsoleKey.Escape)
                                    {
                                        break;
                                    }
                                }
                                if (opcion == 7)
                                {
                                    break;
                                }
                            }
                        }
                        intentos_fallidos = 0;
                    }
                }
                for (int a = 0; a <= 6; a++)
                {
                    if ((usuario[a].usuario == usua) && (usuario[a].contraseña != contra) && (usuario[a].usuario == usuario[usuario_bloqueado].usuario))
                    {
                        intentos_fallidos++;
                        usuario_bloqueado = a;
                        a = 7;
                        break;
                    }
                    else if ((usuario[a].usuario == usua) && (usuario[a].contraseña != contra))
                    {
                        intentos_fallidos = 0;
                        intentos_fallidos++;
                        usuario_bloqueado = a;
                        a = 7;
                        break;
                    }
                }
                if (intentos_fallidos == 3)
                {
                    usuario[usuario_bloqueado].bloqueado = true;
                    intentos_fallidos = 0;
                }
                iteraciones++;
            }

        }
    }
}