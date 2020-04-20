﻿using System;
namespace Lab4_poo_camila
{
    public class Recepcion : IComputadorCentral
    {
        public const int piezasRecibidas = 60000;
        //public int piezasRecibidas;
        public int piezas_almacenamiento;
        int Memoria;
        public string EstadoMaquinaRecepcion;


        public void piezas_Almacenamiento(Recepcion recepcion)
        {
            
            if (EstadoMaquinaRecepcion == "Encendida")
            {
                if (recepcion.Memoria < 100000)
                {
                    int piezasRecibidas = 60000;
                    recepcion.piezas_almacenamiento = 30000;
                    piezasRecibidas -= recepcion.piezas_almacenamiento;
                    recepcion.Memoria += recepcion.piezas_almacenamiento;
                    Console.WriteLine(" ");
                    Console.WriteLine("Memoria: " + Memoria);
                    Console.WriteLine("Piezas recibidas: " + piezasRecibidas);
                    Console.WriteLine("Piezas que se van al almacenamiento: " + piezas_almacenamiento);
                }
                else
                {
                    Console.WriteLine("Error Recepcion");
                    recepcion.Reiniciar();
                }

            }
            else
            {
                Console.WriteLine(" ");

                Console.WriteLine("No funciona");
            }
        }

        public void Encender()
        {
            Console.WriteLine("Maquina Recepcion Encendida");
            EstadoMaquinaRecepcion = "Encendida";
            Memoria = 0;
        }

        public void Apagar()
        {
            Console.WriteLine("Maquina Apagada");
            EstadoMaquinaRecepcion = "Apagada";

        }

        public void Reiniciar()
        {
            if (Memoria == 100000)
            {
                EstadoMaquinaRecepcion = "Encendida";
                Memoria = 0;
                Console.WriteLine("Maquina Recepcion Reiniciada");
            }
            else
            {
                Console.WriteLine(" ");
            }

        }
    }
}
