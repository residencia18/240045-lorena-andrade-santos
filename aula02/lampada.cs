namespace tic18.lampada
{
    class Lampada
    {
        public bool Ligada { get; private set; }

        public void Ligar()
        {
            Ligada = true;
        }
        public void Desligar()
        {
            Ligada = false;
        }
        public void Imprimir()
        {
           Console.WriteLine($"Lampada {(Ligada ? "ligada" : "desligada")}");
        }
    }
}