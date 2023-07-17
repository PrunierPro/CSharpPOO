namespace Exercice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterTank.ResetTankAmount();
            WaterTank tank1 = new WaterTank();
            WaterTank tank2 = new WaterTank(10, 20, 5);
            tank1.ShowWeight();
            tank2.ShowWeight();
            Console.WriteLine("-----------------------------------------------------");
            tank1.ShowFillLevel();
            tank2.ShowFillLevel();
            WaterTank.ShowTotalVolume();
            Console.WriteLine("-----------------------------------------------------");
            tank1.Fill(11);
            tank2.Empty(11);
            Console.WriteLine("-----------------------------------------------------");
            tank1.ShowFillLevel();
            tank2.ShowFillLevel();
            WaterTank.ShowTotalVolume();
        }
    }
}