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
                if (verificacion.Memoria < 10000)
                {
                    verificacion.PiezasEnsambladas = verificacion.PiezasVerificadas;
                    verificacion.Memoria += verificacion.PiezasVerificadas;
                    PiezasVerificadas = Piezas_Empaque;
                    Console.WriteLine(" ");
                    Console.WriteLine(PiezasEnsambladas);
                    Console.WriteLine("Piezas verificadas: " + PiezasVerificadas);
                    Console.WriteLine("Piezas que se van a empaque: " + Piezas_Empaque);
                    Console.WriteLine("Verificada");
                }
                else
                {
                    Console.WriteLine("No se pudo verificar");
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
            if (Memoria == 10000)
            {
                Memoria = 0;
            }
        }
    }
}
