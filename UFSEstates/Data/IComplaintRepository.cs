using UFSEstates.Models;

namespace UFSEstates.Data
{
    public interface IComplaintRepository
    {
        IEnumerable<Complaint> GetAllComplaints();
        Complaint GetComplaintById(int id);
        void AddComplaint(Complaint complaint);
        void Save();
    }
}
