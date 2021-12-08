using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryGas;

namespace Lesson21
{
    public static class deliveries
    {
        public static amountOfCoal createRandomDeliveris(this amountOfCoal amountCoal, int min,int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            amountCoal.num = "№" + rnd.Next(1, 250);
            amountCoal.amount = rnd.Next(min, max);

            return amountCoal;
        }
        public static GasDelivery createRandomDeliveris(this GasDelivery amountGas,int min , int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            amountGas.num = "№ " + rnd.Next(1, 250);
            amountGas.amout = rnd.Next(min, max);

            return amountGas;
        }
    }
}
