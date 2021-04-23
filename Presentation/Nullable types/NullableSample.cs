using System;

namespace Presentation.Nullable_types
{
    public class NullableSample
    {
        public Nullable<int> min = null;
        public int? max = null;

        public NullableSample(int? n1, int? n2)
        {
            min = n1;
            max = n2;
        }
    }
}
