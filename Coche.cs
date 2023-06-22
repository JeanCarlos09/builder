// Clase Producto
// Paso 1: Creamos la clase "Coche" que representa el objeto final que queremos construir.

using System;
// Clase Coche contiene las propiedades del coche como la marca, modelo, color, placa y el precio del coche
public class Coche
{
    public string marca ;
    public string modelo ;
    public string color ;
    public string placa ;
    public double precio ;

// Cada propiedades con sus set y get   
    public string  Marca {set{marca = value;} get{return marca;}}
    public string  Modelo {set{modelo = value;} get{return modelo;}}
    public string  Color {set{color = value;} get{return color;}}
    public string  Placa {set{placa = value;} get{return placa;}}
    public double  Precio {set{precio = value;} get{return precio;}}

// El método MostrarCoche se utiliza para imprimir en la consola los datos del coche, como la marca, el modelo, el color, la placa y el precio. 
    public void MostrarCoche()
    {
        
        Console.WriteLine("DATOS DEL COCHE: ");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("--------------------------");
        Console.WriteLine("PRECIO: " + Precio + "$");
      
    }
}