
internal class Program
{
    static bool pozitifmi( string girilen , out int sayi)
    {

        sayi = int.Parse(girilen);


        if (sayi<0)
        {




            return false;

        }
        if (sayi>0)
        {



            return true;
        }




    }


    static void Main(string[] args)
    {
        string girilensayi="5";
        bool pozitif = pozitifmi(girilensayi, out int sayi);
        Console.WriteLine(pozitif);
        Console.WriteLine(sayi);






    }
}