using byteBank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André Silva";
contaAndre.numeroAgencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

Console.WriteLine("Títular: " + contaAndre.titular);
Console.WriteLine("Agência: " + contaAndre.numeroAgencia);
Console.WriteLine("Conta: " + contaAndre.conta);
Console.WriteLine("Saldo: " + contaAndre.saldo);

contaAndre.Depositar(100);

Console.WriteLine("Saldo pós depósito: " + contaAndre.saldo);


bool saque = contaAndre.Sacar(300);

if(saque == true)
{
    Console.WriteLine("Saldo pós saque: " + contaAndre.saldo);
}
else
{
    Console.WriteLine("***Saldo insuficiente para realizar o saque***");
}


contaAndre.TransferirAgencia(16);
Console.WriteLine("Agência pós transferência: " + contaAndre.numeroAgencia);

Console.WriteLine("-");
Console.WriteLine("-");
Console.WriteLine("-");


ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Fibonacci";
contaMaria.numeroAgencia = 20;
contaMaria.conta = "1212-Y";
contaMaria.saldo = 130;

Console.WriteLine("Saldo da Maria incial: " + contaMaria.saldo);
Console.WriteLine("Saldo do André inicial: " + contaAndre.saldo);

bool transferencia = contaAndre.TransferirDinheiro(50, contaMaria);

if(transferencia == true)
{
    Console.WriteLine("Saldo da Maria pós transferência: " + contaMaria.saldo);
    Console.WriteLine("Saldo do André pós transferência: " + contaAndre.saldo);
}

else
{
    Console.WriteLine("***Saldo insuficiente para realizar transação***");
}

Console.WriteLine("-");
Console.WriteLine("-");
Console.WriteLine("-");

//valor padrão
ContaCorrente contaPedro = new ContaCorrente();
Console.WriteLine(contaPedro.titular);
Console.WriteLine(contaPedro.saldo);
Console.WriteLine(contaPedro.numeroAgencia);
Console.WriteLine(contaPedro.conta);

Console.WriteLine("Pressione Enter para encerrar o programa: ");
Console.ReadLine();
