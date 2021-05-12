using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
          int x = 3;
          int y = 3;

          x = y + 2;

          Console.WriteLine(y);
          y += 2;
          Console.WriteLine(y);
          y /= 2;
          Console.WriteLine(y);
          y *= 2;
          Console.WriteLine(y);

          bool isSuccess = true;
          bool isCompleted = false;

          if (isSuccess && isCompleted)
          {
              Console.WriteLine("Perfect");
          }
          if (isSuccess || isCompleted)
          {
              Console.WriteLine("Great");
          }
          if (isSuccess && !isCompleted)
          {
              Console.WriteLine("Fine");
          }

          int a = 3;
          int b = 4;
          bool sonuc = a<b;

          Console.WriteLine(sonuc);
          sonuc = a>b;
          Console.WriteLine(sonuc);
          sonuc = a>=b;
          Console.WriteLine(sonuc);
          sonuc = a<=b;
          Console.WriteLine(sonuc);
          sonuc = a==b;
          Console.WriteLine(sonuc);
          sonuc = a!=b;

          int sayi1 = 10;
          int sayi2 = 5;
          int sonuc1 = sayi1/sayi2;
          Console.WriteLine(sonuc1);
          sonuc1 = sayi1*sayi2;
          Console.WriteLine(sonuc1);
          sonuc1 = sayi1+sayi2;
          Console.WriteLine(sonuc1);
          sonuc1 = sayi1++;

          int sonuc2 = 20%2;
          Console.WriteLine(sonuc2);
        }
    }
}
