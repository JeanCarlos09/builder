// Clase Builder
// Paso 2: Creamos una interfaz "ICocheBuilder" que define los métodos para construir cada parte del coche.

// Esto incluye los métodos construirMarca, construirModelo, construirColor, construirPlaca, construirPrecio.
public interface ICocheBuilder
{
    public void ConstruirMarca();
    public void ConstruirModelo();
    public void ConstruirColor();
    public void ConstruirPlaca();
    public void ConstruirPrecio();

//  El método ObtenerCoche() no recibe ningún argumento y devuelve un objeto de tipo Coche. Se utiliza para obtener el objeto coche construido una vez que se han realizado todas las operaciones de construcción y configuración.
    Coche ObtenerCoche();
}