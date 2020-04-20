using System;
namespace Lab4_poo_camila
{
    public abstract class Computador_Central

    {
        public int Memoria;
        public string Estado;
        public string Nombre;
        private int reinicio;

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

        public void Reiniciar(string maquina)
        {
            if (Estado == "Encendida" && Memoria == 100000)
            {
                Memoria = 0;
                //Console.WriteLine("Maquina Reiniciada");
                Console.WriteLine("Maquina " + maquina +" Reiniciada"); 
            }
            else
            {
                Console.WriteLine("  "); 
            }

        }

        public void Reinicio_Manual(string maquina)
        {

            Memoria = 0;
            Console.WriteLine("Maquina " + maquina + " Reiniciada");

        }
    }

    
}
