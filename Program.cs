using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace testando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numerosRandom();
        }
        static void numerosRandom()
        {
            Console.WriteLine("Qual o tamanho da senha?");
            var tamanhoDaSenha = int.Parse(Console.ReadLine());

            Console.WriteLine("Quais caracteres deseja inserir?[so letras]");
            var alfab = Console.ReadLine();

            Console.WriteLine("Quais numeros deseja colocar?");
            var numeros = int.Parse(Console.ReadLine());

            var numberLeng = numeros.ToString();
            Random oc = new Random();
          
            List<string> lista = new List<string>();
            
            for (var i = 0; i < tamanhoDaSenha; i++)
            {

                var indiceDaString = oc.Next(0, alfab.Length);
                
                var pegandoLetraDoRandomAlfa = alfab[indiceDaString];
                
                var k = pegandoLetraDoRandomAlfa.ToString();
              
                lista.Add(k);

                var indiceNumeros = oc.Next(0, numberLeng.Length);

                var pegandoNumeros = numberLeng[indiceNumeros];

                lista.Add(pegandoNumeros.ToString());
            }
            
            List<string> sublista = lista.GetRange(0, tamanhoDaSenha);
           
            Console.Clear();
            Console.Write("Senha : ");

            foreach (var item in sublista)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            
        }
    }
}
