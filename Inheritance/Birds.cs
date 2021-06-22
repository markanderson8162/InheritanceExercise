using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	public class Birds : Animal
	{
		public Birds()
		{

		}
		public double WingSpan { get; set; }
		public bool CanFly { get; set; }

		public string BirdSound()
		{
			string sound = "CAAAW!";
			return sound;
		}




	}
}
