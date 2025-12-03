using Veterinaria.Data;

namespace Veterinaria.Service
{
    public interface IMascotaService
    {
        Task<List<Mascota>> GetAllMascotas();
        Task<Mascota?> GetMascotaById(int id);
        Task<List<Mascota>> GetMascotasByOwnerId(int idDueño);
        Task<bool> SaveMascota(Mascota mascota);
    }
}