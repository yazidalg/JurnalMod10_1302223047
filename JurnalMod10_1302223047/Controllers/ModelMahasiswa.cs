namespace JurnalMod10_1302223047.Controllers
{
    public class ModelMahasiswa
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public int year { get; set; }
        public List<string> courses { get; set; }

        public ModelMahasiswa(string nama, string nim, int year, List<string> courses) 
        { 
            this.nama = nama;
            this.nim = nim;
            this.year = year;
            this.courses = courses;
        }
    }
}
