using System;

class ex020{
    static void Main(){
        int idade;
        idade = Convert.ToInt32(Console.ReadLine());

        int ano = idade/365;
        System.Console.WriteLine(ano + " ano(s)");
        int mes = (idade%365)/30;
        System.Console.WriteLine(mes + " mes(es)");
        int dias = ((idade%365)%30);
        System.Console.WriteLine(dias + " dia(s)");

    }
}