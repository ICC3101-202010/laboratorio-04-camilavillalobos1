using System;
namespace Lab4_poo_camila
{
    public class Ensamblaje : IComputadorCentral
    {
        public int Piezas_Verificacion;
        public int PiezasAlmacenadas;
        public int PiezasEnsambladas;
        string EstadoMaquinaEnsamblaje;
        int Memoria;


        public void Ensamblar_Piezas(Ensamblaje ensamblaje)
        {
            if (EstadoMaquinaEnsamblaje == "Encendida")
            {
                if (ensamblaje.Memoria < 25000)
                {
                    ensamblaje.PiezasEnsambladas = ensamblaje.PiezasAlmacenadas / 2;
                    ensamblaje.Piezas_Verificacion = ensamblaje.PiezasEnsambladas;
                    ensamblaje.Memoria += ensamblaje.PiezasEnsambladas;
                    ensamblaje.PiezasEnsambladas += ensamblaje.Piezas_Verificacion;

                    Console.WriteLine(" ");
                    Console.WriteLine(PiezasAlmacenadas);
                    Console.WriteLine("Piezas ensambladas: " + PiezasEnsambladas);
                    Console.WriteLine("Piezas que se van a verificacion: " + Piezas_Verificacion);
                }

            }
        }
        public void Encender()
        {
            Console.WriteLine("Maquina Ensamblaje Encendida");
            EstadoMaquinaEnsamblaje = "Encendida";
            Memoria = 0;
        }

        public void Apagar()
        {
            Console.WriteLine("Maquina Ensamblaje Apagada");
            EstadoMaquinaEnsamblaje = "Apagada";

        }

        public void Reiniciar()
        {
            if (Memoria == 25000)
            {
                Memoria = 0;
            }
        }
    }
}
