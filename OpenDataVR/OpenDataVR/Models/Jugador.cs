namespace OpenDataVR.Models
{
    public class Jugador
    {
        public Jugador(int id, String Nombre, String Apodo, String Juego, String Arquetipo, String Posicion, String Elemento, int Potencia, int Control, int Tecnica, int Presion, int Fisico, int Agilidad, int Inteligencia, int Total, String grupoDeEdad, String añoEscolar, String Genero, String rol)
        {
            id = id;
            Nombre = Nombre;
            Apodo = Apodo;
            Juego = Juego;
            Arquetipo = Arquetipo;
            Posicion = Posicion;
            Elemento = Elemento;
            Potencia = Potencia;
            Control = Control;
            Tecnica = Tecnica;
            Presion = Presion;
            Fisico = Fisico;
            Agilidad = Agilidad;
            Inteligencia = Inteligencia;
            Total = Total;
            grupoDeEdad = grupoDeEdad;
            añoEscolar = añoEscolar;
            Genero = Genero;
            rol = rol;
        }
        public int id { get; set; }
        public String Nombre { get; set; }
        public String Apodo { get; set; }
        public String Juego { get; set; }
        public String Arquetipo { get; set; }
        public String Posicion { get; set; }
        public String Elemento { get; set; }
        public int Potencia { get; set; }
        public int Control { get; set; }
        public int Tecnica { get; set; }
        public int Presion { get; set; }
        public int Fisico { get; set; }
        public int Agilidad { get; set; }
        public int Inteligencia { get; set; }
        public int Total { get; set; }
        public String grupoDeEdad { get; set; }
        public String añoEscolar { get; set; }
        public String Genero { get; set; }
        public String rol{ get; set; }
    }
}