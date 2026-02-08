using System;

class Program
{
    static void Main()
    {
        Inicio();
    }

    #region INICIO
    static void Inicio()
    {
        PrintText("\n\n=======================\nElige el ejercicio que quieres ejecutar :D ", ConsoleColor.Magenta);
        PrintText("1. Fibonacci\n2. Segundos a minutos/horas\n3. Apuesta\n4. Invertir mensaje", ConsoleColor.White);
        PrintText("=======================", ConsoleColor.Magenta);

        Console.ForegroundColor = ConsoleColor.Yellow;
        int sel = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;

        if (sel < 1 || sel > 4)
        {
            PrintText("ERROR!!!!! ese no es un ejercicio >:(", ConsoleColor.Red);
            Inicio();
        }

        switch (sel)
        {
            case 1:
                EjercicioUno();
                break;
            case 2:
                Console.WriteLine(EjercicioDos());
                Inicio();
                break;
            case 3:
                EjercicioTres();
                break;
            case 4:
                EjercicioCuatro();
                break;
        }
    }
    #endregion

    #region EJERCICIO #1: Escriba una función que imprima únicamente los números primos de la serie de Fibonacci hasta el n-ésimo término. :]
    static void EjercicioUno()
    {
        Console.WriteLine("Holi :]");
        PrintText("Ingresa el valor de n: ", ConsoleColor.Yellow);
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            PrintText("Por favor ingresa un número positivo :(", ConsoleColor.Red);
            return;
        }

        PrintText("\n========= RESULTADO =========", ConsoleColor.Green);
        PrintPrimosFibonacci(n);
        PrintText("============ FIN ============", ConsoleColor.Green);
    }

    static void PrintPrimosFibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 2; i < n; i++)
        {
            int siguiente = a + b;

            if (EsPrimo(siguiente))
            {
                Console.WriteLine(siguiente);
            }

            a = b;
            b = siguiente;
        }

        Inicio();
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        int limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    #endregion

    #region EJERCICIO #2: Escriba una función que reciba una cantidad entera de segundos y retorne un string que muestre esa cantidad en formato HH:MM:SS. NO utilizar la clase DateTime.
    static string EjercicioDos()
    {
        Console.WriteLine("Holi :]");
        PrintText("Ingresa el valor de segundos: ", ConsoleColor.Yellow);

        int totalSegundos = int.Parse(Console.ReadLine());

        if (totalSegundos < 0)
        {
            return "00:00:00";
        }

        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;

        PrintText("\n========= RESULTADO =========", ConsoleColor.Green);
        string resultado = $"{horas:D2}:{minutos:D2}:{segundos:D2}";

        return resultado;
    }
    #endregion

    #region EJERCICIO #3: el enunciado está muy largo, pero es el de apostar por un número
    static void EjercicioTres()
    {
        int apostado = 1000;

        PrintText("Ingresa el número ganador (4 cifras): ", ConsoleColor.Yellow);
        int resultado = int.Parse(Console.ReadLine());

        PrintText("Ingresa el número apostado (4 cifras): ", ConsoleColor.Yellow);
        int num = int.Parse(Console.ReadLine());

        if (resultado < 1000 || resultado > 9999 || num < 1000 || num > 9999)
        {
            Console.WriteLine("Error: ambos números deben tener 4 cifras");
            return;
        }

        int premio = DeterminarPremio(resultado, num, apostado);

        if (premio > 0)
        {
            PrintText("¡Ganaste :D! \nPremio: $" + premio, ConsoleColor.Green);
        }
        else
        {
            PrintText("No ganaste nada :(", ConsoleColor.Red);
        }

        Inicio();
    }

    static int DeterminarPremio(int resultado, int num, int apostado)
    {
        if (resultado == num)
        {
            return apostado * 4500;
        }

        if (MismasCifrasDesorden(resultado, num))
        {
            return apostado * 200;
        }

        if (resultado % 1000 == num % 1000)
        {
            return apostado * 400;
        }

        if (resultado % 100 == num % 100)
        {
            return apostado * 50;
        }

        if (resultado % 10 == num % 10)
        {
            return apostado * 5;
        }

        return 0;
    }

    static bool MismasCifrasDesorden(int resultado, int num)
    {
        string stringResultado = resultado.ToString();
        string stringRespuesta = num.ToString();

        int coincidencias = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < stringRespuesta.Length; j++)
            {
                if (stringResultado[i] == stringRespuesta[j])
                {
                    coincidencias++;
                    stringRespuesta = stringRespuesta.Remove(j, 1);
                    break;
                }
            }
        }

        return coincidencias == 4;
    }
    #endregion

    static void PrintText(string txt, ConsoleColor col)
    {
        Console.ForegroundColor = col;
        Console.WriteLine(txt);
        Console.ForegroundColor = ConsoleColor.White;
    }

    #region EJERCICIO #4: invertir mensaje

    static void EjercicioCuatro()
    {
        MessageManager manager = new MessageManager();

        Console.WriteLine("Holi :]");
        PrintText("Ingresa el mensaje: ", ConsoleColor.Yellow);

        manager.Print(Console.ReadLine());

        Inicio();
    }
}


abstract class AbstractSample
{
    private string message;
    public abstract void PrintMessage(string msg);
    public virtual string InvertMessage(string msg)
    {
        message = msg;

        char[] chars = message.ToCharArray();
        Array.Reverse(chars);

        message = new string(chars);

        return message;
    }

    protected string GetMessage()
    {
        return message;
    }

    protected void SetMessage(string msg)
    {
        message = msg;
    }
}

class PrintNormal : AbstractSample
{
    public override void PrintMessage(string msg)
    {
        InvertMessage(msg);

        string mensajeInvertido = GetMessage();
        char[] resultado = new char[mensajeInvertido.Length];

        for (int i = 0; i < mensajeInvertido.Length; i++)
        {
            if (char.IsUpper(mensajeInvertido[i]))
            {
                resultado[i] = char.ToLower(mensajeInvertido[i]);
            }
            else if (char.IsLower(mensajeInvertido[i]))
            {
                resultado[i] = char.ToUpper(mensajeInvertido[i]);
            }
            else
            {
                resultado[i] = mensajeInvertido[i];
            }
        }

        Console.WriteLine(new string(resultado));
    }
}

class PrintCapsInvertidas : AbstractSample
{
    public override void PrintMessage(string msg)
    {
        Console.WriteLine(InvertMessage(msg));
    }

    public override string InvertMessage(string msg)
    {
        base.InvertMessage(msg);
        string mensajeActual = GetMessage();
        string mensajeEnMinusculas = mensajeActual.ToLower();

        SetMessage(mensajeEnMinusculas);

        return mensajeEnMinusculas;
    }
}

class MessageManager
{
    AbstractSample abstractSample1;
    AbstractSample abstractSample2;

    public MessageManager()
    {
        abstractSample1 = new PrintNormal();
        abstractSample2 = new PrintCapsInvertidas();
    }

    public void Print(string msg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("========= RESULTADO =========");
        Console.ForegroundColor = ConsoleColor.White;

        abstractSample1.PrintMessage(msg);
        abstractSample2.PrintMessage(msg);
    }
}
#endregion