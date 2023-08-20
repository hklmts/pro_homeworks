using hw2.hw4.hw4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw4.hw4_3
{
    public class City
    {
        public string Name { get; set; }
        public string Locatoin { get; set; }
        public int NumberOfInhabitants { get; set; }
        public bool Attacked { get; set; }

        public City(string Name, string Locations, int NumberOfInhabitants, bool Attacked)
        {
            this.Name = Name;
            this.Locatoin = Locations;
            this.NumberOfInhabitants = NumberOfInhabitants;
            this.Attacked= Attacked;
        }
        public void ShowInfo()
        {
            Console.WriteLine(NumberOfInhabitants);
        }
        public static City operator + (City k, int value)
        {
        k.NumberOfInhabitants += value;
        return k;
        }
        public static City operator - (City k, int value)
        {
            k.NumberOfInhabitants -= value;
            return k;
        }
        public static bool operator == (City k, City o)
        {
           return k.NumberOfInhabitants == o.NumberOfInhabitants;
        }
        public static bool operator !=(City k, City v)
        {
            return !k.Equals(v);
        }

        public static bool operator < (City k, City v) 
        {
            return k.NumberOfInhabitants < v.NumberOfInhabitants;
        }

        public static bool operator >(City k, City v)
        {
            return k.NumberOfInhabitants > v.NumberOfInhabitants;
        }
        public override bool Equals(object q)
        {
          City d = q as City;
            return Attacked == d.Attacked;
        }
  }
}
