using extraaedge.Models;
using extraaedge.Repositories;

namespace ExtraEdge.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository repo;

        public BrandService(IBrandRepository repo)
        {
            this.repo = repo;
        }

        public int AddBrand(Brandname brand)
        {
            return repo.AddBrand(brand);
        }

        public int DeleteBrand(int id)
        {
            return repo.DeleteBrand(id);
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return repo.GetAllBrands();
        }

        public Brand GetBrandById(int id)
        {
            return repo.GetBrandById(id);
        }

        public int UpdateBrand(Brandname brand)
        {
            return repo.UpdateBrand(brand);
        }
    }
}
