using System;
namespace Lab4_poo_camila
{
    public class Almacenamiento : Computador_Central
    {
        public int PiezasRecibidas;
        public int PiezasAlmacenadas;
        public int Piezas_Ensamblaje;


        public void AlmacenarPiezas(Almacenamiento almacenamiento)

        {
            if (Estado == "Encendida")
            {
                if (almacenamiento.Memoria < 50000)
                {
                    almacenamiento.PiezasAlmacenadas = almacenamiento.PiezasRecibidas / 3;
                    almacenamiento.PiezasAlmacenadas += almacenamiento.Piezas_Ensamblaje;
                    almacenamiento.Piezas_Ensamblaje = almacenamiento.PiezasAlmacenadas;
                    almacenamiento.Memoria += almacenamiento.PiezasAlmacenadas;
                    
                    Console.WriteLine(" ");
                    Console.WriteLine("Memoria: " + Memoria);
                    Console.WriteLine("Piezas recibidas en almacenamiento: " + PiezasRecibidas);
                    Console.WriteLine("Piezas que se almacenaron: " + PiezasAlmacenadas);
                    Console.WriteLine("Piezas que se van a ensamblaje: " + Piezas_Ensamblaje);

                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Error Almacenamiento");
                   
                }
            }

        


        }
    }
}
