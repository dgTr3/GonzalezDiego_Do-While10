Console.WriteLine("Del 1 al 50");
int i = 1;
int conta = 0;
do
{
   if (i % 2 == 0) {
        Console.WriteLine(i);
        conta++;
    }
    i++;
} while (i <= 50);
Console.WriteLine("Cantidad de números: " + conta);