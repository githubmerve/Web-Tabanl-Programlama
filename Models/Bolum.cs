using System.ComponentModel.DataAnnotations;

namespace OGROTO.Models{
    public class Bolum{
        [Key]

        public int ID{get; set;}
        public string BolumAdi{get;set;}="";
        public int Durum{get;set;}=1;


        public IEnumerable<Ogrenci> ogrenciler{get;set;}
    }
}