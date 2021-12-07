using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    public static class ToStingCollection
    {
        public static string ConvertToString(this IEnumerable collection)
        {
            var result = " ";

            foreach (var item in collection)
            {
                result += item.ToString() + ",\t\n ";
            }

            return result;
        }
    }
}
