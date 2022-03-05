int Coin_Head = 1;
Random random = new Random();
int coincheck = random.Next(0, 2);
if(coincheck == Coin_Head)
{
    Console.WriteLine("Coin is Head");

}
else
{
    Console.WriteLine("Coin is Tail");

}
