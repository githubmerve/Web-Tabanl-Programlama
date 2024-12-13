namespace OgrOto.Models{

    public class Ogrenci{
      public int OgrenciID{get;set;}
      public int OgrenciNo{get;set;}
      public string Ad{get;set;}="";
      public string Soyad{get;set;}=string.Empty;
      public string Bolum{get;set;}="";
      public string ePosta{get;set;}="";

      public virtual Bolum Bolum {get; set;}

    }
}