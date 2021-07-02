using System;
using System.Collections.Generic;

namespace figuras
{
class Program
{
    static void Main(string[] args)
    {
      

      List<Figura> listaFiguras = new List<Figura>();
      Circulo circ1 = new Circulo(4);
      Retangulo ret1 = new Retangulo(8 , 24);

      listaFiguras.Add(circ1);
      listaFiguras.Add(ret1);

      
      
      foreach(Figura fig in listaFiguras)
      {
        fig.Ver();
      }
      

       
    }
}
}