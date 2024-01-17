using System;
using System.Xml.Linq;

namespace task1701
{
	public class City
	{
		public City()
		{
		}
		private string _name;
        protected int _population;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 20)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Yanlisdir");
                }
            }

        }

        
        public int Population
        {
            get
            {
                return _population;
            }
            set
            {
                if (Population >= 0)
                {
                    _population = value;
                }
                else
                {
                    Console.WriteLine("Yanlisdir");
                }

            }

        }



    }
}

