using BiuroRzeczyZnalezionych.Models;
using Microsoft.AspNetCore.Mvc;

namespace BiuroRzeczyZnalezionych.Controllers
{
    public class PrzedmiotController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteItem(PrzedmiotModel przedmiot)
        {
            var manager = new PrzedmiotManager();
            manager.DeleteItemById(przedmiot.ID);
            return RedirectToAction("ItemList");
        }
        [HttpPost]
        public IActionResult EditItem(PrzedmiotModel przedmiot)
        {
            var manager = new PrzedmiotManager();
            manager.UpdateItem(przedmiot);
            return RedirectToAction("ItemList");
        }

        [HttpPost]
        public IActionResult AddItem(PrzedmiotModel przedmiot)
        {
            var manager = new PrzedmiotManager();
            manager.AddItem(przedmiot);
            return RedirectToAction("ItemList");
        }
        [HttpGet]
        public IActionResult DeleteItemForm(int id) 
        {
            var manager = new PrzedmiotManager();
            return View(manager.GetItemById(id));
        }
        [HttpGet]
        public IActionResult EditItemForm(int id)
        {
            var manager = new PrzedmiotManager();
            return View(manager.GetItemById(id));
        }
        [HttpGet]
        public IActionResult AddItemForm(){ return View(); }
        [HttpGet]
        public IActionResult ItemList()
        {
            var manager = new PrzedmiotManager();
            var data = manager.GetAllItems();
            return View(data);
        }
        [HttpGet]
        public IActionResult ReturnItem(int id)
        {
            var manager = new PrzedmiotManager();
            manager.ReturnItem(id);
            return RedirectToAction("ItemList");
        }
        [HttpGet]
        public IActionResult Contact() { return View(); }
        
    }
}
