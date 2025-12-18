using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OpenDataVR.Models;
using OpenDataVR.Services;

namespace OpenDataVR.Controllers
{
    public class JugadoresController : Controller
    {
        private readonly JugadoresDataService _svc;

        public JugadoresController(JugadoresDataService svc)
        {
            _svc = svc;
        }

        public IActionResult Index(string? buscar, string? arquetipo, string? posicion, string? elemento, string? rol, string? orden)
        {
            var jugadores = _svc.GetAll().AsQueryable();

            // Bilatu izen edo ezizenaren arabera
            if (!string.IsNullOrWhiteSpace(buscar))
            {
                var b = buscar.Trim().ToLower();
                jugadores = jugadores.Where(j =>
                    (j.Nombre ?? "").ToLower().Contains(b) ||
                    (j.Apodo ?? "").ToLower().Contains(b));
            }

            // Filtratzeko 
            if (!string.IsNullOrWhiteSpace(arquetipo)) jugadores = jugadores.Where(j => j.Arquetipo == arquetipo);
            if (!string.IsNullOrWhiteSpace(posicion)) jugadores = jugadores.Where(j => j.Posicion == posicion);
            if (!string.IsNullOrWhiteSpace(elemento)) jugadores = jugadores.Where(j => j.Elemento == elemento);
            if (!string.IsNullOrWhiteSpace(rol)) jugadores = jugadores.Where(j => j.Rol == rol);

            // ordenatzeko
            orden ??= "Nombre";
            jugadores = orden switch
            {
                "Nombre_desc" => jugadores.OrderByDescending(j => j.Nombre),
                "Apodo" => jugadores.OrderBy(j => j.Apodo),
                "Apodo_desc" => jugadores.OrderByDescending(j => j.Apodo),
                "Arquetipo" => jugadores.OrderBy(j => j.Arquetipo),
                "Arquetipo_desc" => jugadores.OrderByDescending(j => j.Arquetipo),
                "Posicion" => jugadores.OrderBy(j => j.Posicion),
                "Posicion_desc" => jugadores.OrderByDescending(j => j.Posicion),
                "Elemento" => jugadores.OrderBy(j => j.Elemento),
                "Elemento_desc" => jugadores.OrderByDescending(j => j.Elemento),
                "Rol" => jugadores.OrderBy(j => j.Rol),
                "Rol_desc" => jugadores.OrderByDescending(j => j.Rol),
                "Total" => jugadores.OrderBy(j => j.Total),
                "Total_desc" => jugadores.OrderByDescending(j => j.Total),
                _ => jugadores.OrderBy(j => j.Nombre),
            };

            // Dropdowns (Submenu bat da)
            var all = _svc.GetAll();

            var vm = new JugadoresIndexVM
            {
                Jugadores = jugadores.ToList(),
                Buscar = buscar,
                Arquetipo = arquetipo,
                Posicion = posicion,
                Elemento = elemento,
                Rol = rol,
                Orden = orden,

                Arquetipos = BuildSelect(all.Select(x => x.Arquetipo)),
                Posiciones = BuildSelect(all.Select(x => x.Posicion)),
                Elementos = BuildSelect(all.Select(x => x.Elemento)),
                Roles = BuildSelect(all.Select(x => x.Rol)),
            };

            return View(vm);
        }

        private static List<SelectListItem> BuildSelect(IEnumerable<string> values)
        {
            return values
                .Where(v => !string.IsNullOrWhiteSpace(v))
                .Distinct()
                .OrderBy(v => v)
                .Select(v => new SelectListItem { Value = v, Text = v })
                .ToList();
        }
    }
}
