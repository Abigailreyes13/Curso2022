Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectangulo");
Console.WriteLine();


Console.WriteLine("Ingrese la base del rectangulo");
double basedelrectangulo = double.Parse(Console.ReadLine());


Console.WriteLine("Ingrese la altura del rectangulo");
double alturadelrectangulo = double.Parse(Console.ReadLine());

double superficiedelrectangulo = 
    basedelrectangulo * alturadelrectangulo;

Console.Write("El área del rectangulo es = ");


Console.WriteLine(superficiedelrectangulo);

if (superficiedelrectangulo > 10)
{
    Console.WriteLine("La superficie del rectangulo es mayor a 10");
}
else
{
    Console.WriteLine("la superficie del rectangulo no es mayor a 10");

}
// lo que aprendí del if - else 
// el else no va dentro de las llaves del if, hay que ponerlo por fuera y abrir nuevas llaves   

Console.ReadKey();


