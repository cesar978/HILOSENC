using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace hilosenCsharp
{
    class SumarThread
    {
        public void sumar(object parametro)
        {
            Thread current = Thread.CurrentThread;
            Int32[] numero = (Int32[])parametro;
            Int32 resultado = numero[0] + numero[1];
            Console.WriteLine("Durmiendo por" + resultado +
                "segundo");
            Thread.Sleep(resultado * 1000);
            Console.WriteLine("El resultado de la suma es " +
                numero[0] + " + " + numero[1] + " = " +
                resultado);
            Console.WriteLine("hilo " + current.Name + "finalizo su trabajo");
        }
    }
}
