using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
	public class Shape
	{
		public string Colour;
	}


	public class Quadrilateral : Shape
	{
		public int Side1Length { get; set; }
		public int Side2Length { get; set; }
		public int Side3Length { get; set; }
		public int Side4Length { get; set; }

		public void Shape(string pColour, int pSide1Length, int pSide2Length, int pSide3Length, int pSide4Length)
		{
			Colour = pColour;
			Side1Length = pSide1Length;
			Side2Length = pSide2Length;
			Side3Length = pSide3Length;
			Side4Length = pSide4Length;

		}

		public int GetPermieter()
		{
			return Side1Length + Side2Length + Side3Length + Side4Length;
		}


		public class Square : Quadrilateral
		{
			public int GetArea()
			{
				return Side1Length* Side1Length;
			}
		}

		public class Rectangle : Quadrilateral
		{
			public int GetArea()
			{
				return Side1Length * Side2Length;
			}



		}
	}
}
