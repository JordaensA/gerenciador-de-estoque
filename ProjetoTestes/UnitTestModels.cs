using System;
using Xunit;
using SistemaVendas.Models;
using System.Collections.Generic;

namespace ProjetoTestes
{
    public class UnitTestModels
    {
        [Fact]
        public void TestLoginOk()
        {
            LoginModel objLogin = new LoginModel();
            objLogin.Email = "filipenhimi@gmail.com";
            objLogin.Senha = "123456";
            bool result = objLogin.ValidarLogin();
            Assert.True(result);
        }

        [Fact]
        public void TestLoginFail()
        {
            LoginModel objLogin = new LoginModel();
            objLogin.Email = "filipenhimi@gmail.com";
            objLogin.Senha = "teste";
            bool result = objLogin.ValidarLogin();
            Assert.False(result);                        
        }

        [Fact]
        public void CheckTypeListProdutos()
        {
            ProdutoModel objProduto = new ProdutoModel();
            var lista = objProduto.ListarTodosProdutos();
            Assert.IsType<List<ProdutoModel>>(lista);
        }
    }
}
