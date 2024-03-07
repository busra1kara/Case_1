//5- Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

int givenNumber = 0;
int perfectNumber = 0;
do
{
    Console.WriteLine("Mükemmel sayı kontrolü için bir sayı girin: ");
    string givenNumberStr = Console.ReadLine();
    if (Int32.TryParse(givenNumberStr, out givenNumber))
    {
        //Sayının kendisi kendisine zaten bölüneceği için i <= givenNumber'a ve givenNumber'ı 2 ile çarpmaya da
        //gerek kalmayacaktır. 
        for (int i = 1; i <= givenNumber / 2; i++)
        {
            if (givenNumber % i == 0)
            {
                perfectNumber += i;
            }
        }
        //Sayının kendisi hariç pozitif tam sayı bölenleri toplamının sayının kendisini vermesi gerekir.
        if (perfectNumber == givenNumber && perfectNumber != 0)
        {
            Console.WriteLine(givenNumber + " mükemmel sayıdır");
        }
        else
        {
            Console.WriteLine(givenNumber + " mükemmel sayı değildir");
        }
    }
    else
    {
        Console.WriteLine("Girilen sayı geçersiz");
        Console.WriteLine("---------------------");
    }
}
while (givenNumber == 0);

