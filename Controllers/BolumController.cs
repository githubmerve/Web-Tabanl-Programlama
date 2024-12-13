public class BolumController: Controller
{
}


MyAppContext _context= new MyAppContext();

public IActionResult Index() {
var bolumList=_context.bolumler.Where(b=>b.Durum==1).ToList();
return View(bolumList);
}

public IActionResult BolumSil(int id){ //Db'de durum alanı 0 yapılır.
var blm=_context.bolumler.Find(id);
if (blm!=null){
blm.Durum=0;
_context.SaveChanges();
}
return RedirectToAction("Index");
}


public IActionResult BolumKayit(){
return View();
}
[HttpPost]
public IActionResult BolumKayit(Bolum bolum){
_context.Add(bolum);
_context.SaveChanges();
return RedirectToAction("Index");
}

public IActionResult BolumGetir(int id){
var blm=_context.bolumler.Find(id);
return View(blm);
}

[HttpPost]
public IActionResult BolumDuzenle(Bolum blm){
var bolum=_context.bolumler.Find(blm.id);
if(bolum!=null && blm!=null ){
bolum.BolumAdi=blm.BolumAdi;
_context.SaveChanges();
}
return RedirectToAction("Index");
}
