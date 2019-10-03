using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReadyTask.Data;
using ReadyTask.Models;

namespace ReadyTask.Controllers
{
    public class TaskItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TaskItemController(ApplicationDbContext context) {
            _context = context;
        }
        // GET: TaskItem
        public ActionResult Index()
        {
            //eddited
            List<TaskItem> allTasks = _context.TaskItems.Include(t => t.AssignedUser).ToList();
            return View(allTasks);
        }

        // GET: TaskItem/Details/5
        public ActionResult Details(int id)
        {
            TaskItem task = _context.TaskItems.FirstOrDefault(t => t.Id == id);
            return View();
        }

        // GET: TaskItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaskItem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TaskItem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}