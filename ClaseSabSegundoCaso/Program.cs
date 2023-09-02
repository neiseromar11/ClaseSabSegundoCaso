// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el tipo de uva (A o B): ");
string tipo = Console.ReadLine();
Console.WriteLine("Ingrese el tamaño de uva (1 o 2 ): ");
int tamaño = int.Parse(Console.ReadLine());

double precioIn = 0;


if (tipo == "A")
{
    if (tamaño == 1)
    {

        precioIn = 20;
    }
    else if (tamaño == 2)
    {
        precioIn = 30;
    }
}

else if (tipo == "B")
{

    if (tamaño == 1)
    {

        precioIn = -30;

    }
    else if (tamaño == 2)
    {

        precioIn = -50;
    }
}
else {
    Console.WriteLine("Tipo de uva no valido.Tiene que ser A o B");
}
Console.WriteLine("Ingrese la cantidad de kilos de uva entregados: ");
double cantidadK=double.Parse(Console.ReadLine());

double ganancia = cantidadK * precioIn;

Console.WriteLine("La ganancia obtenida es : " + ganancia);