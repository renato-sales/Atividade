using System;
namespace Atividade
{
    class Program
    {
        public static void Main(string[] args)
        {
            float valor;
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Pessoa Fisica (f) ou Pessoa Jurídica(j): ");
            string tipoPessoa = Console.ReadLine();

            if(tipoPessoa.Equals("f"))
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = nome;
                pf.endereco = endereco;
                Console.Write("Informe o cpf: ");
                pf.cpf = Console.ReadLine();
                Console.Write("Informe o rg: ");
                pf.rg = Console.ReadLine();
                Console.Write("Informe o valor de compra: ");
                valor = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(valor);
                Console.WriteLine("------ Pessoa Física ------");
                Console.WriteLine($"Nome...........:{pf.nome}");
                Console.WriteLine($"Endereço.......:{pf.endereco}");
                Console.WriteLine($"Cpf............:{pf.cpf}");
                Console.WriteLine($"Rg.............:{pf.rg}");
                Console.WriteLine($"Valor da compra:{pf.valor.ToString("C")}");
                Console.WriteLine($"Valor imposto..:{pf.valor_imposto.ToString("C")}");
                Console.WriteLine($"Total a pagar..:{pf.total.ToString("C")}");
            }
            else if(tipoPessoa.Equals("j"))
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = nome;
                pj.endereco = endereco;
                Console.Write("Informe o cnpj: ");
                pj.cnpj = Console.ReadLine();
                Console.Write("Informe a inscrição estadual: ");
                pj.ie = Console.ReadLine();
                Console.Write("Informe o valor de compra: ");
                valor = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(valor);
                Console.WriteLine("------ Pessoa Jurídica ------");
                Console.WriteLine($"Nome..............:{pj.nome}");
                Console.WriteLine($"Endereço..........:{pj.endereco}");
                Console.WriteLine($"Cnpj..............:{pj.cnpj}");
                Console.WriteLine($"Inscrição estadual:{pj.ie}");
                Console.WriteLine($"Valor da compra...:{pj.valor.ToString("C")}");
                Console.WriteLine($"Valor imposto.....:{pj.valor_imposto.ToString("C")}");
                Console.WriteLine($"Total a pagar.....:{pj.total.ToString("C")}");
            }
        }
    }
}
