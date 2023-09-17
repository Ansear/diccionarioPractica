internal class Program
{
    private static void Main(string[] args)
    {
        //Crear Diccionario
        Dictionary<string,string> openW = new Dictionary<string,string>();
        
        //Metodo para Añadir pares clave-valor al diccionario
        openW.Add("txt","notepad.exe");
        openW.Add("bmp","paint.exe");
        openW.Add("dip","paint.exe");
        openW.Add("rtf","wordpad.exe");

        try
        {
            //Intentar agregar un par clave-valor ya existente
            openW.Add("txt","winword.exe");
        }
        catch(ArgumentException)
        {
            //No se puede tener claver repetidas
            Console.WriteLine("Un elemento con la clave = \"txt\" ya existe.");
        }

        //Se crea una variable para almacenar la coleccion de claves del diccionario openW
        Dictionary<string,string>.KeyCollection keyColl = openW.Keys;
        
        foreach (string key in keyColl)
        {
            //Se recorre y se muestra solo la clave
            Console.WriteLine(key);
        }
        //Se recorre el diccionario, esperando tipo de dato pair
        foreach (KeyValuePair<string,string> pair in openW)
        {
            
            //Se muestra la clave y el valor, accediento a .Key y .Value
            Console.WriteLine("Llave {0} - Valor {1}",pair.Key,pair.Value);
        }

        //Se crea una variable para almacenar la coleccion de valores del diccionario openW
        Dictionary<string,string>.ValueCollection ValColl = openW.Values;
        
        foreach (string value in ValColl)
        {
            //Se recorre y se muestra solo la el valor
            Console.WriteLine(value);
        }
        
        //Limpiar las claves y valores del diccionario
        openW.Clear();
        //Mostrar las cantiddad de elemntos del diccionario
        Console.WriteLine("Total de datos en el diccionario: " + openW.Count);
    
        //Buscar si en una coleccion esta un valor especifico
        //ContainsValue()
        if(openW.ContainsValue("notepad")){
            Console.WriteLine("El valor se encuentra registrado.");
        }else{
            Console.WriteLine("El valor no se encuentra registrado.");
        }

        Dictionary<string,string>.ValueCollection valueColl = openW.Values;
        //Elminar el valor con la clave especifica del diccionario
        openW.Remove("dip");

        foreach(string valor in valueColl){
            Console.WriteLine(valor);
        }
    }
}