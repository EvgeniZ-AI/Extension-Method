using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    public sealed class amountOfCoal
    {
        public string num { get; set; }
        public int amount { get; set; }

        public override string ToString()
        {
            return $"Номер поставки: {num}. Коллиечство угля в поставке: {amount}";
        }
    }
}
