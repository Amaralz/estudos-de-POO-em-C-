using System;

public class Pessoa 
{
    public double peso;
    public double altura;
    public double calculo ()
    {
         double recebePeso;

        return  recebePeso = peso / (altura * altura);
    }
    public string IMC(double r)
    {
        /*
        return r >= 40 ? "obesidade 3" : "obesidade 2";
        return r < 35 ? "obesidade 1" : "acima do peso";
        return r < 25 && r > 18.5 ? "peso normal" : "abaixo do peso";
        */
        if (r >= 40)
        {
            return "obesidade 3";
        }
        if (r < 40 && r >= 35 ) 
        {
            return "obesidade 2";
        }
        if (r < 35 && r >= 30 )
        {
            return "obesidade 1";
        }
        if (r < 30 && r >= 25)
        {
            return "acima do peso";
        }
        else if (r < 25 && r >= 18.5 )
        {
            return "peso normal";
        }
        else
        {
            return "abaixo do peso";
        }
    }

    public void mensagem()
    {
        double setmedia = calculo();
        string resp = IMC(setmedia);

         Console.WriteLine(resp);
    }
}