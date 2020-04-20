using System;
namespace Lab4_poo_camila
{
    public class Ensamblaje : Computador_Central
    {
        public int Piezas_Verificacion;
        public int PiezasAlmacenadas;
        public int PiezasEnsambladas;

        public void Ensamblar_Piezas(Ensamblaje ensamblaje)
        {
            if (Estado == "Encendida")
            {
                if (ensamblaje.Memoria < 100000)
                {
                    ensamblaje.PiezasEnsambladas = ensamblaje.PiezasAlmacenadas / 2;
                    ensamblaje.Piezas_Verificacion = ensamblaje.PiezasEnsambladas;
                    ensamblaje.Memoria += ensamblaje.PiezasEnsambladas;
                    ensamblaje.PiezasEnsambladas += ensamblaje.Piezas_Verificacion;

                    Console.WriteLine(" ");
                    Console.WriteLine("Memoria: " + Memoria);
                    Console.WriteLine("Piezas recibidas de almacenamiento: " + PiezasAlmacenadas);
                    Console.WriteLine("Piezas ensambladas: " + PiezasEnsambladas);
                    Console.WriteLine("Piezas que se van a verificacion: " + Piezas_Verificacion);
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Error Ensamblaje");
                   
                }

            }
        
        }

        
    }
}
