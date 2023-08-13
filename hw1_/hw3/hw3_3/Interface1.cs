using hw2.hw3.hw3_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw3.hw3_3
{
    interface ISort
    {
        void SortAsc(); 
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    public class SortNextArray : NextArray, ISort
    {
        public SortNextArray(int[] numbers) : base(numbers)
        {
        
        }

        public void SortAsc()
        { 
            for(int i = 1; i < data.Length; i++)
            {
                for(int j = 0; j < data.Length - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void SortDesc()
        {
            for (int i = 1; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - i; j++)
                {
                    if (data[j] < data[j + 1])
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }
}
