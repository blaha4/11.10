namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kruh kruh = new Kruh(15);
            MyMethod();
            DruhaMetoda();
            DalsiMetoda();
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            double x = 0;
            for (int i = 0; i <= 10; i++) {
                x = i * 0.1;
                Console.WriteLine(Math.Round(x, 1));
            }
            

            static void MyMethod()
            {
                Console.WriteLine("Zadejte cislo");
                int age = Convert.ToInt32(Console.ReadLine());
                int second = age * 60;
                Console.WriteLine(age +" minut(y) je " +second+ " vterin");
            }

            static void DruhaMetoda()
            {
                Console.WriteLine("Zadejte cislo");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                Console.WriteLine("soucet je "+sum);
            }

            static void DalsiMetoda()
            {
                Console.WriteLine("Zadejte cislo:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (IsPrime(number))
                {
                    Console.WriteLine("je prvocislo");
                }
                else
                {
                    Console.WriteLine("neni prvocislo");
                }
            }
             static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0)
                        return false;

                return true;
            }





        }
    }
}