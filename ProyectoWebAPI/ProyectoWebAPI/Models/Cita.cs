namespace ProyectoWebAPI.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public string NroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Especialidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
