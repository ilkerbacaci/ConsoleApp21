
internal class Program
{


    static void Main(string[] args)
    {

        string girilen;
          girilen = Console.ReadLine();
        
        bool iscorrect=int.TryParse(girilen, out int sonuc);//deger in int e çevirilip cevrilmedigini kontrol ediyor

        if (iscorrect)
        {
            Console.WriteLine("girilen sayi="+sonuc);



        }
        else
        {
            Console.WriteLine("yanlış giriş");
        }





    }
}