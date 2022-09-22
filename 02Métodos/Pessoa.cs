using System;

class Pessoa
{
    // Método 01
    public void apresentar()
    {
        Console.WriteLine("olá!!!");
    }
    // Método 02
    public void apresentar(string nome)
    {
        Console.WriteLine("olá!!!"+ nome);
    }
    // Método 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("ola" +nome+" voce tem "+idade+ " anos");
    }
}
