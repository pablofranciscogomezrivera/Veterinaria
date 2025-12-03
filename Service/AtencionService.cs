using Microsoft.EntityFrameworkCore;
using Veterinaria.Data;
using Veterinaria.DB;
using Microsoft.Extensions.Logging;


namespace Veterinaria.Service
{
    public class AtencionService : IAtencionService
    {
        private readonly VeterinariaDBContext _context;
        private readonly ILogger<AtencionService> _logger;

        public AtencionService(VeterinariaDBContext context, ILogger<AtencionService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Atencion>> GetAllAtenciones()
        {
            return await _context.Atenciones
                .Include(a => a.Mascota)
                .ThenInclude(m => m.Owner)
                .OrderByDescending(a => a.FechaAtencion)
                .ToListAsync();
        }

        public async Task<Atencion?> GetAtencionById(int id)
        {
            return await _context.Atenciones
                .Include(a => a.Mascota)
                .ThenInclude(m => m.Owner)
                .FirstOrDefaultAsync(a => a.IdAtencion == id);
        }

        public async Task<bool> SaveAtencion(Atencion atencion)
        {
            try
            {
                if (atencion.IdAtencion == 0)
                {
                    // Es una atención nueva
                    await _context.Atenciones.AddAsync(atencion);
                }
                else
                {
                    // Es una edición
                    _context.Atenciones.Update(atencion);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar la atención para la mascota ID: {IdMascota}", atencion.IdMascota);
                return false;
            }
        }

        public async Task<List<Atencion>> GetAtencionesByMascotaId(int idMascota)
        {
            return await _context.Atenciones
                .Where(a => a.IdMascota == idMascota)
                .OrderByDescending(a => a.FechaAtencion)
                .ToListAsync();
        }
    }
}
