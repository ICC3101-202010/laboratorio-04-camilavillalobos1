using System;
namespace Lab4_poo_camila
{
    public class Verificacion : IComputadorCentral
    {
        public int PiezasVerificadas;
        public int PiezasEnsambladas;
        public int Piezas_Empaque;
        string EstadoMaquinaVerificadora;
        int Memoria;


        public void Verificacion_Calidad( Verificacion verificacion)
        {
            if (EstadoMaquinaVerificadora == "Encendida")
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
                    verificacion.Reiniciar();
                    Memoria = 0;
                }
            }
        }

        public void Encender()
        {
            Console.WriteLine("Maquina Verificadora Encendida");
            EstadoMaquinaVerificadora = "Encendida";
        }

        public void Apagar()
        {
            Console.WriteLine("Maquina Verificadora Apagada");
            EstadoMaquinaVerificadora = "Apagada";
        }

        public void Reiniciar()
        {
            if (Memoria == 100000)
            {
                
                EstadoMaquinaVerificadora = "Encendida";
                Memoria = 0;
                Console.WriteLine("Maquina Verificadora Reiniciada");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
