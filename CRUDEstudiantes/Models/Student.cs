namespace CRUDEstudiantes.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = "";

        public string Apellido { get; set; } = "";

        public int Edad { get; set; }

        public string Correo { get; set; } = "";
    }
}
