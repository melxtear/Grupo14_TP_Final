using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    class cVehiculo
    {
        bool ascensor_guardar;
       
        float volumenmax { get; set; }
        int pesomax { get; set; }
        float anchomax { get; set; }
        float largomax { get; set; }
        float alturamax { get; set; }
        float densidadmax { get; set; }

        public List<Pedido> pedidos_a_llevar { get; set; };
        void calcular_densidad() { 
            float resultado;
            resultado = pesomax / volumenmax;
            densidadmax=resultado;
        }
        

        public cVehiculo(int peso_max, float volumen_max, float densidad_max, float ancho_max, float largo_max, float altura_max)
        {
            pesomax = peso_max;
            volumenmax = volumen_max;
            densidadmax = densidad_max;
            anchomax = ancho_max;  
            largomax = largo_max;  
            alturamax = altura_max; 
        }

        
        public cPila<Pedido> Cargar_Camion_Pila(List<Pedido> lista_pedidos_a_entregar)
        {
            cPila <Pedido> miPila = new cPila<Pedido>;
            for(int i = 0; i < lista_pedidos_a_entregar.Count; i++)
            { 
                miPila.Push(lista_pedidos_a_entregar[i].producto);//el ultimo en ser pusheado va a ser el primero en salir
            }
            return miPila.ToArray();
        }

        public List<Pedido> Descargar_Camion(Pedido pedido_buscado, List<Pedido>lista_pedidos_a_entregar)
        {
            Stac
        }

        
    }
}
