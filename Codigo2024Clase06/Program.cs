using static System.Runtime.InteropServices.JavaScript.JSType;

void EjemploListString()
{
   
    List<string> nombres = new List<string>();

    nombres.Add("Hugo");
    nombres.Add("Juan");
    nombres.Add("Janeth");


    for (int i = 0; i < nombres.Count; i++)
    {
        Console.WriteLine(nombres[i]);
    }

    Console.WriteLine("=================");

    //Usando el tipo de dato dinámico var
    foreach (var item in nombres)
    {
        Console.WriteLine(item);
    }

    //Usando el tipo de dato original
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }

}

void EjemploListInt()
{
    List<int> edades = new List<int>();

    edades.Add(20);
    edades.Add(30);
    edades.Add(21);
    edades.Add(18);

    foreach (var item in edades)
    {
        Console.WriteLine(item);
    }
}


//input
List<int> edades = new List<int>();
edades.Add(20);
edades.Add(30);
edades.Add(21);
edades.Add(18);

//edades.Sort();
//edades.Remove(30);
//Console.WriteLine( edades.Contains(30));


////business logic
//foreach (var item in edades)
//{
//    if (item%2==0)
//    {
//        edades.Remove(item);
//    }
//}

//output

foreach (var item in edades)
{
    Console.WriteLine(item);
}




Console.Read();
