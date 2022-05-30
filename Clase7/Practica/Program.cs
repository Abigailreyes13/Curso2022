//Escribe un programa que:

//1) Pida 10 números al usuario.
//2) Obtener la suma de todos los números ingresados.
//3) Obtener cual es el mayor de todos los números.
//4) Obtener cual es el menor de todos los números.
//5) Obtener el promedio de todos los números.
//6) Mostrar todos los números ingresados por pantalla.
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

//Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
//Pueden adjuntarnos el archivo .cs, o el codigo como texto.

int[] numeros = new int[10];
Console.WriteLine("Ingrese 10 números");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese Numero: {i+1} ");
    numeros[i] = int.Parse(Console.ReadLine());
}

// obtener la suma de todos los números ingresados

int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
        suma = suma + numeros[i];
}
Console.WriteLine($"La suma de todos los números es: {suma}");

// Obtener cual es el mayor de todos los números.

int númeromayor = numeros[0];

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > númeromayor)
    {
        númeromayor = numeros[i];
    }
}
Console.WriteLine($"El número mayor de todos es {númeromayor}");

//Obtener cual es el menor de todos los números.
int númeroMenor = numeros[0];

for (int i = 0; i < numeros.Length; i++)
{
    if (númeroMenor < numeros[0])
    {
        númeroMenor = numeros[0];
    }
}
Console.WriteLine($"El número menor de todos es {númeroMenor}");

//Obtener el promedio de todos los números.

double promedio = 0;

for (int i = 0; i < numeros.Length; i++)
{
    promedio += numeros[i];
    
}
promedio = promedio / numeros.Length;
Console.WriteLine($"El promedio es: {promedio}");


//Mostrar todos los números ingresados por pantalla.

Console.WriteLine($"Los numeros ingresados son:");

for (int i = 0; i < numeros.Length; i++)
{
   
    Console.WriteLine(numeros[i]);
}

//Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Console.WriteLine("los valores calculados en los puntos 2, 3, 4 y 5. son: ");

for (int i = 2; i < numeros.Length; i = i + 2)
{
    Console.WriteLine(numeros[i]);
}


//Me siento feliz 
