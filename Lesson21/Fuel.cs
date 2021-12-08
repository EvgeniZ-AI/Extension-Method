using System;


namespace Lesson21
{
    public static class Fuel
    {
        public static int isCoal(this int i)
        {
            return i * 7 ; //энергия в кВт-ч
        }
         public static int isCoal(this amountOfCoal coal)
        {
            return coal.amount * 7;
        }
    }
}
