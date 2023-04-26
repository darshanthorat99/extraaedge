using extraaedge.Data;
using extraaedge.Models;

namespace extraaedge.Repositoriese
{
    public class MobileRepository : IMobileRepository
    {
        private readonly ApplicationDbContext db;
        public MobileRepository(ApplicationDbContext db)
        {
            db = db;   
        }
        public int AddMobile(Mobile mobile)
        {
            db.mobiles.Add(mobile);
            int res=db.mobiles.Count();
            return res;
        }

        public int Deletemobile(int id)
        {
            int res = 0;
            var prod = db.mobiles.Find(id);
            if (prod != null)
            {
                db.mobiles.Remove(prod);
                res = db.SaveChanges();
            }
            return res;
        }

        public Mobile GetMobilebyId(int id)
        {
            var prod=db.mobiles.Find(id);
            return prod;
        }

        public IEnumerable<Mobile> GetMobiles()
        {
            return db.mobiles.ToList();
        }

        public int Updatemobile(Mobile mobile)
        {
            int res = 0;
            var p = db.mobiles.Where(x => x.Mid == mobile.Mid).FirstOrDefault();
            if (p != null)
            {
                db.mobiles.Update(mobile);
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
