using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDemo.Models
{
    public class ManagerGeneral : Aprobador
    {
        public override void ProcesarOrden(OrdenCompra ordenCompra)
        {
            if (ordenCompra.Precio < 10000)
            {
                Console.WriteLine($"{this.GetType().Name} aprobo la orden de compra #{ordenCompra.NumeroDeOrden}");
            }
            else
            {
                Console.WriteLine($"Orden de compra #{ordenCompra.NumeroDeOrden} requiere una junta ejecutiva");
            }
        }
    }
}
