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
                if (empaque.Memoria < 10000)
                {
                    empaque.PiezasEmpaquetadas = empaque.PiezasVerificadas;
                    empaque.Memoria += empaque.PiezasEmpaquetadas;
                    Console.WriteLine(" ");
                    Console.WriteLine(PiezasVerificadas);
                    Console.WriteLine("Piezas empaquetadas: " + PiezasEmpaquetadas);

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
            if (Memoria == 10000)
            {
                EstadoMaquinaEmpaque = "Encendida";
                Memoria = 0;
                Console.WriteLine("Maquina Reiniciada");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
