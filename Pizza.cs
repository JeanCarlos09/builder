using System;

// Paso 1: Crea una clase para representar el objeto que quieres construir
public class Pizza
{
    public string tipoMasa ;
    public string salsa ;
    public string topping ;

  public string TipoMasa
  {
    set
    {
      tipoMasa = value;
    }
    get 
    {
      return tipoMasa; 
    }
  }

  public string Salsa
  {
    set
    {
      salsa = value;
    }
    get 
    {
      return salsa; 
    }
  }

  public string Topping
  {
    set
    {
      topping = value;
    }
    get 
    {
      return topping; 
    }
  }

    public void MostrarDetalles()
    {
        Console.WriteLine("Tipo de masa: {0}", TipoMasa);
        Console.WriteLine("Salsa: {0}", Salsa);
        Console.WriteLine("Topping: {0}", Topping);
    }
}