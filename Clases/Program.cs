// See https://aka.ms/new-console-template for more information


using Clases;


//Rectangulo : Es una generalización - Clase
//rectangulo : Es una especificación - Objeto 

Rectangulo rectangulo = new Rectangulo();
rectangulo.altura = 20;
rectangulo.base1 = 30;

Console.WriteLine("El área del rectángulo es: ");
Console.WriteLine(rectangulo.CalcularArea());

Console.WriteLine("El perímetro del rectángulo es:");
Console.WriteLine(rectangulo.CalcularPerimetro());


Persona persona = new Persona();


//Asignando el nombre la primera vez, en su momento creación
Persona persona1 = new Persona("Ronald", "Cuevas");

//Renombrando la propiedad nombres
persona1.RenombarNombres("Keoma");

Console.WriteLine(persona1.RetornarNombresCompletos());







Console.Read();
