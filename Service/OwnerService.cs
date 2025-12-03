using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging; 
using Veterinaria.Data;
using Veterinaria.DB;

namespace Veterinaria.Service
{
    public class OwnerService : IOwnerService
    {
        private readonly VeterinariaDBContext _context;
        private readonly ILogger<OwnerService> _logger; 

        public OwnerService(VeterinariaDBContext context, ILogger<OwnerService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Owner>> GetAllOwners()
        {
            return await _context.Owners
                .Include(o => o.Mascotas)
                .ToListAsync();
        }

        public async Task<Owner?> GetOwnerById(int id)
        {
            return await _context.Owners.FindAsync(id);
        }

        public async Task<Owner?> GetOwnerByCuil(string cuil)
        {
            return await _context.Owners.FirstOrDefaultAsync(o => o.Cuil == cuil);
        }

        public async Task<bool> SaveOwner(Owner dueño)
        {
            try
            {
                if (dueño.IdOwner == 0)
                {
                    await _context.Owners.AddAsync(dueño);
                }
                else
                {
                    _context.Owners.Update(dueño);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al guardar el dueño: {Nombre}", dueño.NombreCompleto);
                return false;
            }
        }
    }
}