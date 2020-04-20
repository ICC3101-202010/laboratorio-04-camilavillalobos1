using System;
namespace Lab4_poo_camila
{
    public abstract class Computador_Central

    {
        public int Memoria;
        public string Estado;
        public string Nombre;

        public Computador_Central()
        {
        }

        public void Encender()
        {
            Console.WriteLine("Maquina Encendida");
            Estado = "Encendida";
            
        }
        public string Apagar()
        {
            Console.WriteLine("Maquina Apagada");
            Estado = "Apagada";
            return "Maquina Apagada";
        }

        public string Reiniciar()
        {
            if (Estado == "Encendida")
            {
                Memoria = 0;
                //Console.WriteLine("Maquina Reiniciada");
                return "Maquina Reiniciada";
            }
            else
            {
                return "";
            }

        }
    }

    
}
