namespace Lab19_Strategy
{
    public abstract class Duck
    {
        private IFly _fly;
        private IQuack _quack;
        private ISwim _swim;

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
