using System;
namespace Lab4_poo_camila
{
    public class Empaque : Computador_Central 
    {
        public int PiezasVerificadas;
        public int PiezasEmpaquetadas;

        public void Empaquetado(Empaque empaque)
        {
            if (Estado == "Encendida")
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
                    
                }
            }
        

      
        }
    }
}
