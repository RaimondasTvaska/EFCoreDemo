using EFCoreDemo.Data;
using EFCoreDemo.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDemo.Controllers
{
    public class ShopItemController : Controller
    {
        private readonly DataContext _context;

        public ShopItemController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            var shopItem = new ShopItemCreate();
            return View(shopItem);
        }
        [HttpPost]
        public IActionResult Add(ShopItemCreate shopItemCreate)
        {
            var mappedEntity = new ShopItem()
            {
                Name = shopItemCreate.Name,
                ShopId = shopItemCreate.ShopId
            };// mapping (taip vadinasi) 
            _context.ShopItems.Add(mappedEntity);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
