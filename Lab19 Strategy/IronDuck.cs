namespace Lab19_Strategy
{
    public class IronDuck : Duck
    {
        public IronDuck()
            : base(new NoFly(), new NoQuack(), new NoSwim()) { }

        public override void Quack()
        {
            _quack.Execute();
        }

        public override void Fly()
        {
            _fly.Execute();
        }

        public override void Swim()
        {
            _swim.Execute();
        }
    }
}
