namespace Presentation.Initializers
{
    public class Person
    {
        public string FullName { get; set; }
        public string[] PhoneNumbers { get; set; }

        public static Person Mock()
        {
            return new Person()
            {
                FullName = "Zura Kavtaradze",
                PhoneNumbers = new string[] { "595217977", "571117532" }
            };
        }
    }
}
