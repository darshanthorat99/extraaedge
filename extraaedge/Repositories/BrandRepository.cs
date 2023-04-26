
using extraaedge.Models;

namespace extraaedge.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _db;
        public BrandRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public int AddBrand(Brandname brand)
        {
            _db.brands.Add(brand);
            int res=_db.SaveChanges();
            return res;
        }

        public int DeleteBrand(int id)
        {
            int res = 0;
            var brand = _db.brands.Find(id);
            if (brand != null)
            {
                _db.brands.Remove(brand);
                res = _db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Brandname> GetAllBrands()
        {
            return _db.brands.ToList();
        }

        public Brandname GetBrandById(int id)
        {
            var prod = _db.brands.Find(id);
            return prod;
        }

        public int UpdateBrand(Brandname brand)
        {
            int res = 0;
            var p = _db.brands.Where(x => x.Brand == brand.BrandId).FirstOrDefault();
            if (p != null)
            {
                _db.brands.Update(brand);
                res = _db.SaveChanges();
            }
            return res;
        }
    }
}
