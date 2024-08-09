
using PatikaWeek4Closing;
start:
Console.WriteLine("Telefon üretmek için 1 bilgisayar üretmek için 2 sayılarını tuşlayınız");
int enter=Convert.ToInt32(Console.ReadLine());

if (enter == 1)
    EnterPhone();
else if (enter == 2)
    EnterComputer();
else
{
    Console.WriteLine("Yanlış giriş yaptınız");
    goto start;
}

Console.WriteLine("Ürününüz başarı ile üretilmiştir başka ürün üretmek istiyorsanız evet yazızınız.");
string startOver=Console.ReadLine().ToLower();
if (startOver == "evet")
    goto start;
else Console.WriteLine("İyi günler bizi tercih ettiğiniz için teşekkür ederiz");

void EnterComputer()
{
    Computer computer =new Computer();

    computer.BaseInfo();
    computer.Control();
    computer.NameCalling();
}

void EnterPhone()
{
    Phone phone = new Phone(); 
    phone.BaseInfo();
    phone.TrLicance();
    phone.NameCalling();
}