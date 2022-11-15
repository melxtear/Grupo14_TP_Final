using System;

namespace tp_final
{
    class cPila
    {

        public cNodo _tope;

        public cNodo Tope()
        {
            return _tope;
        }

        public void Apilar(cNodo unNodo)
        {
            if (_tope == null)
            {
                _tope = unNodo;
            }
            else
            {
                cNodo auxiliar = _tope;
                _tope = unNodo;
                _tope.Siguiente = auxiliar;
            }

        }
        public int Desapilar()
        {
            if (_tope != NULL)
            {
                _tope=_tope.Siguiente;
            }
        }
    }

}
