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

        public IActionResult Index(
    string? buscar, string? arquetipo, string? posicion, string? elemento, string? rol,
    string? orden, int pagina = 1)
        {
            const int tamPagina = 20;

            var jugadores = _svc.GetAll().AsQueryable();

            // bilatzailea
            if (!string.IsNullOrWhiteSpace(buscar))
            {
                var b = buscar.Trim().ToLower();
                jugadores = jugadores.Where(j =>
                    (j.Nombre ?? "").ToLower().Contains(b) ||
                    (j.Apodo ?? "").ToLower().Contains(b));
            }

            // filtrazioak
            if (!string.IsNullOrWhiteSpace(arquetipo)) jugadores = jugadores.Where(j => j.Arquetipo == arquetipo);
            if (!string.IsNullOrWhiteSpace(posicion)) jugadores = jugadores.Where(j => j.Posicion == posicion);
            if (!string.IsNullOrWhiteSpace(elemento)) jugadores = jugadores.Where(j => j.Elemento == elemento);
            if (!string.IsNullOrWhiteSpace(rol)) jugadores = jugadores.Where(j => j.Rol == rol);

            // ordenatu
            orden ??= "Id";

            jugadores = orden switch
            {
                // ===== ID (normal) =====
                "Id" => jugadores.OrderBy(j => j.Id),
                "Id_desc" => jugadores.OrderByDescending(j => j.Id),

                // ===== TEXTO (??? SIEMPRE AL FINAL) =====
                "Nombre" =>
                    jugadores.OrderBy(j => j.Nombre == "???" || string.IsNullOrWhiteSpace(j.Nombre))
                             .ThenBy(j => j.Nombre),

                "Nombre_desc" =>
                    jugadores.OrderBy(j => j.Nombre == "???" || string.IsNullOrWhiteSpace(j.Nombre))
                             .ThenByDescending(j => j.Nombre),

                "Apodo" =>
                    jugadores.OrderBy(j => j.Apodo == "???" || string.IsNullOrWhiteSpace(j.Apodo))
                             .ThenBy(j => j.Apodo),

                "Apodo_desc" =>
                    jugadores.OrderBy(j => j.Apodo == "???" || string.IsNullOrWhiteSpace(j.Apodo))
                             .ThenByDescending(j => j.Apodo),

                "Juego" =>
                    jugadores.OrderBy(j => j.Juego == "???" || string.IsNullOrWhiteSpace(j.Juego))
                             .ThenBy(j => j.Juego),

                "Juego_desc" =>
                    jugadores.OrderBy(j => j.Juego == "???" || string.IsNullOrWhiteSpace(j.Juego))
                             .ThenByDescending(j => j.Juego),

                "Arquetipo" =>
                    jugadores.OrderBy(j => j.Arquetipo == "Unknown" || string.IsNullOrWhiteSpace(j.Arquetipo))
                             .ThenBy(j => j.Arquetipo),

                "Arquetipo_desc" =>
                    jugadores.OrderBy(j => j.Arquetipo == "Unknown" || string.IsNullOrWhiteSpace(j.Arquetipo))
                             .ThenByDescending(j => j.Arquetipo),

                "Posicion" =>
                    jugadores.OrderBy(j => j.Posicion == "?" || string.IsNullOrWhiteSpace(j.Posicion))
                             .ThenBy(j => j.Posicion),

                "Posicion_desc" =>
                    jugadores.OrderBy(j => j.Posicion == "?" || string.IsNullOrWhiteSpace(j.Posicion))
                             .ThenByDescending(j => j.Posicion),

                "Elemento" =>
                    jugadores.OrderBy(j => j.Elemento == "?" || string.IsNullOrWhiteSpace(j.Elemento))
                             .ThenBy(j => j.Elemento),

                "Elemento_desc" =>
                    jugadores.OrderBy(j => j.Elemento == "?" || string.IsNullOrWhiteSpace(j.Elemento))
                             .ThenByDescending(j => j.Elemento),

                "Rol" =>
                    jugadores.OrderBy(j => j.Rol == "?" || string.IsNullOrWhiteSpace(j.Rol))
                             .ThenBy(j => j.Rol),

                "Rol_desc" =>
                    jugadores.OrderBy(j => j.Rol == "?" || string.IsNullOrWhiteSpace(j.Rol))
                             .ThenByDescending(j => j.Rol),

                // ===== NUMÉRICOS (null SIEMPRE AL FINAL) =====
                "Potencia" =>
                    jugadores.OrderBy(j => j.Potencia == null)
                             .ThenBy(j => j.Potencia),

                "Potencia_desc" =>
                    jugadores.OrderBy(j => j.Potencia == null)
                             .ThenByDescending(j => j.Potencia),

                "Control" =>
                    jugadores.OrderBy(j => j.Control == null)
                             .ThenBy(j => j.Control),

                "Control_desc" =>
                    jugadores.OrderBy(j => j.Control == null)
                             .ThenByDescending(j => j.Control),

                "Tecnica" =>
                    jugadores.OrderBy(j => j.Tecnica == null)
                             .ThenBy(j => j.Tecnica),

                "Tecnica_desc" =>
                    jugadores.OrderBy(j => j.Tecnica == null)
                             .ThenByDescending(j => j.Tecnica),

                "Presion" =>
                    jugadores.OrderBy(j => j.Presion == null)
                             .ThenBy(j => j.Presion),

                "Presion_desc" =>
                    jugadores.OrderBy(j => j.Presion == null)
                             .ThenByDescending(j => j.Presion),

                "Fisico" =>
                    jugadores.OrderBy(j => j.Fisico == null)
                             .ThenBy(j => j.Fisico),

                "Fisico_desc" =>
                    jugadores.OrderBy(j => j.Fisico == null)
                             .ThenByDescending(j => j.Fisico),

                "Agilidad" =>
                    jugadores.OrderBy(j => j.Agilidad == null)
                             .ThenBy(j => j.Agilidad),

                "Agilidad_desc" =>
                    jugadores.OrderBy(j => j.Agilidad == null)
                             .ThenByDescending(j => j.Agilidad),

                "Total" =>
                    jugadores.OrderBy(j => j.Total == null || j.Total == 0)
                              .ThenBy(j => j.Total),

                "Total_desc" =>
                    jugadores.OrderBy(j => j.Total == null || j.Total == 0)
                             .ThenByDescending(j => j.Total),


                _ => jugadores.OrderBy(j => j.Id)
            };


            // filtrazioaren ondoriozko totala
            var totalFiltrados = jugadores.Count();

            // limitazioa
            var totalPaginas = (int)Math.Ceiling(totalFiltrados / (double)tamPagina);
            if (totalPaginas == 0) totalPaginas = 1;
            if (pagina < 1) pagina = 1;
            if (pagina > totalPaginas) pagina = totalPaginas;

            // orrialdeatzea
            var paginados = jugadores
                .Skip((pagina - 1) * tamPagina)
                .Take(tamPagina)
                .ToList();

            // Dropdowns (Submenua)
            var all = _svc.GetAll();

            var vm = new JugadoresIndexVM
            {
                Jugadores = paginados,
                Buscar = buscar,
                Arquetipo = arquetipo,
                Posicion = posicion,
                Elemento = elemento,
                Rol = rol,
                Orden = orden,

                Pagina = pagina,
                TamPagina = tamPagina,
                TotalFiltrados = totalFiltrados,

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
