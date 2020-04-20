using System;

namespace Lab4_poo_camila
{
    class Program

    {
        private static long variable;
        private static long eleccion;
        private static int proceso;

        public static void Main(string[] args)
        {
            
            var rnd = new Random();
            Recepcion recepcion1 = new Recepcion();
            Almacenamiento almacenamiento1 = new Almacenamiento();
            Ensamblaje ensamblaje1 = new Ensamblaje();
            Verificacion verificacion1 = new Verificacion();
            Empaque empaque1 = new Empaque();

            //Console.WriteLine("1. Entrar\n 2. Salir");
            //proceso = Convert.ToInt32(Console.ReadLine());

            //while (proceso == 1)
            //{

                recepcion1.Encender();
                almacenamiento1.Encender();
                ensamblaje1.Encender();
                verificacion1.Encender();
                empaque1.Encender();

                Console.WriteLine("1. Automatico\n2. Manual ");
                variable = Convert.ToInt64(Console.ReadLine());

                if (variable == 1)
                {
                    for (int x = 0; x <= 22; x += 1)
                    {

                        if (x >= 6)
                        {
                            Console.WriteLine("Hora: " + x);


                            //recepcion1.piezasRecibidas = rnd.Next(1, 50000);
                            recepcion1.piezas_Almacenamiento(recepcion1);
                            almacenamiento1.PiezasRecibidas = recepcion1.piezas_almacenamiento;
                            almacenamiento1.AlmacenarPiezas(almacenamiento1);
                            ensamblaje1.PiezasAlmacenadas = almacenamiento1.Piezas_Ensamblaje;
                            ensamblaje1.Ensamblar_Piezas(ensamblaje1);
                            verificacion1.PiezasEnsambladas = ensamblaje1.Piezas_Verificacion;
                            verificacion1.Verificacion_Calidad(verificacion1);
                            empaque1.PiezasVerificadas = verificacion1.Piezas_Empaque;
                            empaque1.Empaquetado(empaque1);

                            Console.WriteLine("Revisando maquinas ...");
                            Console.WriteLine("  ");

                            recepcion1.Reiniciar("Recepcion");
                            almacenamiento1.Reiniciar("Almacenamiento");
                            ensamblaje1.Reiniciar("Ensamblaje");
                            verificacion1.Reiniciar("Verificacion");
                            empaque1.Reiniciar("Empaque");
                        }
                    }

                }
                else if (variable == 2)
                {
                    Console.WriteLine("Reiniciar: \n 1.Recepcion \n 2.Almacenamiento \n 3.Ensamblaje \n 4.Verificacion \n 5.Empaque ");
                    eleccion = Convert.ToInt64(Console.ReadLine());
                    if (eleccion == 1)
                    {
                        recepcion1.Reinicio_Manual("Recepcion");
                    }
                    else if (eleccion == 2)
                    {
                        almacenamiento1.Reinicio_Manual("Almacenamiento");
                    }
                    else if (eleccion == 3)
                    {
                        ensamblaje1.Reinicio_Manual("Ensamblaje");
                    }
                    else if (eleccion == 2)
                    {
                        verificacion1.Reinicio_Manual("Verificacion");
                    }
                    else if (eleccion == 2)
                    {
                        empaque1.Reinicio_Manual("Empaque");

                    }

                    //if (proceso == 0)
                    //{
                    //    break;
                    //}

                }

                recepcion1.Apagar();
                almacenamiento1.Apagar();
                ensamblaje1.Apagar();
                verificacion1.Apagar();
                empaque1.Apagar();



            //}
        }
    }
}
