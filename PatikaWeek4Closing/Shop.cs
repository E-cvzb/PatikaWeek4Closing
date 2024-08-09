using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Closing
{
    public abstract class BaseMakine //apstract ana sınıfımız 
    {
        string _name; //ortak olan değişkenlerimiz tanımlandı
        int _number;
        DateTime _datetime;
        string _system;
        string _ınfo;
        
       
        public string name { get; set; }
        public int number { get; set; }
        public string datetime { get; set; }
        public string system { get; set; }
        public string info { get; set; }
       


        public  void BaseInfo()//ortak olan değişkenlerden metot tanımlandı
        {
            Console.WriteLine("İsimini giriniz");
            name = Console.ReadLine();
            Console.WriteLine("Cihazın seri numarasını giriniz ");
            number =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cihazın sistem bilgilerini giriniz");
            system = Console.ReadLine();
            Console.WriteLine("Cihazın açıklamalarını giriniz");
            info = Console.ReadLine();

            DateTime dateTime = DateTime.Now;

            Console.WriteLine($"Merhabalar {name} isimli {number} seri numaralı {system} sistemine sahip {info} özellikelrine sahip cihazınız {dateTime} tarihinde kayıt edilmiştir");

        }
        public virtual void NameCalling()//otak olana ve override edilecek metot
        {

        }
    }
    public class Phone : BaseMakine  
    {
        bool _licance; //phone telefonuna ait değişken tanımlama 
        public bool licance { get; set; } 
        
         void BaseInfo() //phone sınıfı basemakine sınıfından miras aldığı metot
        {
            
            
        }
       
        public void TrLicance() 
        {
            Console.WriteLine("Cihazınızda Türkiye lisansı bulunuyor mu? (true ya da false cevap veriniz)");

            licance =Convert.ToBoolean(Console.ReadLine()); // lisans kontrolü yapan blooen 
            if (licance==true)
                Console.WriteLine("Cihazınız TR lisansına sahiptir");
            else
                Console.WriteLine("Cihazınız lisansa sahip değildir");
        }
        public override void NameCalling() //metot override ediledek özelleştirildi
        {
            Console.WriteLine("Telefonunuzun isimi -------> " +name);
        }
    }
    public class Computer : BaseMakine
    {
        bool _bluetooth;
        int _usbNumber;
        public bool bluetooth { get; set; }
        public int usbNumber// encapsulation işlemi yaparak değerleri kontrol etme 
        {
            get
            {
                return _usbNumber;
            }
            set// yazılan değerin 2 veya 4 olmasını isteyen if ile kotrolü sağlanır istenen koşulun dışındakilere -1 değeri atanır
            {
                _usbNumber = value;
                if (value == 4 || value == 2)
                    Console.WriteLine(value + "  adet usb sayısı eklendi");
                else
                    Console.WriteLine("Geçeriz sayı girişi");


            }
        }

        void BaseInfo()
        {
           
        }
        public void Control()
        {
            Console.WriteLine("Cihazın usb giriş sayısını belirleyiniz");
            usbNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cihazda bluetooth bulunuyır mu (true ya da false değeri giriniz))");
            bluetooth = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(bluetooth? "Cihaznınızda bluetooth bulunuyor" :"Cihazınızda bluetooth bulunmuyor");
            
        }
        public override void NameCalling()
        {
            Console.WriteLine("Bilgisayarınızn isimi ----------> " +name );
        }
    }
 }

