using tic18.lampada;
using tic18.data;

#region Lampada
    Lampada lampada1 = new();
    lampada1.Ligar();
    lampada1.Imprimir();

    lampada1.Desligar();
    lampada1.Imprimir();
#endregion

#region Data
    Data data = new(12, 12, 2022);
    data.Imprimir(12);
    data = new(14, 03, 2024, 13, 10, 10);
    data.Imprimir(12);
#endregion