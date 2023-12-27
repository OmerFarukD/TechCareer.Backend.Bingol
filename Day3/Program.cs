// collections
// Arraylar

// 1 den 9 a kadar tüm sayıların tutulduğu arrayi yazınız.

//int[] sayilar = {1,2,3,4,5,6,7,8,9 };
////               0 1 2 3 4 5 6 7 8
//Console.WriteLine("Sayılar dizisinin elamanı kaç tanedir: "+sayilar.Length);

//// Döngüler 
////for (int i=0; i<sayilar.Length; i++)
////{
////    Console.WriteLine(sayilar[i]);
////}

//foreach (int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}

//string[] en_guzel_yemekler = {"Kavurma","Mastuva","Çirvila","Kebap","Etli Ekmek" };
//string[] en_lezzetsiz_yemekler = { "Salçalı tost","Bingöl de yapılan yemekler","Ayran Sarması","Mumbar"};

//// En güzel yemeklerin listesi 
////En güzel yemeklerden indexi 3 olan yemek
//foreach (string yemek in en_guzel_yemekler)
//{
//    Console.WriteLine(yemek);
//}

//Console.WriteLine(en_guzel_yemekler[3]);

//// En lezzetsiz yemeklerin listesi 
////En lezzetsiz yemeklerden indexi 2 olan yemek

//foreach (string yemek in en_lezzetsiz_yemekler)
//{
//    Console.WriteLine(yemek);
//}
//Console.WriteLine(en_lezzetsiz_yemekler[2]);

List<string> sehirler = new List<string>()
{
    "Malatya","Bingöl","Elazığ","Tunceli"
};

sehirler.Add("Ankara");
sehirler.Add("İzmir");
sehirler.Add("İstanbul");
sehirler.Remove("İstanbul");
Console.WriteLine("Şehirler listesi kaç elemanlıdır : "+sehirler.Count);
foreach (string x in sehirler)
{
    Console.WriteLine(x);
}

// Kullanıcı dan kaç adet şehir girmek istediğini alınız ve şehirleri en son ekrana bastırınız

List<string> cities = new List<string>();
//Console.WriteLine("Kaç tane şehir girmek istersiniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//for (int i=0;i<sayi;i++)
//{
//    Console.WriteLine($"Lütfen {i+1}. şehri giriniz");
//    string sehir = Console.ReadLine();
//    cities.Add(sehir);
//}
Console.WriteLine("**********************************************");
//foreach (string sehir in cities)
//{
//    Console.WriteLine(sehir);
//}
//cities.ForEach(sehir=> Console.WriteLine(sehir));

// Elimizde 1 den 10 a kadar bir sayı listesi olsun
// Bu sayı listesinden 2 tane daha liste çıkararak
// Tek sayılar ve çift sayılar listesini oluşturup ekrana bastırınız.
List<int> sayilar = new List<int>();
for (int i =1; i<=10;i++)
{
    sayilar.Add(i);
}

List<int> tek_sayilar = new List<int>();
List<int> cift_sayilar = new List<int>();
//foreach (int sayı in sayilar)
//{
//    if (sayı % 2==0)
//    {
//        cift_sayilar.Add(sayı);
//    }
//    else
//    {
//        tek_sayilar.Add(sayı);
//    }


//}
//Console.WriteLine("Tek sayılar");
//for (int i=0;i<tek_sayilar.Count;i++)
//{
//    Console.WriteLine(tek_sayilar[i]);
//}

//Console.WriteLine("Çift sayılar");
//foreach (int sayi in cift_sayilar)
//{
//    Console.WriteLine(sayi);
//}

//2. Yöntem
Console.WriteLine("Tek sayılar");
sayilar.FindAll(x=> x%2==1).ForEach(y=>Console.WriteLine(y));
Console.WriteLine("Çift sayılar: ");
sayilar.FindAll(c=> c%2==0).ForEach(y=>Console.WriteLine(y));


















//List<string> sehirler1 = new();
//var sehirler2 = new List<string>();


