//4 - Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam 
//    eden bir program yazınız.(While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)

Random random = new Random();
int randomNumber = random.Next(1, 11);
bool guess = true;
while (guess)
{
    Console.WriteLine("1 ile 10 arasında tutulan sayıyı tahmin edin: ");
    string guessNumberStr = Console.ReadLine();
    if (Int32.TryParse(guessNumberStr, out int guessNumber) && (guessNumber <= 10 && guessNumber > 0))
    {
        if (randomNumber == guessNumber)
        {
            Console.WriteLine("Tebrikler!!! Sayıyı bildiniz.");
            Console.WriteLine("-----------------------------");
            guess = false;
        }
        else
        {
            Console.WriteLine("Henüz bilemediniz...");
            Console.WriteLine("--------------------");
        }
    }
    else
    {
        Console.WriteLine("Girilen sayı geçersiz.");
        Console.WriteLine("----------------------");
    }
}

