
// Borra la pantalla
Console.Clear();

// Pedimos al usuario que introduzca su nombre
Console.WriteLine("Hola, Ingrese su nombre:");

// Leemos el nombre del usuario
string nombre = Console.ReadLine();

// Pedimos al usuario que introduzca su apellido
Console.WriteLine("Ahora por favor ingrese su apellido:");

string apellido = Console.ReadLine();

// Mostramos el nombre
Console.Write("Hola " + nombre);
Console.WriteLine(", este es mi segundo programa."); // se pueden concatenar las dos lineas en la primera con un + al lado de nombre
                                                     // si no se puede escribir solo "write" para que no de el salto de linea y así quedan juntos


Console.WriteLine("Pulse una tecla para finalizar."); // se tiene que escribir para finalizar 
Console.ReadKey();                                   // se termina el programa al presionar una tecla


