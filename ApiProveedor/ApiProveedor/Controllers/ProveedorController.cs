using ApiProveedor.Models;
using Microsoft.AspNetCore.Mvc;
using ApiProveedor.Repositories;
using Microsoft.IdentityModel.Tokens;


namespace ApiProveedor.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProveedorController:ControllerBase
    {
        private readonly IProveedorRepository proveedorRepository;
        public ProveedorController(IProveedorRepository proveedorRepository)
        {      
            this.proveedorRepository = proveedorRepository;
        }

        [HttpGet]
        [Route("/GetProveedores")]
        public async Task<IEnumerable<Proveedore>> GetProveedores()
        {
            return await proveedorRepository.GetProveedores();
        }
        
        [HttpGet]
        [Route("/GetProveedoresById/{id}")]
        public async Task<Proveedore> GetProveedorById(int id)
        {
            return await proveedorRepository.GetProveedorById(id);
        }

        [HttpPost]
        [Route("/CreateProveedores")]
        public async Task<Proveedore> CreateProveedor(Proveedore proveedore)
        {
            return await proveedorRepository.CreateProveedor(proveedore);
        }

        [HttpPut]
        [Route("/UpdateProveedores")]
        public async Task<Proveedore> UpdateProveedor(Proveedore proveedore)
        {
            return await proveedorRepository.UpdateProveedor(proveedore);
        }

        [HttpDelete]
        [Route("/DeleteProveedores")]
        public async Task<bool> DeleteProveedor(int id)
        {
            return await proveedorRepository.DeleteProveedor(id);
        }
    }
}
