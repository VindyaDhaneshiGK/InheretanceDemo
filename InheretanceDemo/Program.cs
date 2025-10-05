namespace InheretanceDemo
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Spa mySpa = new Spa(5, 10, 20);
            Console.WriteLine("Hello, World!");
            mySpa.chlorineLevel = 7;
            mySpa.waterLevel = 15;
            mySpa.heatLevel = 25;
            mySpa.PoolInfo();
            mySpa.SpaInfo();
            Console.ReadLine(); 
        }
    }
}
