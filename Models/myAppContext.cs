namespace OgrOtoModel{
   
    public class myAppContext:DbContext{
        public DbSet<Ogrenci> ogrenciler {get; set;}
        public DbSet<Bolum> bolumler {get; set;}        
        public DbSet<Ogretmen> ogretmenler {get; set;}
        public DbSet<Ders> dersler {get; set;}
        public DbSet<User> users {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder){
            Server=(local)SQLEXPRESS;Database=WebApplication1;User Id=sa;Password=Merve1234;
            optionsBuilder.UseSqlServer();
        }
    }
}