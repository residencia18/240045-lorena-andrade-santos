namespace tic18.data
{
    class Data
    {

        public const int FORMATO_12H = 12;
        public const int FORMATO_24H = 24;

        private readonly int dia;
        private readonly int mes;
        private readonly int ano;
        private readonly int? hora;
        private readonly int? minuto;
        private readonly int? segundo;

        public int Dia { get; private set; }
        public int Mes { get; private set; }
        public int Ano { get; private set; }
        public int? Hora { get; private set; }
        public int? Minuto { get; private set; }
        public int? Segundo { get; private set; }

        public Data(int _dia, int _mes, int _ano)
        {
            this.dia = _dia;
            this.mes = _mes;
            this.ano = _ano;
        }
        public Data(int _dia, int _mes, int _ano, int _hora, int _minuto, int _segundo) : this(_dia, _mes, _ano)
        {
            if (_hora >= 0 && _hora < 24)
            {
                this.hora = _hora;
                this.minuto = _minuto;
                this.segundo = _segundo;
            }
        }

        public void Imprimir(int formato)
        {
            string dataFormatada = $"{dia}/{mes}/{ano}";

            if (hora != null)
            {
                DateTime dataHora = new DateTime(ano, mes, dia, (int)hora, (int)minuto!, (int)segundo!);
                dataFormatada += " " + FormatarHora(dataHora, formato);
            }

            Console.WriteLine(dataFormatada);
        }

        private string FormatarHora(DateTime dataHora, int formatoHora)
        {
            string formato = formatoHora == FORMATO_12H ? "h:mm:ss tt" : "H:mm:ss";
            return dataHora.ToString(formato);
        }

    }
}