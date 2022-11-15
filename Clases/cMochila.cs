using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace tp_final
{
    public class cMochila
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
        public void cargarPedidos(List<Pedido> pedidos, cVehiculo vehiculo)
        {
            int i, j;
            float sumVol = 0;
            int nuevaCantPedidos = 0;
            int sumPeso = 0;

            // Segundo algoritmo: vorazmente checkeo cuantos pedidos pueden entrar (segun el volumen)

            for (i = 0; i < pedidos.Count; i++)
            {
                if (sumVol + pedidos[i].volumen < vehiculo.volumenMax && pedidos[i].cargado == false)
                {
                    sumVol += pedidos[i].volumen;
                    nuevaCantPedidos++;
                }
            }

            // Armo la matriz de soluciones en base a mi sub-lista de pedidos (acortada por el tope de volumen)
            int[,] solucion = new int[nuevaCantPedidos + 1, vehiculo.pesoMax + 1];


            for (i = 0; i <= nuevaCantPedidos; i++)
            {
                for (j = 0; j <= vehiculo.pesoMax; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        solucion[i, j] = 0;
                    }
                    else if (pedidos[i - 1].peso <= j)
                    {
                        solucion[i, j] = Math.Max(pedidos[i - 1].prioridad + solucion[i - 1, j - pedidos[i - 1].peso],
                                                  solucion[i - 1, j]);
                        // **** SISTEMA NACIONAL DE VERIFICACION DE PEDIDOS AL VEHICULO ****
                        if (pedidos[i - 1].prioridad + solucion[i - 1, j - pedidos[i - 1].peso] > solucion[i - 1, j] // hubo modificaciones en la matriz prog. dinamica?
                            && pedidos[i - 1].cargado == false // se cargo el pedido anteriormente?
                            && sumPeso + pedidos[i - 1].peso < vehiculo.pesoMax) // se excede el peso del vehiculo?
                        {
                            vehiculo.pedidos.Add(pedidos[i - 1]);
                            pedidos[i - 1].cargado = true;
                            sumPeso += pedidos[i - 1].peso;
                        }
                    }
                    else
                    {
                        solucion[i, j] = solucion[i - 1, j];
                    }
                }
            }
            vehiculo.pesoActual = sumPeso;
            vehiculo.volumenActual = sumVol;
        }
    }
}
}
 
