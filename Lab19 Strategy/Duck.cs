namespace Lab19_Strategy
{
    public abstract class Duck
    {
        private IFly _fly { get; set; }
        private IQuack _quack { get; set; }
        private ISwim _swim { get; set; }

        protected Duck(IFly fly, IQuack quack, ISwim swim)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
        }

        public void Quack()
        {
            _quack.Execute();
        }

        public void Fly()
        {
            _fly.Execute();
        }

        public void Swim()
        {
            _swim.Execute();
        }
    }
}
