namespace Lab19_Strategy
{
    public class RobotDuck : Duck
    {
        public RobotDuck()
            : base(new ReactivFly(), new Quack(), new NoSwim()) { }
    }
}
