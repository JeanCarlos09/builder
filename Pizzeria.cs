// Paso 4: Crea una clase Director para gestionar la construcción del objeto
public class Pizzeria
{
    private IPizzaBuilder _builder;

    public Pizzeria(IPizzaBuilder builder)
    {
        _builder = builder;
    }

    public void PrepararPizza()
    {
        _builder.ConstruirTipoMasa();
        _builder.ConstruirSalsa();
        _builder.ConstruirTipo();
    }
}