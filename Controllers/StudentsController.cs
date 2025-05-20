using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Data;
using StudentPortal.Web.Models;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: /Students/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View(new AddStudentViewModel());
        }

        // POST: /Students/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            TempData["SuccessMessage"] = "Student added successfully!";
            return RedirectToAction("List");
        }

        // GET: /Students/List
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }

        // GET: /Students/Edit/{id}
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            var viewModel = new AddStudentViewModel
            {
                Name = student.Name,
                Email = student.Email,
                Phone = student.Phone,
                Subscribed = student.Subscribed
            };

            ViewBag.StudentId = student.Id;

            return View(viewModel);
        }

        // POST: /Students/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, AddStudentViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.StudentId = id;
                return View(viewModel);
            }

            var student = await dbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            student.Name = viewModel.Name;
            student.Email = viewModel.Email;
            student.Phone = viewModel.Phone;
            student.Subscribed = viewModel.Subscribed;

            dbContext.Students.Update(student);
            await dbContext.SaveChangesAsync();

            TempData["SuccessMessage"] = "Student updated successfully!";
            return RedirectToAction("List");
        }

        // POST: /Students/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);

            if (student != null)
            {
                dbContext.Students.Remove(student);
                await dbContext.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student deleted successfully!";
            }

            return RedirectToAction("List");
        }
    }
}
