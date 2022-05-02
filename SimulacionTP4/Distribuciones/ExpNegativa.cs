using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTP4.Distribuciones
{
    internal class ExpNegativa : Distribucion
    {
        protected override List<object> ObtenerNumeros(int N, double lambda)
        {
            List<double> nums = generarNumeros(N);
            double avg = 1 / lambda;
            for (int i = 0; i < N; i++)
            {
                updatedNums.Add(Math.Round(-avg * Math.Log(1 - nums[i]), 4));
            }

            return updatedNums;
        }

        protected override List<object> ObtenerNumeros(int N, int a, int b)
        {
            throw new NotImplementedException();
        }

        protected override List<object> ObtenerNumeros(int N, double var, double lambda, int choice)
        {
            throw new NotImplementedException();
        }
    }
}
