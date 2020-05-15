using ChainDemo.Models;
using System;

namespace ChainDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var jennifer = new Chef();
            var miguel = new ManagerCompras();
            var olivia = new ManagerGeneral();

            jennifer.AsignarSupervisor(miguel);
            miguel.AsignarSupervisor(olivia);

            var p = new OrdenCompra(1, 20, 69, "Especias");
            jennifer.ProcesarOrden(p);

            p = new OrdenCompra(2, 300, 1389, "Vegetales");
            jennifer.ProcesarOrden(p);

            p = new OrdenCompra(3, 500, 4822.99, "Carnes");
            jennifer.ProcesarOrden(p);

            p = new OrdenCompra(4, 500, 12000, "Cerveza");
            jennifer.ProcesarOrden(p);


        }
    }
}
