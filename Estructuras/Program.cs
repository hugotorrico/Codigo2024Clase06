public struct Persona
{
    //Atributos o Propieadades
    public string nombre;
    public string ciudad;
    public int edad=0;
    public string direccion;

    public Persona()
    {
    }
}
public struct Producto
{
    public string nombre;
    public string marca;
    public double precio;
    public string codigo;
}
public struct Factura
{
    public string serie;
    public string cliente;
    public string ruc;
    public string direccion;
    public double total;
    public List<Producto> productos;

}

public struct Vacaciones
{
    public string lugar;
    public DateTime fechaInicio;
    public DateTime fechaFin;
    public double presupuesto;
}

public struct Curso
{
    public string profesor;
    public string nombre;
    public int ncreditos;
    public string carrera;
}


    class Program
{
    static void Main(string[] args)
    {

        //new  Crear una instancia

        //Primera persona
        Persona persona1 = new Persona();
        persona1.edad = 36;
        persona1.ciudad = "Lima";
        persona1.nombre = "Hugo";

        //Segunda persona
        Persona persona2 = new Persona();
        persona2.edad = 8;
        persona2.ciudad = "Ica";
        persona2.nombre = "Reyna";

        //Tercera persona
        Persona persona3 = new Persona();
        persona3.edad = 6;
        persona3.ciudad = "Nasca";
        persona3.nombre = "Dérek";


        List<Persona> personas = new List<Persona>();

        personas.Add(persona1);
        personas.Add(persona2);
        personas.Add(persona3);


        foreach (var item in personas)
        {
            Console.WriteLine("============");
            Console.WriteLine(item.nombre);
            Console.WriteLine(item.edad);
            Console.WriteLine(item.ciudad);
           
        }


    
        Console.Read();

    }
}



