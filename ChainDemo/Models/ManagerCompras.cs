using System;
using System.Collections.Generic;
using System.Text;

namespace ChainDemo.Models
{
    public class ManagerCompras : Aprobador
    {
        public override void ProcesarOrden(OrdenCompra ordenCompra)
        {
            if (ordenCompra.Precio < 2500)
            {
                Console.WriteLine($"{this.GetType().Name} aprobo la orden de compra #{ordenCompra.NumeroDeOrden}");
            }
            else
            {
                if (Supervisor != null)
                {
                    Supervisor.ProcesarOrden(ordenCompra);
                }
            }
        }
    }
}
