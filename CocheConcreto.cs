// Clase BuilderConcreto
// Paso 3: Implementamos una clase "CocheConcreto" que implementa la interfaz "ICocheBuilder".

// La clase CocheConcreto tiene un atributo privado llamado MiCoche, que es del tipo Coche. Este atributo representa el objeto Coche que se está construyendo.
public class CocheConcreto : ICocheBuilder
{
    private Coche MiCoche;
  
// El constructor de la clase CocheConcreto se encarga de inicializar el objeto MiCoche creando una instancia de la clase Coche y asignándola a dicho atributo.
  
    public CocheConcreto()
    {
        MiCoche = new Coche();
    }

// Estos métodos forman parte de la implementación de la interfaz ICocheBuilder en la clase CocheConcreto y se utilizan para construir y configurar las diferentes propiedades de un objeto Coche.  
  

// Dentro del método ConstruirMarca(), se asigna el valor "CHEVROLET" a la propiedad Marca del objeto MiCoche.
    public void ConstruirMarca()
    {
        MiCoche.Marca = "CHEVROLET" ;
    }

// Dentro del método ConstruirModelo(), se asigna el valor "Chevrolet Onix" a la propiedad Modelo del objeto MiCoche.
    public void ConstruirModelo()
    {
        MiCoche.Modelo = "Chevrolet Onix" ;
    }
  
// Dentro del método ConstruirColor(), se asigna el valor "Rojo" a la propiedad Color del objeto MiCoche.
    public void ConstruirColor()
    {   
        MiCoche.Color = "Rojo" ;
    }
  
// Dentro del método ConstruirPlaca(), se asigna el valor "MBD-5601" a la propiedad Placa del objeto MiCoche. 
    public void ConstruirPlaca()
    {
        MiCoche.Placa = "MBD-5601" ;
    }
  
// Dentro del método ConstruirPrecio(), se asigna el valor 17.999 a la propiedad Precio del objeto MiCoche. 
    public void ConstruirPrecio()
    {    
      MiCoche.Precio = 17.999 ;
    }

//  El método ObtenerCoche no recibe ningún argumento y devuelve un objeto de tipo Coche. Dentro del método, simplemente se devuelve el objeto MiCoche que se ha estado construyendo y configurando durante el proceso de construcción.  
    public Coche ObtenerCoche()
    {
        return MiCoche;
    }
}