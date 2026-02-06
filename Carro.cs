using System;

    //Debajo tenemos la clase.
public class Carro {
    // Esto es el estado, atributos.
    public string marca;
    public int gasolina;

    // Aquí tenemos el comportamiento, o sea el método.
    public void Conducir() {
        if (gasolina > 0) {
            Console.WriteLine("El carro está avanzando...");
        } else {
            Console.WriteLine("No hay gasolina.");
        }
    }
}
    //Final del ejemplo, ejercicio.
