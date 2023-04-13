using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex015fastFood
{
    public class Pedido
    {
        public double valorPedido;
        public string item;
        public string restaurante;
        public Cliente cliente;


        public bool Pagar(double valor)
        {
            if (this. cliente.saldo >= this.valorPedido)
            {
                this.cliente.saldo -= this.valorPedido;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
