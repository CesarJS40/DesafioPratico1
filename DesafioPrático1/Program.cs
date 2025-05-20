using System;

class Program
{
    static void Main()
    {
        var placa = Console.ReadLine();

        string alfanumericos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        int counter = 0;

        foreach (char i in placa)
        {
            if (alfanumericos.Contains(i))
            {
                counter++;
            }
        }

        if (counter == 7)
        {
            string letras = placa.Substring(0, 3);
            string numeros = placa.Substring(3, 4); // corrigido aqui

            bool letrasValidas = true;

            foreach (char i in letras)
            {
                if (!char.IsLetter(i))
                {
                    letrasValidas = false;
                    break;
                }
            }

            bool numerosValidos = true;

            foreach (char i in numeros)
            {
                if (!char.IsDigit(i))
                {
                    numerosValidos = false;
                    break;
                }
            }

            // Agora fora do foreach:
            if (numerosValidos && letrasValidas)
            {
                Console.WriteLine("VERDADEIRO!");
            }
            else
            {
                Console.WriteLine("FALSO");
            }
        }
        else
        {
            Console.WriteLine("Placa inválida: deve conter 7 caracteres alfanuméricos.");
        }
    }
}
