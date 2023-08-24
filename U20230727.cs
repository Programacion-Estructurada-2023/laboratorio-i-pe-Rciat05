using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {       


            //Parte 1

            //-Declarar una variable de tipo texto, capturando su valor desde la consola

            Console.WriteLine("---------Informacion Personal---------");

            Console.Write("Cual es tu departamento? ");
            string departamento = Console.ReadLine();

            Console.Write("Cual es su municipio? ");
            string municipio = Console.ReadLine();

            Console.Write("Cual es su ciudad? ");
            string ciudad = Console.ReadLine();


            //-Declarar dos variables de texto, asignando su valor desde la declaración
            string colonia = "Ciudad Pacifica";
            string colorCasa = "Amarillo";


            //-Declaración de dos variables de tipo enteras, asignando su valor desde consola.
            Console.Write("\nCuantos años lleva viviendo en su casa? ");
            int añosResidencia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cual es su edad? ");
            int edadActual = Convert.ToInt32(Console.ReadLine());


             //-Declarar dos variables de tipo date time, asignando su valor desde la declaración
            DateTime BornDate = new DateTime(2005, 5, 5);
            DateTime todayDate = DateTime.Now;


            //Parte 2

             bool comparacionCadenas = departamento == municipio;
            string concatenacionTexto = departamento + " - " + municipio;
            string mayusculaCiudad = ciudad.ToUpper();
            string limpiadoColonia = colonia.Trim();
            int longitudDepartamento = departamento.Length;
            int longitudMunicipio = municipio.Length;

             string formatoFechaNacimiento = BornDate.ToString("05/05/2005");
            DateTime nuevaFechaNacimiento = BornDate.AddDays(14);
            DateTime nuevaFechaActual = todayDate.AddDays(14);
            bool comparacionFechasMayor = BornDate > todayDate;
            bool comparacionFechasMenor = BornDate < todayDate;

            //Parte 3

            Console.WriteLine("------- Tus datos -------");
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Municipio: " + municipio);
            Console.WriteLine("Ciudad: " + ciudad);

        
            Console.WriteLine("\nInformación de vivienda:");
            Console.WriteLine("Colonia: " + colonia);
            Console.WriteLine("Color de su casa: " + colorCasa);


            Console.WriteLine("Comparación de cadenas: " + comparacionCadenas);
            Console.WriteLine("Concatenación de texto: " + concatenacionTexto);
            Console.WriteLine("Ciudad en mayúscula: " + mayusculaCiudad);
            Console.WriteLine("Colonia limpiada: " + limpiadoColonia);
            Console.WriteLine("Longitud de departamento: " + longitudDepartamento);
            Console.WriteLine("Longitud de municipio: " + longitudMunicipio);


              Console.WriteLine("Fecha de nacimiento formateada: " + formatoFechaNacimiento);
            Console.WriteLine("Nueva fecha de nacimiento: " + nuevaFechaNacimiento.ToString("10/05/2014"));
            Console.WriteLine("Nueva fecha actual: " + nuevaFechaActual.ToString("25/08/2023"));
            Console.WriteLine("Comparación de fechas (mayor): " + comparacionFechasMayor);
            Console.WriteLine("Comparación de fechas (menor): " + comparacionFechasMenor);
            Console.WriteLine("\nInformación de tiempo y Edad:");
            Console.WriteLine("Años de vivir en su residencia actual: " + añosResidencia);

            Console.WriteLine("Edad actual: " + edadActual);



            //Nota de autoevaluación: 10

            
        }
    }
}