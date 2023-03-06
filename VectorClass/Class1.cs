using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClass
{
    internal class Vector
    {
        private double[] arrayValues { get; set; }

        private int n { get; set; }
        public Vector(int n)
        {
            arrayValues = new double[n];
        }
        public Vector(double[] values)
        {
            this.arrayValues = values;
            this.n = arrayValues.Length;
        }
        public Vector(Vector other)
        {
            arrayValues = new double[other.arrayValues.Length];
            Array.Copy(other.arrayValues, arrayValues, arrayValues.Length);
        }
        public static Vector Read()
        {
            Console.Write("Введите размер вектора: ");
            int n = int.Parse(Console.ReadLine());

            Vector arr = new Vector(n);
            Console.WriteLine("Введите элементы вектора:");

            for (int i = 0; i < n; i++)
            {
                arr.arrayValues[i] = double.Parse(Console.ReadLine());
            }

            return arr;
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", arrayValues) + ")";
        }
        public double Length()
        {
            double sum = 0;
            for (int i = 0; i < arrayValues.Length; i++)
            {
                sum += arrayValues[i] * arrayValues[i];
            }

            return Math.Sqrt(sum);
        }

        public int Size()
        {
            return arrayValues.Length;
        }

        public double Max()
        {
            int index = 0;
            for (int i = 1; i < arrayValues.Length; i++)
            {
                if (arrayValues[i] > arrayValues[index])
                {
                    index = i;
                }
            }

            return arrayValues[index];
        }

        public int MinIndex()
        {
            int minIndex = 0;
            for (int i = 1; i < arrayValues.Length; i++)
            {
                if (arrayValues[i] < arrayValues[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public Vector positiveValues()
        {
            int count = 0;
            for (int i = 0; i < arrayValues.Length; i++)
            {
                if (arrayValues[i] > 0)
                {
                    count++;
                }
            }

            Vector newVector = new Vector(count);
            int j = 0;

            for (int i = 0; i < arrayValues.Length; i++)
            {
                if (arrayValues[i] > 0)
                {
                    newVector.arrayValues[j] = arrayValues[i];
                    j++;
                }
            }

            return newVector;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            if (a.Size() != b.Size())
            {
                Console.WriteLine("Векторы должны быть одного размера");
            }

            Vector c = new Vector(a.Size());

            for (int i = 0; i < a.Size(); i++)
            {
                c.arrayValues[i] = a.arrayValues[i] + b.arrayValues[i];
            }

            return c;
        }

        public static double operator *(Vector a, Vector b)
        {
            if (a.Size() != b.Size())
            {
                Console.WriteLine("Векторы должны быть одного размера");
            }

            double sum = 0;

            for (int i = 0; i < a.Size(); i++)
            {
                sum += a.arrayValues[i] * b.arrayValues[i];
            }

            return sum;
        }

        public static bool operator ==(Vector a, Vector b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if ((object)a == null || (object)b == null || a.Size() != b.Size())
            {
                return false;
            }

            for (int i = 0; i < a.Size(); i++)
            {
                if (a.arrayValues[i] != b.arrayValues[i])
                {
                    return false;
                }
            }

            return true;
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }

    }
}
