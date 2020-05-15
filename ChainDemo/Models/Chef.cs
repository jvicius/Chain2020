using System;

namespace ChainDemo.Models
{
    public class Chef : Aprobador
    {
        public override void ProcesarOrden(OrdenCompra ordenCompra)
        {
            if (ordenCompra.Precio < 1000)
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
