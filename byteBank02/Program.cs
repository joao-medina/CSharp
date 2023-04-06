using byteBank02;

Console.WriteLine("==============");
Console.WriteLine("=  ByteBank  =");
Console.WriteLine("==============");
Console.WriteLine();


Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "1234567890";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1414-X";
conta.numeroAgencia = 16;
conta.saldo = 1000;

Console.WriteLine("Titular: " + conta.titular.nome);
Console.WriteLine("CPF: " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("Conta: " + conta.conta);
Console.WriteLine("N° Agência: " + conta.numeroAgencia);
Console.WriteLine("Saldo: " + conta.saldo);


Console.WriteLine("Pressione Enter para encerrar o programa: ");
Console.ReadLine();
