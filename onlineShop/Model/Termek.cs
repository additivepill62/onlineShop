using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.Model
{
	internal class Termek
	{
		
		public Termek()
		{
			
		}
		public Termek(string nev, double ar, int raktarKeszlet)
			{
				Nev = nev;
				Ar = ar;
				RaktarKeszlet = raktarKeszlet;
		}
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Nev { get; set; }
		public double Ar { get; set; }
		public int RaktarKeszlet { get; set; }
	}
}
