﻿namespace Lab19_Strategy
{
    public class WildDuck : Duck
    {
        public WildDuck()
            : base(new Fly(), new Quack(), new Swim()) { }
    }
}
