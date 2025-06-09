using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UFSEstates.Data;
using UFSEstates.Models;

namespace UFSEstates.Controllers
{
    public class ComplaintController : Controller
    {
        private readonly IComplaintRepository _compRepo;
        public ComplaintController(IComplaintRepository compRepo)
        {
            _compRepo = compRepo;
        }
        public IActionResult ViewAll()
        {
            var complaints = _compRepo.GetAllComplaints().OrderByDescending(c => c.DateOfComplaint).ToList();
            return View(complaints);
        }
        public IActionResult ViewComplaint(int id)
        {
            var complaint = _compRepo.GetComplaintById(id);
            if (complaint == null)
            {
                return NotFound();
            }
            else
            {
                return View(complaint);
            }
            
        }
        [HttpGet]
        public IActionResult AddComplaint()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddComplaint(Complaint complaint)
        {
            complaint.DateOfComplaint = DateTime.Now;
            if (ModelState.IsValid)
            {
                try
                {
                    _compRepo.AddComplaint(complaint);
                    _compRepo.Save();
                    return RedirectToAction("ViewAll");
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Invalid values");
                }
            }
            return View(complaint);
        }
    }
}
