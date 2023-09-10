using FluentAssertions;
using Xunit;

namespace EsquerdaVolver
{
    public class Direcao
    {
        private enum EDirecaoEnum
        {
            N,
            L,
            S,
            O
        }
        private EDirecaoEnum EDirecao { get; set; }

        public void InterretarComandos(string comandos)
        {
            var este = this;
            foreach (var comando in comandos)
            {
                if (comando == 'D')
                    este++;
                else if (comando == 'E')
                    este--;
            }
        }

        public override string ToString()
        {
            return EDirecao.ToString();
        }

        public static Direcao operator ++(Direcao d)
        {
            if(++d.EDirecao > EDirecaoEnum.O)
                d.EDirecao = EDirecaoEnum.N;

            return d;
        }
        public static Direcao operator --(Direcao d)
        {
            if (--d.EDirecao < EDirecaoEnum.N)
                d.EDirecao = EDirecaoEnum.O;

            return d;
        }
    }
    public class UnitTest1
    {
        [Fact]
        public void Case1()
        {
            var direcaoAtual = new Direcao();

            direcaoAtual.InterretarComandos("DDE");

            direcaoAtual.ToString().Should().Be("L");
        }

        [Fact]
        public void Case2()
        {
            var direcaoAtual = new Direcao();

            direcaoAtual.InterretarComandos("EE");

            direcaoAtual.ToString().Should().Be("S");
        }

        [Fact]
        public void Case3()
        {
            var direcaoAtual = new Direcao();

            direcaoAtual.InterretarComandos("EEEEEEEE");

            direcaoAtual.ToString().Should().Be("N");
        }
    }
}