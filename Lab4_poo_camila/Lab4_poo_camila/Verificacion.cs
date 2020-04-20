using System;
namespace Lab4_poo_camila
{
    public class Verificacion : Computador_Central
    {
        public int PiezasVerificadas;
        public int PiezasEnsambladas;
        public int Piezas_Empaque;

        public void Verificacion_Calidad( Verificacion verificacion)
        {
            if (Estado == "Encendida")
            {
                if (verificacion.Memoria < 100000)
                {
                    verificacion.PiezasVerificadas = verificacion.PiezasEnsambladas;
                    verificacion.Piezas_Empaque = verificacion.PiezasVerificadas;
                    verificacion.Memoria += verificacion.PiezasVerificadas;
                    verificacion.PiezasVerificadas += verificacion.Piezas_Empaque;
                    


                    Console.WriteLine(" ");
                    Console.WriteLine("Memoria: " + Memoria);
                    Console.WriteLine("Piezas recibidas de ensamblaje: " + PiezasEnsambladas);
                    Console.WriteLine("Piezas verificadas: " + PiezasVerificadas);
                    Console.WriteLine("Piezas que se van a empaque: " + Piezas_Empaque);
                    Console.WriteLine("Verificada");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("No se pudo verificar");
                    Memoria = 0;
                }
            }
        

 
        }
    }
}
