using Microsoft.AspNetCore.Mvc.Rendering;

namespace OpenDataVR.Models
{
    public class JugadoresIndexVM
    {
        public List<Jugador> Jugadores { get; set; } = new();

        // filtroak aukeratzeko zerrendak
        public string? Buscar { get; set; }
        public string? Arquetipo { get; set; }
        public string? Posicion { get; set; }
        public string? Elemento { get; set; }
        public string? Rol { get; set; }

        public string? Orden { get; set; } //ordenatzeko 

        
        public List<SelectListItem> Arquetipos { get; set; } = new();
        public List<SelectListItem> Posiciones { get; set; } = new();
        public List<SelectListItem> Elementos { get; set; } = new();
        public List<SelectListItem> Roles { get; set; } = new();

        //orrialdeka egiteko, orrialdeak sortu eta nabigatzeko.
        public int Pagina { get; set; } = 1;
        public int TamPagina { get; set; } = 20;
        public int TotalFiltrados { get; set; }
        public int TotalPaginas => (int)Math.Ceiling((double)TotalFiltrados / TamPagina);

    }
}
