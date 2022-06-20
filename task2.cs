using System;
using System.Linq;
using System.Collections.Generic;
//change1 master
//change2 master


public class Program
{
	public static void Main()
	{
		// Student collection
		List<Country> countries = new List<Country>() { 
		        new Country() { Name = "Spain", Population = 47, Area = 8000} ,
				new Country() { Name = "Poland", Population = 15, Area = 1000} ,
				new Country() { Name = "Portugal", Population = 5, Area = 950 } ,
			};
		
	

		int count = 0;
		foreach(Country c in countries)
		    count += 1;
		
		Console.WriteLine("----------------------------------------");
		double avgPopulation = countries.Sum(s => s.Population);	
		Console.WriteLine("Average of population (millions): {0}. ", avgPopulation/count);
		
		Console.WriteLine("----------------------------------------");
		double avgArea = countries.Sum(s => s.Area);	
		Console.WriteLine("Average of area (km2): {0}. ", avgArea/count);
	
	    
	    
	
		//-----------------------------------
	
	}
}

public class Country{

	public string Name { get; set; }
	public int Population { get; set; }
	public double Area { get; set; }
	
}