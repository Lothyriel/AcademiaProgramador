using System.Collections.Generic;

namespace Escrevendo_Celular
{
    public class EscrevendoCelular
    {
        private Dictionary<char, string> Caracteres = new Dictionary<char, string>();
        private Dictionary<string, char> Numeros = new Dictionary<string, char>();
        public EscrevendoCelular()
        {
            Caracteres.Add('a', "2");
            Caracteres.Add('b', "22");
            Caracteres.Add('c', "222");
            Caracteres.Add('d', "3");
            Caracteres.Add('e', "33");
            Caracteres.Add('f', "333");
            Caracteres.Add('g', "4");
            Caracteres.Add('h', "44");
            Caracteres.Add('i', "444");
            Caracteres.Add('j', "5");
            Caracteres.Add('k', "55");
            Caracteres.Add('l', "555");
            Caracteres.Add('m', "6");
            Caracteres.Add('n', "66");
            Caracteres.Add('o', "666");
            Caracteres.Add('p', "7");
            Caracteres.Add('q', "77");
            Caracteres.Add('r', "777");
            Caracteres.Add('s', "7777");
            Caracteres.Add('t', "8");
            Caracteres.Add('u', "88");
            Caracteres.Add('v', "888");
            Caracteres.Add('w', "9");
            Caracteres.Add('x', "99");
            Caracteres.Add('y', "999");
            Caracteres.Add('z', "9999");
            Caracteres.Add(' ', "0");

            Numeros = Caracteres.ToDictionary(x=>x.Value, x=>x.Key);
        }
        public string FraseToNumeros(string fraseEntrada)
        {
            var palavras = fraseEntrada.ToLowerInvariant().Select(x => x == ' ' ? "_" : Caracteres[x]);
            return string.Join("", palavras);
        }

        public string NumerosToFrase(string numeros)
        {
            var pedacos = numeros.Split('_');
            var convertidos = pedacos.Select(x => Numeros[x]);
            return new string(convertidos.ToArray());
        }
    }
}