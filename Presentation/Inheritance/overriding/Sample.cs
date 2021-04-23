using System;

namespace Presentation.Inheritance.overriding
{
    public class General
    {
        public virtual void Print()
        {
            Console.WriteLine(this.GetType());
        }
    }
    public class Concrete : General
    {
        public override void Print()
        {
            Console.WriteLine(this.GetType());
        }
    }
}
