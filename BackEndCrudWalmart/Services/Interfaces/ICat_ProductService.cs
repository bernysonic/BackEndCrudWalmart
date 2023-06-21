using BackEndCrudWalmart.Models;
namespace BackEndCrudWalmart.Services.Producto
{
    public interface ICat_ProductService
    {
        Task<List<AtCatProduct>> GetList();
        Task<AtCatProduct> Get(int idEmpleado);
        Task<AtCatProduct> Add(AtCatProduct modelo);
        Task<bool> Update(AtCatProduct modelo);
        Task<bool> Delete(AtCatProduct modelo);
    }
}


