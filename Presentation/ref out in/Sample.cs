using System;

namespace Presentation.ref_out_in
{
    public class Sample
    {
        public void Do(string k)
        {
            k = "sss";
        }
        public static int Increment(ref int n)
        {
            return n += 1;
        }
        int n;
        public static void Random(out int n)
        {
            n = new Random().Next();
        }

        public static bool IsEven(in int n)
        {
            return n % 2 == 0;
        }
    }
}
