namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Zdravic zdravic = new Zdravic();
            zdravic.text = "Ahoj uživateli";
            Console.WriteLine(zdravic.Pozdrav("Karel"));
            Console.WriteLine(zdravic.Pozdrav("Petr"));
            zdravic.text = "Vítám tě tu programátore";
            Console.WriteLine(zdravic.Pozdrav("Vít"));
            Console.ReadKey();
        }
    }
}
