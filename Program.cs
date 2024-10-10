
// .net içerisinde kaç türlü hata vardır : 

/*
1 : Derleme zamananı hatası
2 : Çalışma zamanı hatası
*/

// Çalışma zamanı hatası : Çalışma zamanı hatası, yazılım içerisinde bir mantık hatası yapıldığında, 
// yada veri kaynakların gelen verilerin düzgün kontrol edilmemesinden, yada bazı değişkenlerin vb. null kontrollerinin yapılmamış olmasından kaynaklanır
// bir uygulamanın çalışma zamanı hatası vermesi, uygulamayı kullanan müşteri açısından oldukça kötü bir durumdur

// Bu derste, çalışma zamanı hatalarının nasıl kontrol altına alınacağını inceleyeceğiz.

// hata yönetimi 
// snytax 
/*

try
{
    Hata olması muhtemel kod blokları try içerisinde yazılır
    // try içerisindeki kod bloklarında, her hangi bir çalışma zamanı hatası olursa,
    // Catch bloğunun içerisindeki kodlar çalıştırılır

}
catch(Exception ex){
    // try bloğu içerisinde yazılı olan kod bloklarında bir çalışma zamanı hatası meydana gelirse, 
    // derleyici otomatik olarak Catch bloğu içerisinde gelir
    
}

*/

// Örnek : Sıfıra bölünme esnasında hata meydana gelecek biz bu hatayı try ve catch blokları ile yakalayalım



try
{
    // sıfır'a bölünmeme kuralı olduğu için, sayi2 değerine sıfır değer verilirse, bu kod bloğunda hata meydana gelecek
    Console.WriteLine("1 sayıyı giriniz");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2. sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    int sonuc = sayi1 / sayi2;
    Console.WriteLine(sonuc);

    // biz tüm kodları try blokları içerisinde yazsak ne olur
    // Cevap : Try blokları derleyici tarafından daha yavaş şekilde işletildiği için
    // tüm yazılımı try blokları içerisinde koymak performans açısından mantıklı değil
    

}
catch
{

    Console.WriteLine("Bir şekilde hata meydana geldi");

}
for(int i =0;i<10000;i++){

    Console.WriteLine(i);
  
}


