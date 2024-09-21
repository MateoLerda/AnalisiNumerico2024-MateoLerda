using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Dos
{
	internal class Unidad2Logica
	{
		public Result CalculosU2(Datos datos) { 
			Result result = new Result();
			if (datos.Metodo == 0)
			{
				result = GausJordan(datos);
			}
			else {
				result = GausSeidel(datos);
			}
			return result;
		}

		private Result GausJordan(Datos datos) {
			Result result= new Result();

            for (int row = 0; row < datos.dimension; row++)
            {
				double coefDprincip = datos.Matriz[row, row];
                for (int col = 0; col < datos.dimension +1; col++)
                {
					datos.Matriz[row,col]= datos.Matriz[row, col]/ coefDprincip;
                }
                for (int rowCal = 0; rowCal < datos.dimension; rowCal++)
                {
					if (row != rowCal) {
						double coefCero = datos.Matriz[rowCal,row];
                        for (int col = 0; col < datos.dimension +1; col++)
                        {
							datos.Matriz[rowCal, col] = datos.Matriz[rowCal, col] - (coefCero * datos.Matriz[row, col]);
						}
                    }
                }
            }
            for (int i = 0; i < datos.dimension; i++)
            {
				int col = datos.dimension;
				result.Resultados.Add(Math.Round(datos.Matriz[i, col], 6));
            }
			result.sucses= true;
            return result;
		}


		private Result GausSeidel(Datos datos)
		{
			Result result = new Result();
			double tolerancia = 0.0001; // Tolerancia para la convergencia
			int iteracionesMax = 100;   // Número máximo de iteraciones
			int count = 0;
			double[] vectorResultado = new double[datos.dimension];
			double[] vectorAnterior = new double[datos.dimension];

			// Inicializar el vector de resultados en ceros (u otro valor inicial si se requiere)
			for (int i = 0; i < datos.dimension; i++)
			{
				vectorResultado[i] = 0.0;
				vectorAnterior[i] = 0.0;
			}

			// Bucle iterativo del método de Gauss-Seidel
			while (count < iteracionesMax)
			{
				count++;
				for (int row = 0; row < datos.dimension; row++)
				{
					// Calcular el término independiente de la ecuación (lado derecho de la ecuación)
					double suma = datos.Matriz[row, datos.dimension];

					// Sumar los términos con las variables conocidas
					for (int col = 0; col < datos.dimension; col++)
					{
						if (col != row)
						{
							suma -= datos.Matriz[row, col] * vectorResultado[col];
						}
					}

					// Actualizar el valor de la incógnita
					vectorAnterior[row] = vectorResultado[row]; // Guardar el valor anterior
					vectorResultado[row] = suma / datos.Matriz[row, row];
				}

				// Comprobar la convergencia (usando la norma del error relativo)
				bool haConvergido = true;
				for (int i = 0; i < datos.dimension; i++)
				{
					double errorRelativo = Math.Abs((vectorResultado[i] - vectorAnterior[i]) / vectorResultado[i]);
					if (errorRelativo > tolerancia)
					{
						haConvergido = false;
						break; // Si algún componente no cumple la tolerancia, sigue iterando
					}
				}

				// Si ha convergido, salir del bucle
				if (haConvergido)
				{
					result.sucses = true;
					break;
				}
			}

			// Verificar si el método convergió o si alcanzó el número máximo de iteraciones
			if (result.sucses)
			{
				for (int i = 0; i < datos.dimension; i++)
				{
					result.Resultados.Add(Math.Round(vectorResultado[i], 6));
				}
			}
			else
			{
				result.sucses = false;
				result.message = "Cantidad de iteraciones (" + iteracionesMax + ") superadas sin converger.";
			}

			return result;
		}
	}
}
