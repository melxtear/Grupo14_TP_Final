using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class Mochila
    {
        //ver si lo que tiene que retornar es pedido o sea lista de estos o una lista en si (clase lista?)
        public static Pedido Algoritmo_Mochila(int densidad_camion, int[] densidad_pedidos, int[] valor_pedidos, int n, int W, Pedido[] lista_pedidos)
        {
            Pedido[,] kp = new Pedido[n + 1, W + 1];
            int[,] K = new int[n + 1, W + 1];
            int w, i;

            for(int k=0;k<n;k++)
            {
                for(int u=0;u<n;u++)
                {
                   kp[i][j] = new List(Pedido); //ver como inicializar una lista de pedidos(objetos) dentro de la matriz
                }  
            }
            //la idea de este algoritmo es que devuelva una matriz, en la cual en cada posicion
            //de esta haya una lista de los pedidos en base a las posibles combinaciones de
            //programacion dinamica, teniendo en cuenta su valor y densidad y de esta manera
            //obtener la mejor solucion
          

            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= n; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        K[i, w] = 0; //primera posicion es igual a 0
                    }
                    else if (densidad_pedidos[i - 1] <= w) //si la densidad del pedido es menor a w
                    {
                        if (valor_pedidos[i - 1] + K[i - 1, w - densidad_pedidos[i - 1]] > K[i - 1, w])
                        {
                            K[i, w] = Math.Max(valor_pedidos[i - 1] + K[i - 1, w - densidad_pedidos[i - 1]], K[i - 1, w]);
                            kp[i, w] = lista_pedidos[i - 1];//la idea sería guardar el elemento de la lista recibida en la nueva lista
                        }
                        else
                        {
                            K[i, w] = K[i - 1, w];
                        }
                    }
                }
            }
            return kp[n, W];
        }

    }
    public static int KnapSack(int W, int[] wt, int[] val, int n)
    {
        int i, w;
        int[,] K = new int[n + 1, W + 1];

        // Build table K[][] in bottom
        // up manner
        for (i = 0; i <= n; i++)
        {
            for (w = 0; w <= W; w++)
            {

                if (i == 0 || w == 0)
                    K[i, w] = 0;

                else if (wt[i - 1] <= w)
                    K[i, w] = Math.Max(val[i - 1] + K[i - 1, w - wt[i - 1]], K[i - 1, w]);
                else
                    K[i, w] = K[i - 1, w];
            }
        }

        return K[n, W];
    }
}
 
