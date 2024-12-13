using Microsoft.AspNetCore.Mvc;
namespace Ders03.Controllers;

public class OgrenciController:Controller{//ogrencicontroller controllerdan türer
    
    myAppContext _context = new myAppContext();
    public IActionResult Index(){
       var ogrenciler= _context.ogrenciler.Include(b => b.Bolum).ToList();
       return View(ogrList);
};

   public IActionResult OgrenciKayit(){
    var blm =_context.bolumler.Where(b => b.Bolum == 1).ToList();
       return View(blm);
}

[HttpPost]
public IActionResult OgrenciKayit(OgrenciController ogr){
    _context.ogrenciler.Add(ogr);
    _context.SaveChanges();
    return RedirectToAction("Index");
}

}
