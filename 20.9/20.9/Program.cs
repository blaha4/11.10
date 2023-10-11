namespace _20._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zlomek a = Zlomek.create(2, 1);
            Zlomek b = Zlomek.create(10, -2);
            Zlomek.scitani(a, b);
            Console.WriteLine(a.ToString());
            int nejvetsidelitel =Zlomek.DelitelBeta(a);
            Console.WriteLine(nejvetsidelitel);
        }
    }
}