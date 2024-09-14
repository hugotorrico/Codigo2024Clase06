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

void EjemploFuncionesAddSSortRemove()
{
    //input
    List<int> edades = new List<int>();
    edades.Add(20);
    edades.Add(30);
    edades.Add(21);
    edades.Add(18);

    //edades.Sort();
    //edades.Remove(30);
    //Console.WriteLine( edades.Contains(30));

    //output

    foreach (var item in edades)
    {
        Console.WriteLine(item);
    }

}


int CalcularMenorNotasListas(List<int> notas)
{
    int menor = notas[0];

    foreach (var item in notas)
    {
        if (item<menor)
        {
            menor = item;

        }

    }
    return menor;
}

int CalcularMayorNotasListas(List<int> notas)
{
    int mayor = notas[0];

    foreach (var item in notas)
    {
        if (item > mayor)
        {
            mayor = item;

        }

    }
    return mayor;
}

void ejemploFuncionesMinMax()
{
    List<int> notas = new List<int>();

    notas.Add(20);
    notas.Add(15);
    notas.Add(12);
    notas.Add(18);


    Console.WriteLine(notas.Min());//Usando funciones de la misma lista
    Console.WriteLine(CalcularMenorNotasListas(notas));

    Console.WriteLine(notas.Max());//Usando funciones de la misma lista
    Console.WriteLine(CalcularMayorNotasListas(notas));
}

void ejemploExpresionesLambda()
{
    List<int> notas = new List<int>();

    notas.Add(20);
    notas.Add(15);
    notas.Add(12);
    notas.Add(18);

    //Expresiones Lambda
    var notaspares = notas.Where(x => x % 2 == 0).ToList();

    foreach (var item in notaspares)
    {
        Console.WriteLine(item);
    }

}


void ejemploFuncionIndexOf()
{
    List<int> numeros = new List<int>();

    Console.WriteLine("Ingresa 7 números:");

    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Número {i + 1}: ");
        int numero = int.Parse(Console.ReadLine());
        numeros.Add(numero);
    }

    int numeroBuscar = 10;
    int indice = numeros.IndexOf(numeroBuscar);

    //Cuando índice vale -1, no lo encontró
    if (indice != -1)
        Console.WriteLine($"El número {numeroBuscar} se encuentra en el índice {indice}.");
    else
        Console.WriteLine($"El número {numeroBuscar} no está en la lista.");
}

void ejemploAddRange()
{
    List<string> paisesAmerica = new List<string>();
    paisesAmerica.Add("Perú");
    paisesAmerica.Add("Bolivia");
    paisesAmerica.Add("Colombia");
    paisesAmerica.Add("Chile");
    paisesAmerica.Add("Ecuador");

    List<string> paisesEuropa = new List<string>();
    paisesEuropa.Add("Francia");
    paisesEuropa.Add("Inglaterra");
    paisesEuropa.Add("Alemania");
    paisesEuropa.Add("España");

    List<string> paises = new List<string>();
    paises.AddRange(paisesAmerica);
    paises.AddRange(paisesEuropa);
}



Console.Read();
