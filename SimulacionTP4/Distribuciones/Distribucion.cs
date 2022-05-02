using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTP4.Distribuciones
{
    internal abstract class Distribucion
    {

        /* Creamos una clase madre para todas la distribuciones, con un metodo de generación de numeros aleatorios,
         una lista genérica de numeros actualizados y los metodos para crear numeros actualizados segun la distribución*/

        protected List<object> updatedNums = new List<object>();
        protected abstract List<object> ObtenerNumeros(int N, int a, int b);

        protected abstract List<object> ObtenerNumeros(int N, double var, double avg, int choice);

        protected abstract List<object> ObtenerNumeros(int N, double lambda);


        protected List<double> generarNumeros(int N)
        {
            Random rnd = new Random();
            List<double> nros = new List<double>();
            for (int j = 0; j < N; j++)
            {
                nros.Add(rnd.NextDouble());
            }

            return nros;
        }

        protected double generarNumero()
        {
            Random rnd = new Random();
            return rnd.NextDouble();
        }

    }
}
