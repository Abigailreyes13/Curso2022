//Ejercicio

//Crear un programa que cumpla con los siguientes pasos

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimension (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios



Console.WriteLine("Ingrese cantidad de alumnos");
int cantidadDeAlumnos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de notas para cada alumno");
int cantidadDeNotas = int.Parse(Console.ReadLine());

double [] promedios = new double[cantidadDeAlumnos];

int[,] numeros = new int[cantidadDeNotas, cantidadDeAlumnos];

int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//Recorrer la matriz para ingresas valores

for (int columna = 0; columna < lengthColumnas; columna++)
{
         
    Console.WriteLine($"Ingrese las notas del alumno: {columna + 1}: ");

    for (int Fila = 0; Fila < lengthFilas; Fila++)
    {
        Console.WriteLine($"cargue la nota N° {Fila + 1}");
        numeros[Fila, columna] = int.Parse(Console.ReadLine());
    }

}

// Recorrer la matriz para mostrar valores 

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine("==========================");

    Console.WriteLine($"Las notas del alumno {columna + 1} son: ");

    for (int Fila = 0; Fila < lengthFilas; Fila++)
    {
        Console.WriteLine($"La nota N° {Fila + 1}");
        Console.WriteLine(numeros[Fila, columna]);
    }
    
}

// Calcular promedios
for (int columa = 0; columa < lengthColumnas; columa++)
{
    Console.WriteLine("==========================");
    Console.WriteLine($"El promedio de las notas del alumno {columa + 1} es:");

    double suma = 0; 
    for (int Fila = 0; Fila < lengthFilas; Fila++)
    {
       suma = suma + numeros[Fila, columa];
    }
    Console.WriteLine($"{promedios[columa] = suma / lengthFilas}");
}
