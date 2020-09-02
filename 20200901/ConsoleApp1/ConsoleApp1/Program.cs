using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			
			int intento = 3;
			int entrada;
			byte i, adivinado;
			string linea;

	
			Random random = new Random();
			int numero = random.Next(20);

			i = 1; adivinado = 0;
			do
			{
				Console.Write("Ingrese un numero entre 1 y 20: ");
				linea = Console.ReadLine();
				entrada = int.Parse(linea);

				if ((entrada == numero))
				{
					Console.WriteLine("Adivinaste el numero!");
					adivinado = 1;
				}
				
				i++;
			} 
			while (((i <= intento) & (adivinado == 0)));
			if ((adivinado == 0))
			{
				Console.Write("No adivinaste, el numero era: " + numero);
			}

			
		}
    }
}
