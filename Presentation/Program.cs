using Presentation.Anonymous_types;
using Presentation.Inheritance.overriding;
using Presentation.Methods;
using Presentation.Operator_overloading;
using Presentation.Value_types;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            General k = new Concrete();
            k.Print();

            var money = new Money(int.MaxValue, "USD");
            System.Console.WriteLine(money.GetType().IsValueType);

            System.Console.WriteLine(new Point(1, 1) == new Point(1, 1));

            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 1));

            var generator = new ReportGenerator(new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            var report = generator.Report();
            System.Console.WriteLine();
        }
    }
}
