using System;

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

		public Shape(string pColour, int pSide1Length, int pSide2Length, int pSide3Length, int pSide4Length)
		{
			Colour = pColour;
			Side1Length = pSide1Length;
			Side2Length = pSide2Length;
			Side3Length = pSide3Length;
			Side4Length = pSide4Length;

		}

		public void GetPermieter()
		{
			GetPermieter int
		}


		public class Square : Quadrilateral
		{
			public void GetArea()
			{

			}
			







		}

	}











}
