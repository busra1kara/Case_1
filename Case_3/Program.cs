//3 - Do - While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//for ve while döngülerinde koşul döngüye girmeden kontrol edilirken do-while döngüsünde koşul döngüye girildikten
//    sonra kontrol edilir. Koşul sağlanmıyor olsa bile döngü en az bir kez çalıştırılır.
int sayiDo = 0;
do
{
    sayiDo++;
}
while (sayiDo < 11); /*sayi değişkeni 11 olduğunda da bir kez çalışır. 11 olarak çıktıktan sonra döngü sonlanır. */

//while döngüsü for döngüsüyle benzerdir. while genellikle döngünün ne zaman biteceğinin değişekenin durumuna
//bağlı olduğu biraz belirsiz durumlarda kullanılırken for koşulun daha net olduğu durumlarda kullanılır.

//while(sayi > 0)
//{
//    sayi++;
//}    Sonsuz döngü gerçekleşir.

while (sayiDo < 10)
{
    sayiDo++;
};
