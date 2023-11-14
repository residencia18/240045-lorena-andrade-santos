#region foreach
    string[] pessoas = {"Maria", "Joana", "Carla", "Francine"};
    foreach (string pessoa in pessoas)
    {
        Console.WriteLine(pessoa);
    }
#endregion

#region exercico1 multiplos de 3 ou 4
    Console.WriteLine("exercico1 multiplos de 3 ou 4");
    Console.WriteLine();
    for (int i = 0; i < 30; i++)
        if((i % 3)==0 || (i % 4)==0)
             Console.WriteLine(i);
#endregion

#region exercico2 fibonacci
    Console.WriteLine("fibonacci");
    Console.WriteLine();
    int fib1 = 0;
    int fib2 = 1;

    int fib3 = fib1+fib2;
    
    Console.WriteLine(fib1);
    Console.WriteLine(fib2);
    Console.WriteLine(fib3);

    while (fib3<100)
    {
        Console.WriteLine(fib3);
        fib1 = fib2;
        fib2 = fib3;

        fib3 = fib1+fib2;
    }
#endregion


#region exercico3
Console.WriteLine("exercico3");
Console.WriteLine();
    for (int i = 1; i <=8; i++){
        for(int j = 1; j <=i; j++){
            Console.Write((i * j) + " ");
        }
        Console.WriteLine();
    }
#endregion


 #region stringData
    string dataString = "25/10/2023";
    string[] partesData = dataString.split('/');

    string dia, mes, ano;

    dia = partesData[0];
    mes = partesData[1];
    ano = partesData[2];

    Console.WriteLine("Dia: " + dia);
    Console.WriteLine("Mês: " + mes);
    Console.WriteLine("Ano: " + ano);
 #endregion