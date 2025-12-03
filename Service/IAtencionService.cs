using Veterinaria.Data;

namespace Veterinaria.Service
{
    public interface IAtencionService
    {
        Task<List<Atencion>> GetAllAtenciones();
        Task<Atencion?> GetAtencionById(int id);
        Task<List<Atencion>> GetAtencionesByMascotaId(int idMascota);
        Task<bool> SaveAtencion(Atencion atencion);
    }
}