namespace ChainDemo.Models
{
    public abstract class Aprobador
    {
        protected Aprobador Supervisor;
        public void AsignarSupervisor(Aprobador supervisor)
        {
            Supervisor = supervisor;
        }

        public abstract void ProcesarOrden(OrdenCompra ordenCompra);
    }
}
