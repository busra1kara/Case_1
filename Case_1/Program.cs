//1 - Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen 
//algoritma yazınız.Input için Scanner kullanınız.

int productNumber = 0;
do
{
    Console.Write("Lütfen sipariş numarası girin: ");
    string productNumberStr = Console.ReadLine();
    if (Int32.TryParse(productNumberStr, out productNumber) && productNumber > 0)
    {
        switch (productNumber)
        {
            case 1:
                Console.WriteLine("Sipariş verilen ürün: Koltuk");
                break;
            case 2:
                Console.WriteLine("Sipariş verilen ürün: Kanepe");
                break;
            case 3:
                Console.WriteLine("Sipariş verilen ürün: Masa");
                break;
            case 4:
                Console.WriteLine("Sipariş verilen ürün: Sehpa");
                break;
            case 5:
                Console.WriteLine("Sipariş verilen ürün: Sandalye");
                break;
            default:
                Console.WriteLine("Ürün bulunamadı");
                Console.WriteLine("---------------");
                continue;
        }
    }
    else
    {
        Console.WriteLine("Sipariş numarası geçersiz. 1 ile 5 arasında bir değer girin.");
        Console.WriteLine("------------------------------------------------------------");
    }
}
while (!(productNumber > 0 && productNumber <= 5));


