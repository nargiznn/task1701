using System;
namespace task1701
{
	public class ChineCity:City
	{
		public ChineCity()
		{
		}
        public new int _population
        {
            get
            {
                return base.Population;
            }
            set
            {
                if (value > 100000 && value>0)
                {
                    base.Population = value;
                }
                else
                {
                    Console.WriteLine("Yanlisdir");
                }
            }
        }

    }
}

