namespace Presentation.Value_types
{
    public struct Money
    {
        public int Amount { get; set; }
        public string Currenct { get; set; }
        public Money(int a, string c)
        {
            Amount = a;
            Currenct = c;
        }
    }
}
