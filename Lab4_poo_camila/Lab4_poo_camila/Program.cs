using System;

namespace Lab4_poo_camila
{
    class Program

    {
        
        public static void Main(string[] args)
        {
            var rnd = new Random();
            Recepcion recepcion1 = new Recepcion();
            Almacenamiento almacenamiento1 = new Almacenamiento();
            Ensamblaje ensamblaje1 = new Ensamblaje();
            Verificacion verificacion1 = new Verificacion();
            Empaque empaque1 = new Empaque();


            recepcion1.Encender();
            almacenamiento1.Encender();
            ensamblaje1.Encender();
            verificacion1.Encender();
            empaque1.Encender();

            //recepcion1.piezasRecibidas = rnd.Next(1, 50000);
            recepcion1.piezas_Almacenamiento(recepcion1);
            almacenamiento1.PiezasRecibidas = recepcion1.piezas_almacenamiento;
            almacenamiento1.AlmacenarPiezas(almacenamiento1);
            ensamblaje1.PiezasAlmacenadas = almacenamiento1.Piezas_Ensamblaje;
            ensamblaje1.Ensamblar_Piezas(ensamblaje1);
            verificacion1.PiezasEnsambladas = ensamblaje1.Piezas_Verificacion;
            verificacion1.Verificacion_Calidad(verificacion1);
            empaque1.PiezasVerificadas = verificacion1.Piezas_Empaque;
            empaque1.Empaquetado(empaque1);

            Console.WriteLine("Hello World!");
        }
    }
}
