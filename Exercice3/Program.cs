namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHM ihm = new IHM();
            ihm.InitialPrint();
            while (ihm.GameTurn())
            {
              // do nothing
            }
        }
    }
}