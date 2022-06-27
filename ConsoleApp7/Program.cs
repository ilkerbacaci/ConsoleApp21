
internal class Program
{


    static void Main(string[] args)
    {

        // string vagon demektir// string char array dir aslında
        string yazi = "Csharp temel DERS bitti";
        yazi = "kadıköy  / istanbul-türkiye";// bu kelimeyi saydırmak ödev
        Console.WriteLine(yazi);
        Console.WriteLine("------------");
        //Console.WriteLine(yazi.Length);
        int kelimesay = 1;

        for (int i = 1; i < yazi.Length; i++)// karakterleri tek tek yazdırmak
        {

            

            if (yazi[i-1]!=' '&&yazi[i]==' ')// soru kolaylaştırmalı// replace il eyapsak
            {
                kelimesay++;

            }





         /*   if (yazi[i]==' ')// char oldugu için ''// string bir char array dir 
            {


                kelimesay++;

            }*/

           
        }
        Console.WriteLine(kelimesay);






    }
}