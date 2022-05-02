using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTP4.Distribuciones
{
    internal class Poisson : Distribucion
    {
        protected override List<object> ObtenerNumeros(int N, int a, int b)
        {
            throw new NotImplementedException();
        }

        protected override List<object> ObtenerNumeros(int N, double var, double avg, int choice)
        {
            throw new NotImplementedException();
        }

        public int generarPoisson(double lambda)
        {
            double p = 1;
            int x = -1;
            double a = Math.Pow(Math.E, -lambda);

            do
            {
                double rnd = generarNumero();
                p *= rnd;
                x++;
            }
            while (p >= a);
            return x;
        }


        protected override List<object> ObtenerNumeros(int N, double lambda)
        {
            for(int i = 0; i < N; i++)
            {
                int rnd = generarPoisson(lambda);
                updatedNums.Add(rnd);
            }
            return updatedNums;
        }
    }
}
