namespace string_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp. Hoşgeldiniz.";
            string degisken1 = "Dersimiz CSharp. ";

            //Lenght

            Console.WriteLine(degisken.Length);

            //ToUpper   ToLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken1));

            //true'da büyük küçük harfe duyarsızdır. false de ise duyarlıdır.
            Console.WriteLine(String.Compare(degisken,degisken1,true));
            Console.WriteLine(String.Compare(degisken, degisken1, false));

            //Contains(içeriyor mu ?)
            Console.WriteLine(degisken.Contains(degisken1));

            //IndexOf (kaçıncı sıradan başladıgıını oldugunu gösterir)
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Mehmet"));

            //Insert (silme işlemi)
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);
             


        }


    }
}