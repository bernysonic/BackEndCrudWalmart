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

        public async Task<AtCatProduct> Add(AtCatProduct modelo)
        {
            try
            {
                _dbContext.AtCatProducts.Add(modelo);
                await _dbContext.SaveChangesAsync();
                return modelo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> Delete(AtCatProduct modelo)
        {
            try
            {
                _dbContext.AtCatProducts.Remove(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<AtCatProduct> Get(int idProducto)
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

        public async Task<bool> Update(AtCatProduct modelo)
        {
            try
            {
                _dbContext.AtCatProducts.Update(modelo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
