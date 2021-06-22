using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	public class Reptiles : Animal
	{
		public Reptiles()
		{

		}

		public bool IsScaley { get; set; }
		public double TailLength { get; set; }

		public bool UseTongue (bool tongue)
		{
			return tongue;
		}
	}
}
