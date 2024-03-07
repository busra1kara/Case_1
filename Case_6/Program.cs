//6- String metotlarını araştırınız. Her bir metot için örnek yapınız.

//En Çok Kullanılan String Metotları

//Clone metodu bir string değişken değerini başka bir string değişken için kopyalayarak atama yapar.
string text = "Tarihte neler oldu?";
string textClone = (string)text.Clone();
Console.WriteLine(textClone);

//Contains metodu değişken içerisinde belirtilen karakter veya metnin olup olmadığını kontrol eder. Varsa true,
//yoksa false olarak boolean değer döndürür. 
Console.WriteLine(text.Contains(textClone));
Console.WriteLine(textClone.Contains('e'));

//IndexOf metodu, metoda verilen karakteri string değişken içinde arar ve metin içinde bulunduğu konumun index
//numarasını verir. Karakter veya ifadeden birden fazla varsa ilk bulduğu index numarasını verir.
Console.WriteLine(text.IndexOf('e'));

//ToLower metodu string değişken içerisindeki tüm ifadeyi küçük harfle yazdırır.
Console.WriteLine(text.ToLower());

//ToUpper metodu string değişken içerisindeki tüm ifadeyi büyük harfle yazdırır.
Console.WriteLine(text.ToUpper());

//Insert metodu iki parametre alır. İlk parametre metne eklenecek yeni string ifadenin hangi index numarasından
//itibaren eklenceğini belirtir. İkinci parametre ise eklenecek olan string ifadedir.
Console.WriteLine(textClone.Insert(19, " Gordon Childe"));

//Remove metodu string ifadeden silinmek istenen kısmı kaldırır. Belirlenen indexten sonra tüm metni sileceği gibi
//index aralığı belirtilerek index numaraları arasında kalan kısmı da silebilir.
Console.WriteLine(textClone.Remove(12));
Console.WriteLine(textClone.Remove(3, 5)); //Üçüncü indexten başlayarak beş karakter siler.

//Replace metodu string içindeki metoda parametre olarak belirtilen ifadenin başka bir ifadeyle değiştirilmesini sağlar.
Console.WriteLine(text.Replace("Tarihte", "Neler"));

//Split metodu metin içerisinde belirtilen karaktere göre metne bölme işlemi yapar. Sonuç dizi şeklinde döneceği
//için metot sonucunu bir diziye aktarırız.
string textSplit = "Tarihte,Neler,Oldu";
string[] textDizi = textSplit.Split(',');
for (int i = 0; i < textDizi.Length; i++)
{
    Console.WriteLine(textDizi[i]);
}

//Trim metodu string metin içerisinde metnin başında veya sonunda boşluk varsa onları kaldırır.
string textTrim = "    Tarihte Neler Oldu?     ";
Console.WriteLine(textTrim.Trim());

//Length metodu metnin uzunluğunu yani içerdiği karakter sayısını verir. Bu metot boşlukları da sayar.
Console.WriteLine(text.Length);
