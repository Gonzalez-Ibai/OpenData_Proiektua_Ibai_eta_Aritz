using System.Text.Json;
using OpenDataVR.Models;
using OpenDataVR.Converters;

namespace OpenDataVR.Services
{
    public class JugadoresDataService
    {
        private readonly IWebHostEnvironment _env;
        private List<Jugador>? _cache;

        public JugadoresDataService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public List<Jugador> GetAll()
        {
            if (_cache != null) return _cache;

            var path = Path.Combine(_env.WebRootPath, "data", "jugadores_limpio.json");
            var json = File.ReadAllText(path);

            var opts = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            opts.Converters.Add(new FlexibleNullableIntConverter());


            var data = JsonSerializer.Deserialize<List<Jugador>>(json, opts) ?? new List<Jugador>();

            // segurtasuna (jokalari batek daturen bat arraro duenean)
            _cache = data
            .Where(j => j.Id > 0 && !string.IsNullOrWhiteSpace(j.Nombre))
            .ToList();

            return _cache;
        }
    }
}
    