int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int numeroIngresado = 0;
var contador = 0;
Console.WriteLine("ADIVINA EL NUMERO SECRETO");
do
{
    Console.WriteLine("Ingresa un numero entre 1 y 20:");
    numeroIngresado = int.Parse(Console.ReadLine());
    contador++;
    if (numeroIngresado == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el numero secreto que era: {numeroSecreto}");
    }
    else if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("El numero secreto es menor");
    }
    else
    {
        Console.WriteLine("El numero secreto es mayor");
    }
} while (numeroIngresado != numeroSecreto);

Console.WriteLine($"Lo has logrado en {contador} intentos");