using System;
using Xunit;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;

namespace LendaFlaviusJosephus
{
    public class FlaviusJosephus
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(4, 1)]
        [InlineData(5, 3)]
        [InlineData(6, 5)]
        [InlineData(7, 7)]
        [InlineData(8, 1)]
        [InlineData(9, 3)]
        [InlineData(10, 5)]
        [InlineData(11, 7)]
        [InlineData(12, 9)]
        [InlineData(13, 11)]
        [InlineData(14, 13)]
        [InlineData(15, 15)]
        [InlineData(16, 1)]
        [InlineData(41, 19)]
        public void ShouldBeCorrectLastStandingPositionLog(int qntSoldados, int posicaoUltimoVivoEsperada)
        {
            var logQntSoldadosBaseDois = (int)Math.Log(qntSoldados, 2);
            var maiorPotenciaDois = Math.Pow(2, logQntSoldadosBaseDois);

            var posicaoUltimoVivo = (qntSoldados - maiorPotenciaDois) * 2 + 1;

            posicaoUltimoVivo.Should().Be(posicaoUltimoVivoEsperada);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(4, 1)]
        [InlineData(5, 3)]
        [InlineData(6, 5)]
        [InlineData(7, 7)]
        [InlineData(8, 1)]
        [InlineData(9, 3)]
        [InlineData(10, 5)]
        [InlineData(11, 7)]
        [InlineData(12, 9)]
        [InlineData(13, 11)]
        [InlineData(14, 13)]
        [InlineData(15, 15)]
        [InlineData(16, 1)]
        [InlineData(41, 19)]
        [InlineData(6, 1, 3)]
        [InlineData(1234, 25, 233)]
        public void ShouldBeCorrectLastStandingPositionIteratively(int qntSoldados, int posicaoUltimoVivoEsperada, int tamanhoPulo = 2)
        {
            int posicaoUltimoVivo = new LendaFJ(qntSoldados, tamanhoPulo).PosicaoUltimoVivo();
            posicaoUltimoVivo.Should().Be(posicaoUltimoVivoEsperada);
        }
    }

    public class LendaFJ
    {
        public LendaFJ(int qntSoldados, int tamanhoPulo)
        {
            QntSoldados = qntSoldados;
            TamanhoPulo = tamanhoPulo - 1;
            Soldados = Enumerable.Range(0, qntSoldados).ToList();
        }

        public int QntSoldados { get; }
        public int TamanhoPulo { get; }
        public List<int> Soldados { get; }


        public int PosicaoUltimoVivo()
        {
            return PosicaoUltimoVivo(0);
        }
        private int PosicaoUltimoVivo(int posicao)
        {
            if (Soldados.Count == 1)
            {
                return Soldados.First() + 1;
            }

            posicao = (posicao + TamanhoPulo) % Soldados.Count;

            Soldados.RemoveAt(posicao);

            return PosicaoUltimoVivo(posicao);
        }
    }
}