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
        //habria que hacer una clase de mochila y otra del problema del viajero??
        //ver si lo que tiene que retornar es pedido o sea lista de estos o una lista en si (clase lista?)
        public  List<Pedido> Algoritmo_Mochila2(int[] densidad_pedidos, int[] valor_pedidos, int n, int W, List<Pedido> lista_pedidos)
        {
            Pedido[,] kp;
            int[,] K = new int[n + 1, W + 1];
            int w, i;
    
           
            
            for(int k=0;k<n;k++)
            {
                for(int u=0;u<n;u++)
                {
                   kp[k,u] = new List<Pedido>(); //ver como inicializar una lista de pedidos(objetos) dentro de la matriz
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
        public void Algoritmo_Mochila1(int W, List<Pedido> lista_pedidos)
        {
            List <Pedido> wt_pedidos= new List<Pedido>();
            List <Pedido> val_pedidos= new List<Pedido>();

            int n=lista_pedidos.Count();

            for(int i = 0; i < n; i++)
            {
                wt_pedidos.Add(lista_pedidos[i].);
                val_pedidos.Add(val_pedidos[i].prioridad);
            }
        }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_TP
    {
        public class practica
        {
            public class Item
            {
                public int Weight { get; set; }
                public int Value { get; set; }
            }
            public static List<Item> KnapSack(Item[] items, int capacity)
            {
                int[,] matrix = new int[items.Length + 1, capacity + 1];
                List<Item>[,] matrix2 = new List<Item>[items.Length + 1, capacity + 1];
                for (int i = 0; i < items.Length + 1; i++)
                {
                    for (int j = 0; j < capacity + 1; j++)
                        matrix2[i, j] = new List<Item>();
                }

                for (int itemIndex = 0; itemIndex <= items.Length; itemIndex++)
                {
                    // This adjusts the itemIndex to be 1 based instead of 0 based
                    // and in this case 0 is the initial state before an item is
                    // considered for the knapsack.
                    var currentItem = itemIndex == 0 ? null : items[itemIndex - 1];
                    for (int currentCapacity = 0; currentCapacity <= capacity; currentCapacity++)
                    {
                        // Set the first row and column of the matrix to all zeros
                        // This is the state before any items are added and when the
                        // potential capacity is zero the value would also be zero.
                        if (currentItem == null || currentCapacity == 0)
                        {
                            matrix[itemIndex, currentCapacity] = 0;
                        }
                        // If the current items weight is less than the current capacity
                        // then we should see if adding this item to the knapsack 
                        // results in a greater value than what was determined for
                        // the previous item at this potential capacity.
                        else if (currentItem.Weight <= currentCapacity)
                        {
                            /*public int KnapSack(int W, int[] wt, int[] val, int n)
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
                            }*/
                        }
}
}
 
