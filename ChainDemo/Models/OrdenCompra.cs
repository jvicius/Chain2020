using System;

namespace ChainDemo.Models
{
    public class OrdenCompra
    {
        public OrdenCompra(int numeroDeOrden, double cantidad, double precio, string nombre)
        {
            NumeroDeOrden = numeroDeOrden;
            Cantidad = cantidad;
            Precio = precio;
            Nombre = nombre;
            Console.WriteLine($"Solicitud de orden {numeroDeOrden} de compra por {nombre}, cantidad: {cantidad}, precio: ${precio}, ha sido recibida");
        }

        public int NumeroDeOrden { set; get; }
        public double Cantidad { set; get; }
        public double Precio { set; get; }
        public string Nombre { set; get; }
    }
}
