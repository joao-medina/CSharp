using ex015fastFood;
using System;

class Programa
{
    static void Main(string[] args)
    {
        Pedido pedido = new Pedido();
        pedido.cliente = new Cliente();
        pedido.cliente.endereco = new Endereco();

        pedido.cliente.endereco.cidade = "Sampa";
        pedido.cliente.endereco.rua = "Rua do Além";
        pedido.cliente.endereco.numeroCasa = 19;
        pedido.cliente.nome = "André";
        pedido.cliente.saldo = 100;
        pedido.restaurante = "Mac Donuts";
        pedido.item = "Donuts";
        pedido.valorPedido = 34.25 ;

        Console.WriteLine("Cidade:            " + pedido.cliente.endereco.cidade);
        Console.WriteLine("Rua:               " + pedido.cliente.endereco.rua);
        Console.WriteLine("Número da casa:    " + pedido.cliente.endereco.numeroCasa);
        Console.WriteLine("Nome:              " + pedido.cliente.nome);
        Console.WriteLine("Saldo:             R$" + pedido.cliente.saldo);
        Console.WriteLine("Restaurante:       " + pedido.restaurante);
        Console.WriteLine("Pedido:            " + pedido.item);
        Console.WriteLine("Valor do pedido:   R$" + pedido.valorPedido);

        pedido.Pagar(pedido.cliente.saldo);

        Console.WriteLine("..........................................");
        Console.WriteLine("Saldo do cliente após a compra: R$" + pedido.cliente.saldo);

    }
}