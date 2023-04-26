using extraaedge.Models;
namespace extraaedge.Repositories;

namespace ExtraEdge.Services
{
    public class MobileService:IMobileRepository
    {
        private readonly IMobileRepository repo;

        public MobileService(IMobileRepository repo)
        {
            this.repo = repo;
        }

        public int AddMobile(Mobile mobile)
        {
            return repo.AddMobile(mobile);
        }

        public int Deletemobile(int id)
        {
            return repo.Deletemobile(id);
        }

        public Mobile GetMobilebyId(int id)
        {
            return repo.GetMobilebyId(id);
        }

        public IEnumerable<Mobile> GetMobiles()
        {
            return repo.GetMobiles();
        }

        public int Updatemobile(Mobile mobile)
        {
            return repo.Updatemobile(mobile);
        }
    }
}
