using System;
using System.Collections.Generic;
using System.Linq;
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

            //numeros sort
            var alfab = "abcdefghijklmnopqrstuvwxyz";
            //instanciei um objeto da classe random
            Random oc = new Random();
            //criei uma lista do Tipo string
            List<string> lista = new List<string>(9);
            //criando e adicionando numeros sorteados na lista 
            for (var i = 0; i < 9; i++)
            {
                //peguei o objeto random e usei o metodo next para sortear um indice com base do tamanho da string
                var indiceDaString = oc.Next(0, alfab.Length);
                //pegando letra pelo o indice sorteado
                var pegandoLetraDoRandomAlfa = alfab[indiceDaString];
                //tranformando em string
                var k = pegandoLetraDoRandomAlfa.ToString();
                //Adicionando na lista
                lista.Add(k);

                //usando o metodo da classe random
                var ocv = oc.Next(0, 9);
                //adicionadno na lista e fazendo a conversão para string
                lista.Add(ocv.ToString());
            }
            //usando o metodo getRange para pegar 9 caracteres da lista
            List<string> sublista = lista.GetRange(0, 9);
            //percorrendo e retornando na tela o resultado
            foreach (var item in sublista)
            {
                Console.Write(item);
            }
            Console.WriteLine("");

        }
    }
}
