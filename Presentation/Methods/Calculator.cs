namespace Presentation.Methods
{
    public class Calculator
    {
        public delegate int Adder(int a, int b);
        public Adder Add { get; }

        public Calculator()
        {
            Add = delegate (int a, int b)
            {
                return a + b;
            };
        }
    }
}
