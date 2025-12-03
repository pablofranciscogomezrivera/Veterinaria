using Microsoft.EntityFrameworkCore;
using Veterinaria.Data;
using Veterinaria.DB;

namespace Veterinaria.Service
{
    public class OwnerService
    {
        private readonly VeterinariaDBContext _context;

        public OwnerService(VeterinariaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Owner>> GetAllOwners()
        {
            return await _context.Owners.ToListAsync();
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
                return false;
            }
        }
    }
}