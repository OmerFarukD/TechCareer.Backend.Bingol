//Console.WriteLine("Bugün bingöl eğitiminin ilk günü.");
//Console.WriteLine("Bu benim 2. Satırım");
//Console.WriteLine(4+85);

//// Bu bir uyarı mesajıdır.

//// string
//string ad = "Ömer";

//string soyisim = "Doğan";

//Console.WriteLine(ad);
//Console.WriteLine(soyisim);

//string tam_ad = ad+" "+ soyisim;
//Console.WriteLine(tam_ad);

//// int : tam sayı değerlerini tuttuğumuz bir veri tipidir.
//int sayi = 158;
//Console.WriteLine(sayi);

//// double : ondalıklı sayıları tuttuğumuz veri tipidir.
//double ondalik = 10.3;
//Console.WriteLine(ondalik);

//// float : ondalıklı sayılar tutar 
//float ondalik1 = 15.56f;
//Console.WriteLine(ondalik1);

//// char : tek karakter tutan bir veri tipidir.
//char a = 'A';
//Console.WriteLine((int)a);

// Konsol dan girdi alma 
// kullanıcıdan isim ve soyisim alarak ekrana bastırın.4
//Console.WriteLine("Lütfen adınızı giriniz :");
//string isim = Console.ReadLine();

//Console.WriteLine("Lütfen Soyadınızı giriniz: ");
//string soyad= Console.ReadLine();
//// 1. Yöntem
//Console.WriteLine("isim : "+isim+" soyisim : "+soyad);

////2. Yöntem String interpolation

//Console.WriteLine($"isim : {isim}, soyisim : {soyad}");

//Console.WriteLine("Lütfen yaşınızı giriniz");
//var yas = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(yas.GetType());
//Console.WriteLine(yas);

// Aritmetik operatörler : 
//Console.WriteLine("1. tam sayıyı giriniz");
//int tam1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2. tam sayıyı giriniz");
//int tam2 = Convert.ToInt32(Console.ReadLine());

//int tam_toplam = tam1 + tam2;
//int tam_fark = tam1 - tam2;
//int tam_bolme = tam1 / tam2;
//int tam_carpma = tam1 * tam2;
////Console.WriteLine("sayıların toplamı "+ tam1+"+"+tam2+"= "+tam_toplam);
//Console.WriteLine("1. Sayı : "+tam1);
//Console.WriteLine("2. Sayı : " + tam2);

//Console.WriteLine("2 sayının toplamı :"+tam_toplam);
//Console.WriteLine("2 sayının farkı :" + tam_fark);
//Console.WriteLine($"2 sayının çarpımı : {tam_carpma}");
//Console.WriteLine($"2 sayının bölümü : {tam_bolme}");

// Karşılaştırma operatörleri
Console.WriteLine();


// == eşit midir
// != eşit değil midir
// < küçük müdür
// > büyük müdür
// >= büyük eşit midir
// <= küçük eşit midir

bool dogruluk1 = 4 != 5;
bool dogru = true;
bool yanlis = false;
Console.WriteLine(dogru);
Console.WriteLine(yanlis);
Console.WriteLine(dogruluk1);

// Mantıksal operatörler 

// || or (veya) iki koşuldan biri sağlanıyorsa True döndürür
//  && and (ve) her iki koşulun sağlanması durumunda çalışır.


bool islem1 = (3 < 5) && (6 < 5);
//             Doğru  ve Yanlış = Yanlış
//               1     *    0   

bool islem2 = (3 < 5) || (6 < 5);
//             Doğru veya Yanlış = 1
//               1    +     0 =    1
Console.WriteLine(islem1);
Console.WriteLine(islem2);

// yaşı 18 den büyük ve eşit olan ve parası 500.00 den fazla olan kişi araba alabilir

//int age = 17;
//int money = 600000;
//if (age>=18 && money > 500000)
//{
//    Console.WriteLine("Bu kişi araba alabilir.");
//}
//else
//{
//    Console.WriteLine("Bu kişi araba alamaz");
//}

// Kullanıcıdan ders notu aldığımızda harf notunu ekrana bastırsın
// not<50 f
// 50<not<65 d
// 65<not<70 c
// 70<not<80 b
// 80<not90  a
// 90<not<100 s

//Console.WriteLine("Lütfen notunuzu giriniz :");

//int not = Convert.ToInt32(Console.ReadLine());

//if (not > 0 && not < 50)
//{
//    Console.WriteLine("Harf Notunuz F");
//}
//else if (not >= 50 && not < 65)
//{
//    Console.WriteLine("Harf Notunuz D");
//}
//else if (not >= 65 && not <= 70)
//{
//    Console.WriteLine("Harf Notunuz C");
//}
//else if (not > 70 && not <= 80)
//{
//    Console.WriteLine("Harf Notunuz B");
//}
//else if (not > 80 && not <= 90)
//{
//    Console.WriteLine("Harf Notunuz A");
//}
//else if (not > 90 && not <= 100)
//{
//    Console.WriteLine("Harf Notunuz S");
//}
//else
//{
//    Console.WriteLine("Yanlış karakter girdiniz.");
//}
// Fonksiyonlar (metodlar)


//MerhabaDe();
//MerhabaDe();

//Console.WriteLine("Lütfen isminizi giriniz :");
//string isim = Console.ReadLine();

//Console.WriteLine("Lütfen soyadınızı giriniz :");
//string soyisim = Console.ReadLine();

//Console.WriteLine("Lütfen yaşınızı giriniz :");
//int yas = Convert.ToInt32(Console.ReadLine());



//IsimYaz(isim,soyisim,yas);
//IsimYaz(surname:soyisim, name: isim, age: yas);

int toplam = Topla(3,4);
Console.WriteLine(toplam);

Console.WriteLine(Cikar(3,15));





void MerhabaDe()
{
    Console.WriteLine("Merhaba");
}

// Parametre alan ama değer döndürmeyen metodlar.
void IsimYaz(string name, string surname, int age)
{
    Console.WriteLine("İsminiz : "+name+" soyad: "+surname+" yaş :"+age);
}

// Toplama ve çıkarma işlemlerinin fonskiyonlarını yazınız.

int Topla(int sayi1,int sayi2)
{
    return sayi1 + sayi2;
}
int Cikar(int sayi1, int sayi2)
{
    return sayi1- sayi2;
}



























