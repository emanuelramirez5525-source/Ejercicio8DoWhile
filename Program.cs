// Escriba un programa que muestre la tabla de multiplicar del 5 utilizando do-while.

int num = 5;
int tabla = 1;

Console.WriteLine("Tabla del 5");
do
{
    
    Console.WriteLine($"{num} X {tabla} = {num * tabla}");
    tabla++;
} while (tabla <= 10);

