using System;
namespace Atividade
{
     class Program
     {
    static void Main(string[] args)
    {
      float val_pag;
      Console.WriteLine("Informar Nome");
      String Var_nome = Console.ReadLine();
      Console.WriteLine("Informar Endereço");
      String Var_endereco = Console.ReadLine();
      Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
      string var_tipo = Console.ReadLine();
      if (var_tipo == "f")
      {
        //---Pessoa Fisica---
        Pessoa_Fisica pf = new Pessoa_Fisica();
        pf.nome = Var_nome;
        pf.endereco = Var_endereco;
        Console.WriteLine("Informar CPF");
        pf.cpf = Console.ReadLine();
        Console.WriteLine("Informar RG");
        pf.rg = Console.ReadLine();
        Console.WriteLine("Informar Valor de compra:");
        val_pag = float.Parse(Console.ReadLine());
        pf.Pagar_Imposto(val_pag);
        Console.WriteLine("--------- Pessoa Física ---------");
        Console.WriteLine("Nome ..........: " + pf.nome);
        Console.WriteLine("Endereço ......: " + pf.endereco);
        Console.WriteLine("CPF ...........: " + pf.cpf);
        Console.WriteLine("RG ............: " + pf.rg);
        Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
        Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
        Console.WriteLine("Total a Pagar : " + pf.total.ToString("C"));
      }
      if (var_tipo == "j")
      {
        // Pessoa Jurídica
        Pessoa_Juridica pj = new Pessoa_Juridica();
        pj.nome = Var_nome;
        pj.endereco = Var_endereco;
        Console.WriteLine("Informar CNPJ");
        pj.cnpj = Console.ReadLine();
        Console.WriteLine("Informar IE");
        pj.ie = Console.ReadLine();
        Console.WriteLine("Informar Valor de compra");
        val_pag = float.Parse(Console.ReadLine());
        pj.Pagar_Imposto(val_pag);
        Console.WriteLine("------------ Pessoa Jurídica ------------");
        Console.WriteLine("Nome ..........: " + pj.nome);
        Console.WriteLine("Endereço ......: " + pj.endereco);
        Console.WriteLine("CNPJ ..........: " + pj.cnpj);
        Console.WriteLine("IE ............: " + pj.ie);
        Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
        Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
        Console.WriteLine("Total a Pagar : " + pj.total.ToString("C"));
     }
   }
  }
}
      