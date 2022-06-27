
internal class Program
{
    static void Main(string[] args)
    {

        string str = "     c# .net langue     ";

        Console.WriteLine(str);
        Console.WriteLine("-----------");
        Console.WriteLine(str.TrimStart());// baştaki boşlugu keser
        Console.WriteLine(str.TrimEnd());// sondaki boşlugu keser
        Console.WriteLine(str.Trim());// hem baştaki hem sondaki boşlugu temizler
        Console.WriteLine("------------");

        Console.WriteLine(str.Length);// kaç karakter oldugunu veriri
        Console.WriteLine(str.Trim().Length);
        Console.WriteLine(str.Replace("c#","vbasic.net"));//" içerisind e büyük küçük harfe duyarlı
        Console.WriteLine(str.IndexOf("."));//ilk . nın kaçıncı karakter oldugunu verir
        Console.WriteLine(str.Substring(9,3));// 9den başlayıp 3 kararkter al
        Console.WriteLine(str.ToUpper());
        Console.WriteLine(str.ToUpper().Trim());// uc uca eklenebilir
        Console.WriteLine(str.ToLower().Trim());





    }
}
