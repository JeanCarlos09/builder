// Paso 2: Crea una interfaz o clase abstracta para el constructor
public interface IPizzaBuilder
{
    void ConstruirTipoMasa();
    void ConstruirSalsa();
    void ConstruirTipo();
    Pizza ObtenerPizza();
}