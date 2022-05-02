using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTP4.Distribuciones
{
    internal class Normal : Distribucion
    {
        protected override List<object> ObtenerNumeros(int N, int a, int b)
        {
            throw new NotImplementedException();
        }

        /* Generación de numeros para la distribución normal. Mandamos la media junto con la varianza y la decisión de usar
         Box Muller (opción 0) o el metodo de convolcuión (opción 1)*/
        protected override List<object> ObtenerNumeros(int N, double var, double avg, int choice)
        {
            switch (choice)
            {
                case 0:
                    for (int i = 0; i < N; i++)
                    {
                        List<double> rnd = generarNumeros(2);
                        if (i % 2 == 0)
                        {
                            updatedNums.Add(Math.Round(Math.Sqrt(-2 * Math.Log(rnd[0])) * Math.Cos(2 * Math.PI * rnd[1]) * Math.Sqrt(var) + avg, 4));
                        }
                        else
                        {
                            updatedNums.Add(Math.Round(Math.Sqrt(-2 * Math.Log(rnd[0])) * Math.Sin(2 * Math.PI * rnd[1]) * Math.Sqrt(var) + avg, 4));
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < N; i++)
                    {
                        List<double> rnd = generarNumeros(12);
                        updatedNums.Add(Math.Round((rnd.Sum() - 6) * Math.Sqrt(var) + avg, 4));
                    }
                    break;
            }
            return updatedNums;
        }

        protected override List<object> ObtenerNumeros(int N, double lambda)
        {
            throw new NotImplementedException();
        }
    }
}
