using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hw2.hw2._2
{
    public class MusicInsrtumentalBase
    {
        public MusicInsrtumentalBase(string name, string voice)
        {
            this.Name = name;
            this.Voice = voice;
            this.Created = DateTime.Now;
        }
        public string Name { get; set; }
        public string Voice { get; set; }
        public DateTime Created { get; set; }
        public void Sound()
        {
            Console.WriteLine($"{Voice}"); 
        }

        public void Show()
        {
            Console.WriteLine($"Name {Name}");
        }
        public void Desc()
        {
            Console.WriteLine($"This is {Name}");
        }

        public void History() 
        {
            Console.WriteLine($"Created {Created}");
        }

    }
    public class Violin : MusicInsrtumentalBase
    {
        public Violin(string name, string voice) : base(name, voice)
        {
        }
        public void Desc()
        {
            Console.WriteLine($"Its viola with name {Name} and created {Created}");
        }
    }
    public class Trombone : MusicInsrtumentalBase
    {
        public Trombone(string name, string voice) : base(name, voice)
        {
        }
    }
    public class Ukulele : MusicInsrtumentalBase
    {
        public Ukulele(string name, string voice) : base(name, voice)
        {
        }
    }
    public class Celo : MusicInsrtumentalBase
    {
        public Celo(string name, string voice) : base(name, voice)
        {
        }

    }
}
