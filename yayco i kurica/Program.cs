internal class Program
{
    static void Main(string[] args)
    {
        Thread chicken = new(MyThreadChicken);
        chicken.Start();
        for (int i = 0; i < 100; i++)
            Console.WriteLine("Курица");
        MyThreadAnswer(chicken);
    }
    static void MyThreadChicken()
    {
        for (int i = 0; i < 100; i++)
            Console.WriteLine("Яйцо");
    }
    static void MyThreadAnswer(Thread chicken)
    {

        bool ans = chicken.IsAlive;
        Console.WriteLine(ans ? "Победило Яйцо." : "Победила Курица.");
    }
}
