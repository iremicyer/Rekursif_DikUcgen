using System;

namespace DikUcgen_Rekursif
{
    class Program
    {
        public static int count = 0;
        public static int DikUcgen(int d)
        {
            var st = ""; 
            if (count == d)
            {
                return 0;
            }
            else
            {
               
                count++;
                for (int i = 0; i < count; i++)
                {
                    st += "*";
                }
                Console.Write(st);
                Console.WriteLine('\n');
                return DikUcgen(d);
            }

        }
        static void Main(string[] args)
        {


            string yildiz = "*";

            Console.Write("Lütfen yukseklik giriniz:");
            int yukseklik = Convert.ToInt32(Console.ReadLine());

            DikUcgen(yukseklik);
      
            Console.ReadKey();






        }
    }
}
