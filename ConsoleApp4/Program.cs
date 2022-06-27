
internal class Program
{

    static void swap(ref int num1,ref int num2)// burada degişkenin kendi(adresini) gönderiliyor içerigi degil
    {

        int temp = num2;
        num2 = num1;
        num1 = temp;



    }


    static void Main(string[] args)
    {
        int sayi1, sayi2;
        sayi1 = 5;
        sayi2 = 10;
        Console.WriteLine(sayi1);
        Console.WriteLine(sayi2);
        swap(ref sayi1, ref sayi2); 


        Console.WriteLine(sayi2+"-"+sayi1);






    }
}