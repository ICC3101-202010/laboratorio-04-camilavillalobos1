using System;
namespace Lab4_poo_camila
{
    public class Recepcion : Computador_Central
    {
        public const int piezasRecibidas = 50000;
        public int piezas_almacenamiento;

        public void piezas_Almacenamiento(Recepcion recepcion)
        {
            
            if (Estado == "Encendida")
            {
                if (recepcion.Memoria < 100000)
                {
                    int piezasRecibidas = 50000;
                    recepcion.piezas_almacenamiento = 50000;
                    piezasRecibidas -= recepcion.piezas_almacenamiento;
                    recepcion.Memoria += recepcion.piezas_almacenamiento;
                    Console.WriteLine(" ");
                    Console.WriteLine("Memoria: " + Memoria);
                    Console.WriteLine("Piezas recibidas: " + piezasRecibidas);
                    Console.WriteLine("Piezas que se van al almacenamiento: " + piezas_almacenamiento);
                }

                else
                {
                    Console.WriteLine("Error Recepcion");
                    
                }

            }
            else
            {
                Console.WriteLine(" ");

                Console.WriteLine("No funciona");
            }

        }
    }
}
