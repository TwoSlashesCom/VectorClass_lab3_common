using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClass
{
    internal class Vector1
    {
        private double[] values { get; set; }

        public Vector1(int n)
        { 
            values = new double[n]; 
        }
        public Vector1(double[] Values)
        {
            Values = values;
        }    


    }
}
