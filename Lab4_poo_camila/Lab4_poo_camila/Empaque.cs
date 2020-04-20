using System;
namespace Lab4_poo_camila
{
    public class Empaque : IComputadorCentral
    {
        public int PiezasVerificadas;
        public int PiezasEmpaquetadas;
        string EstadoMaquinaEmpaque;
        int Memoria;

        public void Empaquetado(Empaque empaque)
        {
            if (EstadoMaquinaEmpaque == "Encendida")
            {
                if (empaque.Memoria < 100000)
                {
                    empaque.PiezasEmpaquetadas = empaque.PiezasVerificadas;
                    empaque.Memoria += empaque.PiezasEmpaquetadas;
                    Console.WriteLine(" ");
                    Console.WriteLine("Memoria: " + Memoria);
                    Console.WriteLine("Piezas recibidas verificadas: " + PiezasVerificadas);
                    Console.WriteLine("Piezas empaquetadas: " + PiezasEmpaquetadas);

                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Error Empaque");
                    empaque.Reiniciar();
                }
            }
        }

        public void Encender()
        {
            Console.WriteLine("Maquina Empaque Encendida");
            EstadoMaquinaEmpaque = "Encendida";
        }

        public void Apagar()
        {
            Console.WriteLine("Maquina Empaque Apagada");
            EstadoMaquinaEmpaque = "Apagada";
        }

        public void Reiniciar()
        {
            if (Memoria == 100000)
            {
                EstadoMaquinaEmpaque = "Encendida";
                Memoria = 0;
                Console.WriteLine("Maquina Empaque Reiniciada");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
