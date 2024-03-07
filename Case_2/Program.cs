//2 - kullanıcıdan kaç ürün almak istediğini soran, her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan 
//    bir algoritma yazınız.(Input için Scanner ve döngü için for döngüsü kullanınız)

int numberOfProducts;
double productsPrice = 0;
do
{
    Console.WriteLine("Almak istediğiniz ürün adedini girin: ");
    string numberOfProductsStr = Console.ReadLine();
    if (Int32.TryParse(numberOfProductsStr, out numberOfProducts) && numberOfProducts > 0)
    {
        for (int i = 1; i <= numberOfProducts; i++)
        {
            Console.WriteLine($"{i}. ürün fiyatını giriniz:");
            string unitPriceStr = Console.ReadLine();
            if (Double.TryParse(unitPriceStr, out double unitPrice) && unitPrice > 0)
            {
                productsPrice += unitPrice;
            }
            else
            {
                Console.WriteLine("Girilen ürün fiyatı geçersiz. 0'dan büyük bir fiyat girin.");
                Console.WriteLine("----------------------------------------------------------");
                i--;
            }
        }
        Console.WriteLine("Toplam ürün fiyatı: " + productsPrice);
    }
    else
    {
        Console.WriteLine("Adet sayısı geçersiz. 0'dan büyük bir sayı girin.");
        Console.WriteLine("-------------------------------------------------");
    }
}
while (numberOfProducts <= 0);

