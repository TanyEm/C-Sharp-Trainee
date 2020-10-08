using System;
namespace C_Sharp_Trainee
{
    public class FirstClass
    {
        public void AAA()
        {
            Console.WriteLine("FirstClass AAA");
        }

        public virtual void BBB()
        {
            Console.WriteLine("FirstClass BBB");
        }

        public virtual void CCC()
        {
            Console.WriteLine("FirstClass CCC");
        }

        public virtual void XXX()
        {
            Console.WriteLine("FirstClass XXX");
        }
    }

    public class SecondClass : FirstClass
    {
        public virtual void AAA()
        {
            Console.WriteLine("SecondClass AAA");
        }

        public new void BBB()
        {
            Console.WriteLine("SecondClass BBB");
        }

        public override void CCC()
        {
            Console.WriteLine("SecondClass CCC");
        }

        public override void XXX()
        {
            base.XXX();
            Console.WriteLine("SecondClass XXX");
        }
    }

    public class ThirdClass : SecondClass
    {
        public override void AAA()
        {
            Console.WriteLine("ThirdClass AAA");
        }

        public void CCC()
        {
            Console.WriteLine("ThirdClass CCC");
        }

        public override void XXX()
        {
            base.XXX();
            Console.WriteLine("ThirdClass XXX");
        }
    }
}
