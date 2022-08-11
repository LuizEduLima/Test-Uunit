 using ProjetoTests.Domain.Core;
using ProjetoTests.Domain.Models;
using System;
using Xunit;

namespace ProjetoTests.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        [Trait("Produto Alterar", "Alterar descrição")]
        public void Trocar_Descricao_Produto()
        {
            var produto = new Produto("produto1", "produto produto1", 100, 10);

            produto.AlterarDescricao("produto produto2");

            Assert.DoesNotContain(produto.Descricao, "produto produto1");


        }
        [Fact]
        [Trait("Produto Debitar", "DomainException estoque insuficiente")]
        public void Debitar_Estoque_Quantidade_Insuficiente()
        {
            var produto = new Produto("produto1", "produto produto1", 100, 5);

            Assert.Throws<DomainException>(() => produto.DebitarEstoque(6));
        }
        [Fact]
        [Trait("Produto Debitar", "DomainException Retornar mensagem Exception")]
        public void Debitar_Estoque_Retornar_Mensagem_Exception()
        {
            var produto = new Produto("produto1", "produto produto1", 100, 5);
           
            var ex = Assert.Throws<DomainException>(() => produto.DebitarEstoque(6));
            Assert.Equal("Estoque insuficiente!!", ex.Message);

        }
    }
}
