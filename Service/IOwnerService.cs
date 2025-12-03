using Veterinaria.Data;

namespace Veterinaria.Service
{
    public interface IOwnerService
    {
        Task<List<Owner>> GetAllOwners();
        Task<Owner?> GetOwnerById(int id);
        Task<Owner?> GetOwnerByCuil(string cuil);
        Task<bool> SaveOwner(Owner dueño);
    }
}