using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    public static class deliveries
    {
        public static amountOfCoal createRandomDeliveris(this amountOfCoal amountCoal, int min,int max)
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            amountCoal.num = "№" + rnd.Next(1, 250);
            amountCoal.amount = rnd.Next(min, max);

            return amountCoal;
        }
    }
}
