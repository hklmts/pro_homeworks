using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw._2._1._7_hw
{
    public class StagePlay
    {
        public string Name { get; set; }
        public string Author { get; set; }//П.І.Б. автора

        public string Genre { get; set; }
        public int YearCreated { get; set; }

        public StagePlay() 
        {
            Name = Console.ReadLine();
        }
        public StagePlay(string Name, string Author, string Genre, int YearCreated) 
        {
            this.Name = Name;
            this.Author = Author;
            this.Genre = Genre;
            this.YearCreated = YearCreated;
        }

        ~StagePlay()
        {
            Console.WriteLine($"{Name} was deleted");
        }
    }

}
