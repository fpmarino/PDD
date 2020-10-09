using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }

        public static void Listas()
        {
            int[] numeros = new int[3];
            numeros[0] = 1;

            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add("");
            lista.Add(new Auto());

            List<int> listadenumeros = new List<int>(); //permite valores duplicados y estan ordenados como los voy agregando
            listadenumeros.Add(1);
            listadenumeros.Add(1);
            listadenumeros.Add(1);

            HashSet<int> numerosunicos = new HashSet<int>(); //estan ordenados a traves del hash del valor que estoy agregando
            numerosunicos.Add(1);
            numerosunicos.Add(1);
            numerosunicos.Add(1);
            numerosunicos.Add(1);

            Dictionary<int, string> personas = new Dictionary<int, string>(); //me permite asignar dos tipos de valores, clave y valor
            personas.Add(26994130, "Gabriel");
            personas.Add(5122111, "Facundo");

            personas.GetValueOrDefault(269944130);

            Dictionary<string, Vehiculo> Autos = new Dictionary<string, Vehiculo>();

            Autos.Add("aa123aa", new Auto());
            Autos.Add("ab123aa", new Auto());
            Autos.Add("ab122aa", new Auto());

            Autos.GetValueOrDefault("aa123aa");

        }

        public static void Errores()
        {
            Vehiculo miauto = new Auto();
            Auto otroauto = new Auto();
            Vehiculo camion = new Camion();
            try
            {
                miauto.Marca = "Honda";
                miauto.Modelo = "Civic";
                //((Auto)camion).Puertas = 5;
                miauto.Motor = new CuatroCilindros();
                miauto.Arrancar();
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine("El valor no es del tipo auto");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("El valor no es del tipo auto");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //cierro los recursos que se crearon en el try
            {
                Console.WriteLine(miauto.Marca);
            }

            Console.ReadLine();
            if(camion is Auto)
            {

            }

        }
    }
}
