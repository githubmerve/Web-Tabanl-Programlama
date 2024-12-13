using Microsoft.AspNetCore.Mvc;
namespace Ders03.Controllers;

public class OgretmenController:OgretmenController{
     public IActionResult OgretmenKayit(OgretmenController ogrt)
     {
       return View();
}
}
MyAppContext _context = new MyAppContext();
public IActionResult Index()
{
 var ogrtList = _context.ogretmen.ToList();
 return View(ogrtList);
}

Public IActionResult OgretmenKayit(){
  return View();
}

[HttpPost]

public IActionResult OgretmenKayit(Ogretmen ogrt){
  _context.ogretmenler.Add(ogrt);
  _context.SaveChanges();
  return RedirectToAction("Index");
}

public IActionResult OgretmenDuzenle(Ogretmen ogrt){
  var ogretmen=_context.ogretmenler.Find(ogrt.OgretmenId);
  if(ogretmen!=null){
    ogretmen.Ad=ogrt.Ad;
    ogretmen.Soyad=ogrt.Soyad;
    ogretmen.Unvan=ogrt.Unvan;
    ogretmen.BolumID;
    _context.SaveChanges();
   
     }
      return RedirectToAction("Index")
}

public IActionResult OgretmenGetir(int id){
  var ogrt =_context.ogretmenler.Find(id);
  return View(ogrt);

}