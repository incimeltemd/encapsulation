internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogrenci1= new Ogrenci();
        ogrenci1.Isim="Murat";
        ogrenci1.Soyisim="Can";
        ogrenci1.OkulNo=123;
        ogrenci1.Sinif=4;
        
        ogrenci1.SınıfAtlat();

        Ogrenci ogrenci2= new Ogrenci();
        ogrenci2.Isim="Meltem";
        ogrenci2.Soyisim="Dağlaroğlu";
        ogrenci2.OkulNo=321;
        ogrenci2.Sinif=3;

        ogrenci2.SınıfDusur();

        Ogrenci ogrenci3= new Ogrenci("Aslı","Enver", 223,1);
        ogrenci3.SınıfDusur();

    }
}
class Ogrenci
{
    private string isim;
    private string soyisim;
    private int okulNo;
    private int sinif;

    
    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OkulNo { get => okulNo; set => okulNo = value; }
    public int Sinif 
    { 
        get => sinif; 
        set
        {
            if(value<1)
            {
                Console.WriteLine("sınıf 1 den küçük olamaz");
            }
            else
            sinif = value;
        }
    }

    public Ogrenci(string isim, string soyisim, int okulNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OkulNo = okulNo;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void ogrenciBilgileriniGetir()
    {
        Console.WriteLine("---ögrenci bilgileri---");
        Console.WriteLine("öğrenci adı      :{0}",this.Isim);
        Console.WriteLine("öğrenci soyadı   :{0}",this.Soyisim);
        Console.WriteLine("öğrenci no       :{0}",this.OkulNo);
        Console.WriteLine("öğrenci sınıfı   :{0}",this.Sinif);
    }

    public void SınıfAtlat()
    {
        this.Sinif=this.Sinif+1;
    }
    public void SınıfDusur()
    {
        this.Sinif=this.Sinif-1;
    }
}