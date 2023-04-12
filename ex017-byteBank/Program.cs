using byteBank02.Cliente;
using byteBank02.Contas;

Console.WriteLine("      ==============");
Console.WriteLine("      =  ByteBank  =");
Console.WriteLine("      ==============");
Console.WriteLine();


Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "1234567890";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente("1414-X", 16);
conta.titular = cliente;
conta.Saldo = 1000;

Console.WriteLine("    Titular: " + conta.titular.nome);
Console.WriteLine("        CPF: " + conta.titular.cpf);
Console.WriteLine("  Profissão: " + conta.titular.profissao);
Console.WriteLine("      Conta: " + conta.conta);
Console.WriteLine(" N° Agência: " + conta.numeroAgencia);
Console.WriteLine("      Saldo: " + conta.Saldo);


Console.WriteLine("Pressione Enter para encerrar o programa: ");
Console.ReadLine();
