namespace Lab19_Strategy
{
    public class NoFly : IFly
    {
        public void Execute()
        {
            Console.WriteLine("Утка не летает");
        }
    }
}
