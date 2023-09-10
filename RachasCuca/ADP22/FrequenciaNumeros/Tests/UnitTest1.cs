using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MetodoSemDicionario()
        {
            var qntNumeros = 7;
            var numeros = new int[] { 8, 10, 8, 260, 4, 10, 10 };

            var contados = new bool[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (contados[i] == true)
                    continue;

                int qnt = 0;
                for (int j = i; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        qnt++;
                        contados[j] = true;
                    }
                }
                Debug.WriteLine($"O numero: {numeros[i]} aparece {qnt} vezes");
            }
        }

        [Fact]
        public void MetodoComDicionario()
        {
            var qntNumeros = 7;
            var numeros = new int[] { 8, 10, 8, 260, 4, 10, 10 };

            var ocorrencias = new Dictionary<int, int>();

            foreach (var numero in numeros)
            {
                if (ocorrencias.ContainsKey(numero))
                {
                    ocorrencias[numero]++;
                }
                else
                {
                    ocorrencias[numero] = 0;
                }
            }
            foreach (var item in ocorrencias)
            {
                Debug.WriteLine($"O numero: {item.Key} aparece {item.Value} vezes");
            }
        }
    }
}