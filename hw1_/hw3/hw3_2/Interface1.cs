using hw2.hw3.hw3_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array = hw2.hw3.hw3_1.Array;

namespace hw2.hw3.hw3_2
{

    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int number);

    }

    public class NextArray : Array,IMath
    {

        public NextArray(int[] data) : base(data)
        {

        }
        public int Max()
        {
            int result = int.MinValue;
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] > result)
                {
                    result = data[i];
                }
            }
            return result;
        }
        public int Min()
        {
            int result = int.MaxValue;
            for (int i = 0; i < data.Length; i++)
                result = data[i] < result ? data[i] : result;
            return result;
        }
        public float Avg()
        {
            float sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            return sum / data.Length;
        }
        public bool Search(int number)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == number)
                {
                    return true;
                }
            }

            return false;
        }

    }
}