using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hilosenCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SumarThread sumarThread = new SumarThread();

            Thread hilo1 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));
            Thread hilo2 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));
            Thread hilo3 = new Thread(new ParameterizedThreadStart(sumarThread.sumar));

            hilo1.Name = "Hilo 1";
            hilo2.Name = "Hilo 2";
            hilo3.Name = "Hilo 3";

            Int32[] parametros1 = { 2, 1 };
            Int32[] parametros2 = { 2, 2 };
            Int32[] parametros3 = { 2, 3 };

           
            Console.WriteLine("preparado los hilos");
            hilo1.Start(parametros1);
            hilo2.Start(parametros2);
            hilo3.Start(parametros3);
            Console.WriteLine("hilos procesando...");
            Console.ReadLine();
        }
    }
}
