using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank02
{
    public class ContaCorrente
    {

        public string conta = "...";
        public int numeroAgencia = 0;
        public double saldo = 0;

        public Cliente titular;

        //métodos
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TransferirAgencia(int agencia)
        {
            this.numeroAgencia = agencia;
        }

        public bool TransferirDinheiro(double valor, ContaCorrente destino)
        {
            if (this.saldo >= valor && valor > 0)
            {
                this.Sacar(valor);
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
