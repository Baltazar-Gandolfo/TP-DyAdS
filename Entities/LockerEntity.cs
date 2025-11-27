namespace Entities
{
    public class LockerEntity
    {
        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public string Tamaño { get; set; }
        public string Estado { get; set; }
        public string Codigo_Actual { get; set; }
        public DateTime Fecha_Deposito { get; set; }
        public string Tracking_Paquete { get; set; }
        public DateTime Ultima_Mantencion { get; set; }

        public ResidenteEntity Residente { get; set; }
        public RepartidorEntity Repartidor { get; set; }

    }
}
