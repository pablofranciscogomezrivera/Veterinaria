using Microsoft.EntityFrameworkCore;
using Veterinaria.Data;
using Veterinaria.DB;
using Microsoft.Extensions.Logging;

namespace Veterinaria.Service
{
    public class MascotaService : IMascotaService
    {
        private readonly VeterinariaDBContext _context;
        private readonly ILogger<MascotaService> _logger;

        public MascotaService(VeterinariaDBContext context, ILogger<MascotaService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Mascota>> GetAllMascotas()
        {
            return await _context.Mascotas
                .Include(m => m.Owner)
                .ToListAsync();
        }

        public async Task<Mascota?> GetMascotaById(int id)
        {
            return await _context.Mascotas
                .Include(m => m.Owner)
                .FirstOrDefaultAsync(m => m.IdMascota == id);
        }

        public async Task<bool> SaveMascota(Mascota mascota)
        {
            try
            {
                if (mascota.IdMascota == 0)
                {
                    await _context.Mascotas.AddAsync(mascota);
                }
                else
                {
                    _context.Mascotas.Update(mascota);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar la mascota: {Nombre}", mascota.Nombre);
                return false;
            }
        }

        public async Task<List<Mascota>> GetMascotasByOwnerId(int idDueño)
        {
            return await _context.Mascotas
                .Where(m => m.IdOwner == idDueño)
                .ToListAsync();
        }
    }
}
