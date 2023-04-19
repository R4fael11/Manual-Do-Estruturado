using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoSintaxe.ParadigmaEstruturado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Comentário de múltiplas linhas
             */

            //declaração de variáveis
            //variáveis de valor
            int idade = 43;
            float altura = 1.79f;
            decimal salario = 9000.50m;
            double media = 5.78;
            //Documentação oficial dos tipos
            //Microsoft e Tabelas do Google
            //variáveis de referência
            string nome = "Rafael Henrique Calado";
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome);
            Console.WriteLine(nome.Substring(16));

            //Estrtura de seleção(condição)
            if (idade >= 40)
                Console.WriteLine("Super Jovem-Jovem!");

            if (idade <= 17)
            {
                Console.WriteLine("Hiper Jovem-Jovem");
            }

            var vencedor = "Rafael ";
            bool venceu = false;
            if(venceu)
            {
                Console.WriteLine("É muito dinheiro!" +vencedor);
            }
            else
            {
                Console.WriteLine(vencedor+  "Vai trabalhar corno!!");
            }

            //Switch (if comando)
            var mes = 5;
            if (mes == 1)
            {
                Console.WriteLine("Janeiro");
            }
            else if (mes == 2)
            {
                Console.WriteLine("Fevereiro");
            }
            else if (mes == 3)
            {
                Console.WriteLine("Março");

            }
            else if (mes == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (mes == 5)
                Console.WriteLine("Maio");
            
            else if (mes == 6)
            { 
                Console.WriteLine("Junho");
            }
            else if (mes == 7)
            {
                Console.WriteLine("Julho");
            }
            else if (mes == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (mes == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (mes == 10)
            {
                Console.WriteLine("Outubro");
            }
            else if (mes == 11)
            {
                Console.WriteLine("Novembro");
            }
            else if (mes == 12)
            {
                Console.WriteLine("Dezembro");
            }
           

            switch (mes)
            {
             case 1 :Console.WriteLine("Janeiro");break;

                case 2 :Console.WriteLine("Fevereiro");break;

             case 3 :Console.WriteLine("Março");break;

                case 4 :Console.WriteLine("Abril");break;

             case 5 :Console.WriteLine("Touro");break;

                case 6 :Console.WriteLine("Junho");break;

             case 7 :Console.WriteLine("Julho");break;

                case 8 :Console.WriteLine("Agosto");break;

             case 9 :Console.WriteLine("Setembro");break;

                case 10 :Console.WriteLine("Outubro");break;

             case 11 :Console.WriteLine("Novembro");break;

                case 12 :Console.WriteLine("Dezembro");break;

            

            }

            int contador = 1;
            while (contador <= 3)
            {
                Console.WriteLine("Rafael Henrique");
                contador = contador + 1;
            }
            Console.WriteLine("Agora utilizando o while");
            contador = 1;
            do
            {

            } 
            while (contador <= 3);

            for (int i=1;i<=3;i=i+1)
            {
                Console.WriteLine("Rafael");
            }

            Console.ReadKey();
        }
    }
}
