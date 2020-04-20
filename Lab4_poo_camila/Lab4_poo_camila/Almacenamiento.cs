﻿using System;
namespace Lab4_poo_camila
{
    public class Almacenamiento : IComputadorCentral
    {
        public int PiezasRecibidas;
        public int PiezasAlmacenadas;
        public int Piezas_Ensamblaje;
        int Memoria;
        string EstadoMaquinaAlmacenamiento;


        public void AlmacenarPiezas(Almacenamiento almacenamiento)

        {
            if (EstadoMaquinaAlmacenamiento == "Encendida")
            {
                if (almacenamiento.Memoria < 50000)
                {
                    almacenamiento.PiezasAlmacenadas = almacenamiento.PiezasRecibidas / 3;
                    almacenamiento.PiezasAlmacenadas += almacenamiento.Piezas_Ensamblaje;
                    almacenamiento.Piezas_Ensamblaje = almacenamiento.PiezasAlmacenadas;
                    almacenamiento.Memoria += almacenamiento.PiezasAlmacenadas;
                    
                    Console.WriteLine(" ");
                    Console.WriteLine("Memoria: " + Memoria);
                    Console.WriteLine("Piezas recibidas en almacenamiento: " + PiezasRecibidas);
                    Console.WriteLine("Piezas que se almacenaron: " + PiezasAlmacenadas);
                    Console.WriteLine("Piezas que se van a ensamblaje: " + Piezas_Ensamblaje);

                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Error Almacenamiento");
                    almacenamiento.Reiniciar();
                }
            }

        }

        public void Encender()
        {
            Console.WriteLine("Maquina Almacenamiento Encendida");
            EstadoMaquinaAlmacenamiento = "Encendida";
            Memoria = 0;
        }

        public void Apagar()
        {
            Console.WriteLine("Maquina Apagada");
            EstadoMaquinaAlmacenamiento = "Apagada";
        }

        public void Reiniciar()
        {
            if (Memoria == 50000)
            {
                
                EstadoMaquinaAlmacenamiento = "Encendida";
                Memoria = 0;
                Console.WriteLine("Maquina Almacenamiento Reiniciada");


            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
