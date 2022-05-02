using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTP4.Distribuciones
{
    internal class Uniforme : Distribucion
    {
        protected override List<object> ObtenerNumeros(int N, int a, int b)
        {
            List<double> nums = generarNumeros(N);
            for (int i = 0; i < N; i++)
            {
                updatedNums.Add(Math.Round(a + nums[i] * (b - a), 4));
            }
            return updatedNums;

        }

        protected override List<object> ObtenerNumeros(int N, double lambda)
        {
            throw new NotImplementedException();
        }

        protected override List<object> ObtenerNumeros(int N, double var, double avg, int choice)
        {
            throw new NotImplementedException();
        }
    }
}
