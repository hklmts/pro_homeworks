using hw2.hw3.hw3_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2.hw3.hw3_1
{

    interface IOutput
    {
        void Show();
        void Show(string Info);

    }

    public class Array : IOutput
    {
        public int[] data;

        public Array(int[] data)
        {
            this.data = data;
        }
        public void Show()
        {
            Console.WriteLine(DataToString());
        }

        public void Show(string Info)
        {
            Console.WriteLine($"{Info} {DataToString()}");
        }

        public string DataToString()
        {
            string result = "{";
            for (int i = 0; i < data.Length; i++)
            {
                if (i != 0)
                {
                    result += ", " + data[i];
                } 
                else
                {
                    result += data[i];
                }
            }
            return result + "}";
        }

    }
}