namespace Lab19_Strategy
{
    public abstract class Duck
    {
        protected IFly _fly;
        protected IQuack _quack;
        protected ISwim _swim;

        protected Duck(IFly fly, IQuack quack, ISwim swim)
        {
            _fly = fly;
            _quack = quack;
            _swim = swim;
        }

        public abstract void Fly();
        public abstract void Quack();
        public abstract void Swim();
    }
}
