//7- kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı, öğrenci soyadı,1.sınav notu,2.sınav notu,
//3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.
//(For döngüsü kullanınız)

int ogrenciSayisi;
do
{
    Console.Write("Not ortalaması hesaplanmak istenen öğrenci sayısını girin");
    string ogrenciSayisiStr = Console.ReadLine();
    if (Int32.TryParse(ogrenciSayisiStr, out ogrenciSayisi) && ogrenciSayisi > 0)
    {
        for (int i = 1; i <= ogrenciSayisi; i++)
        {
            Console.WriteLine($"{i}. Öğrencinin Adı: ");
            string ogrenciAdi = Console.ReadLine();
            Console.WriteLine($"{i}. Öğrencinin Soyadı: ");
            string soyAdi = Console.ReadLine();

            int[] sinavNotlari = new int[3];
            int sinavNotu;
            for (int j = 0; j < 3; j++)
            {
                do
                {

                    Console.WriteLine($"{j + 1}. Sınav Notunu Giriniz");
                    string sinavNotuStr = Console.ReadLine();
                    if (Int32.TryParse(sinavNotuStr, out sinavNotu) && sinavNotu >= 0)
                    {
                        sinavNotlari[j] = sinavNotu;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Girilen sınav notu geçersiz.");
                        Console.WriteLine("----------------------------");
                    }
                }
                while (true);
            }

            int sinavOrt = (sinavNotlari[0] + sinavNotlari[1] + sinavNotlari[2]) / 3;
            Console.WriteLine($"{ogrenciAdi} {soyAdi}'in sınav ortalaması: {sinavOrt}");
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
    else
    {
        Console.WriteLine("Girilen öğrenci sayısı geçersiz");
        Console.WriteLine("-------------------------------");
    }
}
while (ogrenciSayisi <= 0);

