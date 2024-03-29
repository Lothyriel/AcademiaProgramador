﻿using System;

namespace Clube_Leitura.Domínio
{
    class Emprestimo
    {
        private Amiguinho amiguinho;
        private Revista revista;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;

        public Emprestimo(Amiguinho amiguinho, Revista revista, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            this.amiguinho = amiguinho;
            this.revista = revista;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
        }

        public DateTime DataEmprestimo { get => dataEmprestimo; }
        internal Revista Revista { get => revista; }
        internal Amiguinho Amiguinho { get => amiguinho; }

        public override bool Equals(object obj)
        {
            return obj is Emprestimo emprestimo && amiguinho == emprestimo.amiguinho;
        }

        public override int GetHashCode()
        {
            return amiguinho.GetHashCode() ^ revista.GetHashCode();
        }
        public override string ToString()
        {
            return "Amiguinho: " + amiguinho.Nome + "\n/ Revista: " + revista + "\n/ Data de Empréstimo: " + dataEmprestimo.ToString("dd/MM/yyyy") + "\n/ Data de Devolução: " + dataDevolucao.ToString("dd/MM/yyyy") + " ]";
        }
    }
}
