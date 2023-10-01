using ApiProveedor.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProveedor.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly ProveedorBDContext dbContext;
        public ProveedorRepository(ProveedorBDContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Proveedore> CreateProveedor(Proveedore proveedore)
        {
            dbContext.Proveedores.Add(proveedore);
            await dbContext.SaveChangesAsync();
            return proveedore;
        }

        public async Task<bool> DeleteProveedor(int id)
        {
            var proveedore = await dbContext.Proveedores.FirstOrDefaultAsync(p => p.ProveedorId== id);
            if (proveedore == null) 
            {
                return false;
            }
            dbContext.Proveedores.Remove(proveedore);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Proveedore> GetProveedorById(int id)
        {
            var proveedore = await dbContext.Proveedores.Where(p => p.ProveedorId == id).FirstOrDefaultAsync();
            return proveedore;
        }

        public async Task<IEnumerable<Proveedore>> GetProveedores()
        {
            return await dbContext.Proveedores.ToListAsync();
        }

        public async Task<Proveedore> UpdateProveedor(Proveedore proveedore)
        {
            dbContext.Proveedores.Update(proveedore);
            await dbContext.SaveChangesAsync();
            return proveedore;
        }
    }
}
