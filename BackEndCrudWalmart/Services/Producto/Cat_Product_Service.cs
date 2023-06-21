using Microsoft.EntityFrameworkCore;
using BackEndCrudWalmart.Models;
using BackEndCrudWalmart.Services.Producto;

namespace BackEndCrudWalmart.Services.Implementacion
{
    public class Cat_Product_Service : ICat_ProductService
    {
        private AbastoContext _dbContext;

        public Cat_Product_Service(AbastoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<AtCatProduct> Add(AtCatProduct modelo)
        {
            throw new NotImplementedException();//3155
        }

        public Task<bool> Delete(AtCatProduct modelo)
        {
            throw new NotImplementedException();
        }

        public async Task<AtCatProduct> Get(int idEmpleado)
        {
            try
            {
                AtCatProduct? encontrado = new AtCatProduct();

                encontrado = await _dbContext.AtCatProducts.FirstOrDefaultAsync();

                return encontrado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<List<AtCatProduct>> GetList()
        {
            try
            {
                List<AtCatProduct> lista = new List<AtCatProduct>();
                lista = await _dbContext.AtCatProducts.ToListAsync();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<bool> Update(AtCatProduct modelo)
        {
            throw new NotImplementedException();
        }
    }
}
