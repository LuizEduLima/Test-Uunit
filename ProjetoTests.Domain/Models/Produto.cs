using ProjetoTests.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjetoTests.Domain.Models
{
    public class Produto : Entity
    {
        public Produto(string nome, string descricao, decimal valor, int quantidadeEstoque)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;

        }

        protected Produto() { }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public bool Ativo { get; private set; }

        public void AlterarDescricao(string descricao) => Descricao = descricao;
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;

            if (quantidade > QuantidadeEstoque) throw new DomainException("Estoque insuficiente!!");

            QuantidadeEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }
    }

    public abstract class Entity
    {
        [Key]
        public Guid Id { get; }
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }



}
