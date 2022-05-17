//// Como comparar entre letras mayusculas y minusculas 

//Console.WriteLine("Desea continuar? (S / N)");
//string respuesta = Console.ReadLine();

//if (respuesta.ToUpper() == "s")
//{
//    Console.WriteLine("Usted puso que SI");
//}
//else if (respuesta.ToUpper() == "N")
//{
//    Console.WriteLine("Usted puso que no");
//}
//else
//{
//    Console.WriteLine("Usted no entiende nada"); 
//}

//WHILE
// 1)
//Console.WriteLine("Cuantas vueltas quiere dar?");

//var cantDeVueltas = int.Parse(Console.ReadLine());
//var contador = 0;

//while (contador < cantDeVueltas) 
//{
//    contador++;
//    Console.WriteLine("seguimos dando vueltas");
//}

// 2)

Console.WriteLine("Cuantas vueltas quiere dar?");

string respuesta = "";
var contador = 0;

while (respuesta.ToUpper() != "N" )
{
    contador++;
    Console.WriteLine("seguimos dando vueltas, vuelta numero " + contador);

    Console.WriteLine("quiere seguir dando vueltas? (S/N)");
    respuesta = Console.ReadLine();
}

