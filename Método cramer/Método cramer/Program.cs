using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Método_cramer
{
    class Program
    {
        static void Main(string[] args)
        {
            IngresarMatriz();
            Console.ReadKey();
        }

        
        static double[] Cramer(double[,] matriz, double[] vector)
        
        
        {
            
            
                double[] resultado = new double[3];      
            double[,] mDeterminante1 = new double[3,3];
            double[,] mDeterminante2 = new double[3,3];
            double[,] mDeterminante3 = new double[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mDeterminante1[i, j] = matriz[i, j];
                    mDeterminante2[i, j] = matriz[i, j];
                    mDeterminante3[i, j] = matriz[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                mDeterminante1[i,0] = vector[i];
                mDeterminante2[i,1] = vector[i];
                mDeterminante3[i,2] = vector[i];
            }

            double determinantePrincipal = Determinante(matriz);
            double determinanteSecundaria1 = Determinante(mDeterminante1);
            double determinanteSecundaria2 = Determinante(mDeterminante2);
            double determinanteSecundaria3 = Determinante(mDeterminante3);
            try{
            resultado[0] = determinanteSecundaria1 / determinantePrincipal;
            resultado[1] = determinanteSecundaria2 / determinantePrincipal;
            resultado[2] = determinanteSecundaria3 / determinantePrincipal;
                }
            catch(System.DivideByZeroException)
            {
                Console.WriteLine("El determinante es 0, no hay solucion");
             }
            finally
            {
                return resultado;
            }                  
                
            
           
            
        }
        static double Determinante(double[,] matriz)
        {
            
            
            double renglon1Positivo = matriz[0, 0] * matriz[1, 1] * matriz[2, 2];
            double renglon2Positivo = matriz[0, 1] * matriz[1, 2] * matriz[2, 0];
            double renglon3Positivo = matriz[0, 2] * matriz[1, 0] * matriz[2, 1];
            double renglon1Negativo = matriz[2, 0] * matriz[1, 1] * matriz[0, 2];
            double renglon2Negativo = matriz[2, 1] * matriz[1, 2] * matriz[0, 0];
            double renglon3Negativo = matriz[2, 2] * matriz[1, 0] * matriz[0, 1];
            
            return (renglon1Positivo + renglon2Positivo + renglon3Positivo - renglon1Negativo - renglon2Negativo - renglon3Negativo);
            

            
        }
        static string ImprimirResultado(double[] resultado)
        {
            return String.Format("Resultado\nX = {0}\nY = {1}\nZ = {2}", resultado[0], resultado[1], resultado[2]);
        }
        static void IngresarMatriz()
        {
            double[,] matriz = new double[3, 3];
            double[] vector = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese los valores de la ecuacion {0}",i+1);
                Console.Write("X: ");
                matriz[i, 0] = double.Parse(Console.ReadLine());
                Console.Write("Y: ");
                matriz[i, 1] = double.Parse(Console.ReadLine());
                Console.Write("Z: ");
                matriz[i, 2] = double.Parse(Console.ReadLine());
                Console.Write("Termino independiente: ");
                vector[i] = double.Parse(Console.ReadLine());          
            }
            Console.WriteLine(ImprimirResultado(Cramer(matriz, vector)));
        }
        

    }
}
