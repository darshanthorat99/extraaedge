using extraaedge.Models;
namespace extraaedge.Repositories
{
    public interface IBrandRepository
    {
        IEnumerable<Brandname> GetAllBrands();
        Brandname GetBrandById(int id);
        int AddBrand(Brandname brand);
        int UpdateBrand(Brandname brand);
        int DeleteBrand(int id);

    }
}
