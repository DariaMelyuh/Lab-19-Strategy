namespace Lab19_Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new NoFly(), new Quack(), new Swim()) { }
    }
}
