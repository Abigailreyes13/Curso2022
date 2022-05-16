
///* Ejemplo del condicional if */

//// Pedir la edad al usuario

//Console.WriteLine("Introducir edad"); 
//int edad = int.Parse(Console.ReadLine());


//Console.WriteLine("La edad ingresada es: " + edad);

//Console.WriteLine("Ingrese su equipo de football");
//string equipo =  Console.ReadLine();

//// Verificar si es mayor de edad

//if (edad >= 18 && equipo == "boquita")
//{
//    Console.WriteLine("Usted es mayor de edad y un grande, por que así es boquita"); 

//}
//else
//    Console.WriteLine("Usted es menor de edad"); // cuando se tiene una sola linea de codigo en la condición no es necesario poner las llaves 


//Console.ReadKey();

// con control + k + x te permite seleccionar el pedazo de codigo que quieres escribir


// ejemplo de if-elseif-else

//Console.Write("Ingrese la edad: ");
//int edad1= int.Parse(Console.ReadLine());

//if (edad1 <0 || edad1 > 110)
//{
//    Console.WriteLine("La edad no es valida, ingrese un valor no negativo");
//}


//else if (edad1 < 0 || edad > 110)
//{
//    Console.WriteLine("La edad no es valida.");
//}
//else if (edad1 < 12)
//{
//    Console.WriteLine("Va a la primaria.");
//}
//else if (edad1 < 18)
//{
//    Console.WriteLine("Va al secundario.");
//}
//else if (edad1 < 28)
//{
//    Console.WriteLine("Va a la facultad.");
//}
//else
//{
//    Console.WriteLine("A trabajar no queda otra.");
//}


// Ejemplo de Switch

Console.WriteLine("Ingrese el primer numero");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero");
double numero2 = double.Parse(Console.ReadLine());


Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicacion");
Console.WriteLine("4 - Division");

Console.WriteLine("ingrese la operacion a realizar");
//string operacion = Console.ReadLine();
double operacion = double.Parse(Console.ReadLine());
double resultado = 0;


switch (operacion)
{ 
    case 1:
        resultado = numero1 + numero2;
        break;
    case 2:
        resultado = numero1 - numero2;
        break;
    case 3:
        resultado = numero1 * numero2;
        break;
    case 4 when numero2 != 0 :
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Operacion invalida");
        break;
}

Console.WriteLine("El resultado es: " + resultado);

