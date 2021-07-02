using System;
namespace figuras
{
public class Figura
{
    protected double _area; 
    protected double _perimetro; 

    public double Area 
    {
        
      get { return this._area; }
    }

    public double Perimetro 
    {
        
      get { return this._perimetro; }
    }
    public void Ver()
    {
      Console.WriteLine("Área: {0}", this.Area);
      Console.WriteLine("Perímetro: {0}\n", this.Perimetro);
    }
}
}