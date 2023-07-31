using System;
using System.Security.Cryptography;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args){
            float val_pag;
            Console.WriteLine("Informe o nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informe o edereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (f) ou juridica (j) ");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "f"){
                //------Pessoa Fisica------------------------------
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informe o cpf: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o rg: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("------------- Pessoa Fisica -------------");
                Console.WriteLine("Nome ...............: " + pf.nome);
                Console.WriteLine("Endereço............: " + pf.endereco);
                Console.WriteLine("CPF.................: " + pf.cpf);
                 Console.WriteLine("RG.................: " + pf.rg);
                Console.WriteLine("Valor de Compra.....: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto.............: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar       : " + pf.total.ToString("C"));
            }
                if(var_tipo == "j"){
                //------Pessoa Juridca------------------------------
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informe o cnpj: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe o ie: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("------------- Pessoa Juridica -------------");
                Console.WriteLine("Nome ...............: " + pj.nome);
                Console.WriteLine("Endereço............: " + pj.endereco);
                Console.WriteLine("CNPJ................: " + pj.cnpj);
                 Console.WriteLine("IE.................: " + pj.ie);
                Console.WriteLine("Valor de Compra.....: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.............: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar       : " + pj.total.ToString("C"));





            }


        }
    }
    }
