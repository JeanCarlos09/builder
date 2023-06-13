// Paso 3: Implementa la interfaz o clase abstracta en un constructor concreto
public class HawaianaPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza;

    public HawaianaPizzaBuilder()
    {
        _pizza = new Pizza();
    }

    public void ConstruirTipoMasa()
    {
        _pizza.TipoMasa = "Masa delgada";
    }

    public void ConstruirSalsa()
    {
        _pizza.Salsa = "Salsa de tomate";
    }

    public void ConstruirTipo()
    {
        _pizza.topping = "Piña y jamón";
    }

    public Pizza ObtenerPizza()
    {
        return _pizza;
    }
}