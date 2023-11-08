
Console.WriteLine("2. Tipos de Dados");
Console.WriteLine();


#region 2. Tipos de Dados
    //Números inteiros:
        
    //O Int no geral é utilizado para números considerados razoavéis
    int idade = 30; //Exemplo para representar a idade de uma pessoa

    //O long é utilizado para armazenar números inteiros muito grandes
    long numeroDeSerie = 12345678901234567;//Exemplo número de série de um produto

    //O short é adequado para armazenar números inteiros menores,
    short numeroDePorta = 80;//Exemplo número de porta de rede

    Console.WriteLine($"\tPedro tem {idade} anos.");
    Console.WriteLine($"\tO numero de serie do notebook eh: {numeroDeSerie}.");
    Console.WriteLine($"\tPara o app HelloWorld vamos utilizar a porta {numeroDePorta}.");
    Console.WriteLine();
#endregion

Console.WriteLine("3. Conversão de Tipos de Dados");
Console.WriteLine("");

#region 3. Conversão de Tipos de Dados
    //uma variável do tipo double e deseja convertê-la em um tipo int

    double numeroDouble = 50.99;
    int numeroInteiro = (int)numeroDouble;//Converter dessa forma não da erro na execuçõa do programna mas a parte fracionada é dispensada

    Console.WriteLine("\tNúmero Double: " + numeroDouble);
    Console.WriteLine("\tNúmero Inteiro: " + numeroInteiro);
    Console.WriteLine();

    //Se fosse converter dessa maneira dá erro de execução e o programa é interrompido porque não é uma conversao hierarquicamente possível pois há perda de dados
    //numero = int.Parse(numeroD.ToString());
#endregion
Console.WriteLine("4. Operadores Aritméticos");
Console.WriteLine();

#region 4. Operadores Aritméticos
    int x = 10;
    int y = 3;

    double divisao = (double) x / y;
    //o resultado da adição, subtração, multiplicação e divisão de x por y.
    Console.WriteLine($"\t{x} + {y} = {x + y}");
    Console.WriteLine($"\t{x} - {y} = {x - y}");
    Console.WriteLine($"\t{x} * {y} = {x * y}");
    Console.WriteLine($"\t{x} / {y} = {divisao}");
    Console.WriteLine();
#endregion

Console.WriteLine("5. Operadores de Comparação");
Console.WriteLine();

#region 5. Operadores de Comparação
    int a = 5;
    int b = 8;

    if (a > b)
    {
        Console.WriteLine($"\t{a} é maior que {b}.");
    }else
    {
        Console.WriteLine($"\t{b} é maior que {a}.");
    }
    Console.WriteLine();
#endregion

Console.WriteLine("6. Operadores de Igualdade");
Console.WriteLine();
#region 6. Operadores de Igualdade
    string str1 = "Hello";
    string str2 = "World";
    if (str1 == str2)
    {
        Console.WriteLine("\tAs strings são iguais.");
    }else
    {
        Console.WriteLine("\tAs strings são diferentes.");
    }
    Console.WriteLine();
#endregion

Console.WriteLine("7. Operadores Lógicos");
Console.WriteLine();
#region 7. Operadores Lógicos
    bool condicao1 = true;
    bool condicao2 = false;

    if (condicao1 && condicao2)
    {
        Console.WriteLine("\tAs duas condições são verdadeiras.");
    }else
    {
        Console.WriteLine("\tPelo menos uma das condições não é verdadeira.");
    }
Console.WriteLine();
#endregion

Console.WriteLine("8. Desafio de Mistura de Operadores");
Console.WriteLine();

#region 8. Desafio de Mistura de Operadores
    int num1 = 7;
    int num2 = 3;
    int num3 = 10;

    Console.WriteLine($"\tDadas as variáveis int num1 = {num1}, int num2 = {num2}, e int num3 = {num3}");
    if ((num1>num2) && (num3==(num1+num2)))
    {
        Console.WriteLine("\tSIM: (num1 é maior do que num2 e num3 é igual a (num1 + num2)) - Verdadeiro");
    }else
    {
        Console.WriteLine("\tNAO: (num1 é maior do que num2 e num3 é igual a (num1 + num2)) - Falso");
    }


#endregion
