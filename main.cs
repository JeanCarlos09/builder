// Clase principal (Program)
// Paso 4: Utiliza el patrón Builder para construir objetos de manera flexible

class Program
{
    static void Main(string[] args)
    {
        // Se crea un objeto builder de tipo CocheConcreto y lo utilizan para construir un coche llamando a los métodos de construcción correspondientes.
        CocheConcreto builder = new CocheConcreto();
        builder.ConstruirMarca();
        builder.ConstruirModelo();
        builder.ConstruirColor();
        builder.ConstruirPlaca();
        builder.ConstruirPrecio();
        
        // Se llama al método ObtenerCoche() del Builder para obtener el objeto Coche construido. 
        Coche coche = builder.ObtenerCoche();

        //  Se invoca el método MostrarCoche() del objeto Coche
        coche.MostrarCoche();
     
    }
}