using ApiProveedor.Models;

namespace ApiProveedor.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedore>> GetProveedores();
        Task<Proveedore> GetProveedorById(int id);
        Task<Proveedore> CreateProveedor(Proveedore proveedore);
        Task<Proveedore> UpdateProveedor(Proveedore proveedore);
        Task<bool> DeleteProveedor(int id);
    }
}
