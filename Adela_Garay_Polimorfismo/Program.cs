using System;

namespace EjercicioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de las clases derivadas //
            Animal miPerro = new Perro();
            Animal miGato = new Gato();

            // Llamar al método polimórfico //
            MostrarSonido(miPerro);
            MostrarSonido(miGato);

            // Llamar al método común //
            miPerro.Dormir();
            miGato.Dormir();
        }

        static void MostrarSonido(Animal animal)
        {
            animal.HacerSonido();
        }
    }
}
