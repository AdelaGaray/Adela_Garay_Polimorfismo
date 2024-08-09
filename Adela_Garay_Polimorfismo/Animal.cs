public abstract class Animal
{
    // Método abstracto que debe ser implementado por las clases derivadas //
    public abstract void HacerSonido();

    // Método común a todas las clases derivadas//
    public void Dormir()
    {
        Console.WriteLine("Este animal está durmiendo.");
    }
}
