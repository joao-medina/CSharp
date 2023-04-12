using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank02.Contas
{
    public class ContaCorrente
    {

        public string conta = "...";
        public int numeroAgencia = 0;

        private double saldo;
        public double Saldo
        {
            get { return this.saldo; }
            set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    this.saldo = value;
                }
            }
        }

        public ContaCorrente(string conta, int numeroAgencia)
        {
            this.conta = conta;
            this.numeroAgencia = numeroAgencia;
        }

        public Cliente.Cliente titular;

        //métodos
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TransferirAgencia(int agencia)
        {
            numeroAgencia = agencia;
        }

        public bool TransferirDinheiro(double valor, ContaCorrente destino)
        {
            if (saldo >= valor && valor > 0)
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
