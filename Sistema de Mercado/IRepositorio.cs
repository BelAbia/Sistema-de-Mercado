﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Mercado
{
    public interface IRepositorio
    {
        public void NovoProduto(Produto produto);

        public void DeletarProduto(int LinhaSelecionada);

        public void AtualizarProduto(int i, Produto produto);

        public List<Produto> ObterTodos();

        public void ObterPorId(int Id);




    }
}