namespace OpenDataVR.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apodo { get; set; } = "";
        public string Juego { get; set; } = "";
        public string Arquetipo { get; set; } = "";
        public string Posicion { get; set; } = "";
        public string Elemento { get; set; } = "";
        public int Potencia { get; set; }
        public int Control { get; set; }
        public int Tecnica { get; set; }
        public int Presion { get; set; }
        public int Fisico { get; set; }
        public int Agilidad { get; set; }
        public int Total { get; set; }
        public string GrupoDeEdad { get; set; } = "";
        public string AnioEscolar { get; set; } = "";
        public string Genero { get; set; } = "";
        public string Rol { get; set; } = "";
        public string Imagen { get; set; } = "";
    }
}