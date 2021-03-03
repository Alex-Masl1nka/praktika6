using System;

namespace Практика6
{
    class Program
    {
        delegate void Hell();
        delegate int Mather( int x, int y);
        public static void Eng()
        {
            Console.WriteLine("Hello!");
        }
        public static void Ger()
        {
            Console.WriteLine("Hallo");
        }
        public static void Rus()
        {
            Console.WriteLine("Привет");
        }
        public static void Jap()
        {
            Console.WriteLine("Kon'nichiwa");
        }

        public static void Input(ref int x, ref int y)
        {
            string str = Console.ReadLine();
            string[] mas = str.Split(" ");
            x = int.Parse(mas[0]);
            y = int.Parse(mas[1]);
        }

        static void Main(string[] args)
        {
            int x=0, y=0;
            Hell pr = Rus;
            Mather mth /*= Input*/;
            pr += Eng;
            pr += Ger;
            pr += Jap;
            pr();
            mth = (int a, int b) => a + b;
            mth = (int a, int b) => a * b;
            Console.WriteLine(mth(1,3));
        }
    }
}
