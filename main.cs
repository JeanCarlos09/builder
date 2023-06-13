// Paso 5: Utiliza el patrón Builder para construir objetos de manera flexible
public class Program
{
    public static void Main(string[] args)
    {
        // Crea un constructor concreto
        IPizzaBuilder builder = new HawaianaPizzaBuilder();

        // Crea una pizzería y configúrala con el constructor
        Pizzeria pizzeria = new Pizzeria(builder);

        // Prepara la pizza utilizando el director
        pizzeria.PrepararPizza();

        // Obtiene la pizza construida del constructor
        Pizza pizza = builder.ObtenerPizza();

        // Muestra los detalles de la pizza construida
        pizza.MostrarDetalles();
    }
}