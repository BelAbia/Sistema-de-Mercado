sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/core/routing/History",
	"sap/ui/demo/walkthrough/controller/Validacao",
], function(Controller, JSONModel, History, Validacao) {
	"use strict";
	
	return Controller.extend("sap.ui.demo.walkthrough.controller.Cadastro", {

		_validacao : null,

        onInit: function() {
			this._validacao = new Validacao();
			var rota = this.getOwnerComponent().getRouter();
			rota.getRoute("cadastro").attachPatternMatched(this.aoCoincidirRota, this);
			rota.getRoute("edicao").attachPatternMatched(this.aoCoincidirRota, this);

			this.byId("labelDataVencimento").setMinDate(new Date());
        },

		aoCoincidirRota: function (evento) {
			let conferindoNomeDaRota = evento.getParameter("name") == "cadastro";
			this._inicializarModelo();
			if (conferindoNomeDaRota){
			this._criarModeloDoProduto();

			}else{
				let id = evento.getParameter("arguments").id;
				var produtoASerEditado = this.buscarProdutoASerEditado(id)
				produtoASerEditado.then(produto => {
					var modelo = new JSONModel(produto)
					this.getView().setModel(modelo, "Produto");
				});
			}
		},

		_inicializarModelo: function (){
			this._criarModeloDeListaDeAvisos();
		},

		_criarModeloDoProduto: function(){
			const dataFormatada = sap.ui.core.format.DateFormat.getDateTimeInstance({pattern: "yyyy-MM-ddTHH:mm:ss.SS"});
			let dataAtual = new Date()
			let modeloProduto = new JSONModel({
				nome: "",
				marca: "",
				codigoBarras: "",
				dataVencimento: "",
				dataCadastro: dataFormatada.format(dataAtual),
			});
			this.getView().setModel(modeloProduto, "Produto");
		},

		_criarModeloDeListaDeAvisos: function(){
			let modeloDeLista = new JSONModel({
				avisos: []
			});
			this.getView().setModel(modeloDeLista, "ListaAvisos");
		},

       aoClicarNoBotaoDeVoltar: function () {
			var historia = History.getInstance();
			var hashAnterior = historia.getPreviousHash();

			if (hashAnterior !== undefined) {
				window.history.go(-1);
			} else {
				var rota = this.getOwnerComponent().getRouter();
				rota.navTo("listaProduto", {}, true);
			}
		},

		aoPressionarCancelar: function() {
			var rota = this.getOwnerComponent().getRouter();
				rota.navTo("listaProduto", {}, true);
		},

		aoPressionarSalvar: function() {
			const produto = this.getView().getModel("Produto").getData()
			this._validacao.ValidarProdutos.bind(this)(produto);
			if(produto.id){
				let id = produto.id
				this.editarProduto(produto)
				var rota = this.getOwnerComponent().getRouter();
				rota.navTo("detalhes", {
					id: id
				  });
			}else{
				this.cadastrarNovoProduto(produto).then((idProduto) => {
				var rota = this.getOwnerComponent().getRouter();
				rota.navTo("detalhes", {
					id: idProduto
					});
				});
			}
		  },
		  
		  cadastrarNovoProduto: async function(produto) {
			return await fetch('https://localhost:7047/api/Produto', {
			  method: 'POST',
			  headers: {
				'content-type': 'application/json'
			  },
			  body: JSON.stringify(produto)
			})
			.then((resposta) => resposta.json())
			.then(data => data.id);
		  },

		  buscarProdutoASerEditado: async function(id){
            return await fetch (`https://localhost:7047/api/Produto/${id}`)
            .then(res => res.json());
		  },

		  editarProduto: async function(produtoASerEditado){
			return await fetch(`https://localhost:7047/api/Produto/${produtoASerEditado.id}`, {
			  method: 'PUT',
			  headers: {
				'content-type': 'application/json'
			  },
			  body: JSON.stringify(produtoASerEditado)
			})
			.then((resposta) => resposta.json())
			.then(data => data.id);
		  }
	});
});