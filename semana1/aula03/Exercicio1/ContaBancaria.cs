using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03.Exceptions;

namespace Aula03.Exercicio1
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {

            try
            {
                if (valor <= 0)
                    throw new ValorInvalidoException();

                Saldo += valor;
                Console.WriteLine($"Depósito de {valor} realizado com sucesso.");
            }
            
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine($"Erro ao depositar: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao depositar: {ex.Message}");
            }
        }

        public void Transferir(double valor, ContaBancaria conta)
        {

            try
            {
                if (valor <= 0)
                    throw new ValorInvalidoException();
                else if (Saldo < valor)
                    throw new SaldoInsuficienteException();

                Saldo -= valor;
                conta.Depositar(valor);

                Console.WriteLine($"Transferência de {valor} realizada com sucesso.");
            }
            catch (ValorInvalidoException ex)
            {
                Console.WriteLine($"Erro ao transferir: {ex.Message}");
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine($"Erro ao transferir: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao transferir: {ex.Message}");
            }
        }

    }
}