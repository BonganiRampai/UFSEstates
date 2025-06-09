
using UFSEstates.Models;

namespace UFSEstates.Data
{
    public class ComplaintRepository:IComplaintRepository
    {
        private readonly AppDbContext _appDbContext;
        public ComplaintRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddComplaint(Complaint complaint)
        {
            _appDbContext.Complaints.Add(complaint);
        }

        public IEnumerable<Complaint> GetAllComplaints()
        {
            return _appDbContext.Complaints;
        }

        public Complaint GetComplaintById(int id)
        {
            return _appDbContext.Complaints.FirstOrDefault(c=>c.Id == id);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }
    }
}
