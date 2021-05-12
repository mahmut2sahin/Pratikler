using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;
            sbyte c = 5;

            short abv = 5;
            ushort asx = 5;;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 a = 2;

            uint ui = 2;
            long l = 2;
            ulong ul = 2;

            double fo = 2.7;
            float br = 21.1f;
            Console.WriteLine(br);

            char ch = 'a';
            string str = "Mahmut";

            bool b1 = false;
            bool b2 = true;
            
            DateTime dt = DateTime.Now;

            object o1 = "Sahin";

            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime);
    }
  }
}