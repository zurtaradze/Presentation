using System.Linq;

namespace Presentation.LINQ
{
    public class Linq
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int[] EvensOnly()
        {
            var temp = list.Where(a => a % 2 == 0);
            var k = from l in list
                    where l % 2 == 0 
                    select l;
            return temp.ToArray();
        }

        public int[] SubArray(int skip, int take)
        {
            return list.Skip(skip).Take(take).ToArray();
        }
    }
}
