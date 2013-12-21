using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra.Double;

namespace Clustering
{
    public class K_Means
    {
        private List<Vector> dataPoints;

        private readonly int dimension;
        private readonly InitMethod initMethod;
        private readonly double tolerance;

        public enum InitMethod
        {
            Random,
            Forgy
        }

        public K_Means( int dimension, InitMethod initMethod = InitMethod.Random, double tolerance = 1e-5 )
        {
            this.dimension = dimension;
            this.initMethod = initMethod;
            this.tolerance = tolerance;
        }





    }
}
