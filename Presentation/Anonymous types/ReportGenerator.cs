using System.Collections.Generic;
using System.Linq;

namespace Presentation.Anonymous_types
{
    public class ReportGenerator
    {
        public List<int> Data { get; }
        public ReportGenerator(List<int> data)
        {
            Data = data;
        }

        public object Report()
        {
            return new
            {
                Total = Data.Sum(),
                Average = Data.Average(),
                Minimum = Data.Min(),
                Maximum = Data.Max()
            };
        }
    }
}
