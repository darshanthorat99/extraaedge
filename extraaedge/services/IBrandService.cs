using extraaedge.Models;
namespace ExtraEdge.Services
{
    public interface IBrandService
    {
        IEnumerable<Brandname> GetAllBrands();
        Brandname GetBrandById(int id);
        int AddBrand(Bra brand);
        int UpdateBrand(Brand brand);
        int DeleteBrand(int id);


    }
}
