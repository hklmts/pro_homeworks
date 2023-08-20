using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_.hw4.hw4_2
{
    public class Matrix
    {
        public int[] Data { get; set; }
        public string Name { get; set; }

        public Matrix(int[] data, string name)
        {
            Data = data;
            Name = name;
        }

        public override string ToString()
        {
            bool isFirst = true;
            string result = Name + ": {";
            foreach (int n in Data)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    result += ", ";
                }
                result += n;
            }
            return result + "}";
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            int[] resultData = calculateData(a.Data, b.Data, "+");
            return new Matrix(resultData, "Added matrix");
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            int[] resultData = calculateData(a.Data, b.Data, "-");
            return new Matrix(resultData, "Minuseded matrix");
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            int[] resultData = calculateData(a.Data, b.Data, "*");
            return new Matrix(resultData, "Multiple matrix");
        }

        public static Matrix operator *(Matrix a, int b)
        {
            int[] resultData = a.Data;
            for (int i = 0; i < resultData.Length; i++)
            {
                resultData[i] *= b;
            }
            return new Matrix(resultData, $"Multiple {a.Name} by {b}");
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.Data.Length != b.Data.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Data.Length; i++)
            {
                if (a.Data[i] != b.Data[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b && a.Name == b.Name);
        }

        private static int[] calculateData(int[] a, int[] b, string o)
        {
            int resultDataLength = a.Length >= b.Length ? a.Length : b.Length;

            int[] resultData = new int[resultDataLength];
            for (int i = 0; i < resultData.Length; i++)
            {
                if (a.Length <= i)
                {
                    resultData[i] = b[i];
                }
                else if (b.Length <= i)
                {
                    resultData[i] = a[i];
                }
                else
                {
                    switch (o)
                    {
                        case "+":
                            resultData[i] = a[i] + b[i];
                            break;
                        case "-":
                            resultData[i] = a[i] - b[i];
                            break;
                        case "*":
                            resultData[i] = a[i] * b[i];
                            break;
                    }
                }
            }
            return resultData;
        }

    }
}
