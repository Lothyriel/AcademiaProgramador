namespace Calculadora
{
    public class Calculo
    {
        private string calculo;
        public static string numeroInvalido = "Número inválido";
        public static string operadorInvalido = "Operador inválido";

        public Calculo(double NumeroUm, double NumeroDois, double resultado, TipoOperacao operacao)
        {
            calculo = $"{NumeroUm} {mostrarOperacao(operacao)} {NumeroDois} = {resultado}";
        }
        public override string ToString()
        {
            return calculo;
        }
        private string mostrarOperacao(TipoOperacao operacao)
        {
            if (operacao == TipoOperacao.adicao)
                return "+";
            if (operacao == TipoOperacao.subtracao)
                return "-";
            if (operacao == TipoOperacao.multiplicacao)
                return "*";
            if (operacao == TipoOperacao.divisao)
                return "/";
            else
                return null;
        }
    }
}