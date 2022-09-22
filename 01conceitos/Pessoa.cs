using System;

public class Pessoa 
{
    
    public string pessoa(string nome)
    {
        return nome;
    } 
    public int idade;

    public void mensagem()
    {
        string nome = pessoa("junior");

        Console.WriteLine("ola "+nome+" voce tem "+idade+" anos");
    }
}