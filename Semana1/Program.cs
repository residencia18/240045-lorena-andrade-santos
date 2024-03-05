// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region TipoDados

    int tipoInteiro;
    double tipoDouble;
    decimal tipoDecimal;
    float tipoFloat;
    long tipoLong;

    tipoInteiro = int.MaxValue;
    tipoDouble = double.MaxValue;
    tipoDecimal = decimal.MaxValue;
    tipoFloat = float.MaxValue;
    tipoLong = long.MaxValue;

    Console.WriteLine($"Este valor {tipoInteiro} é o maior inteiro possível");
    Console.WriteLine($"Este valor {tipoDouble} é o maior double possível");
    Console.WriteLine($"Este valor {tipoDecimal} é o maior decimal possível");
    Console.WriteLine($"Este valor {tipoFloat} é o maior float possível");
    Console.WriteLine($"Este valor {tipoLong} é o maior long possível");
#endregion

