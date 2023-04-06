sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/core/routing/History"
], function(Controller, JSONModel, History) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.Cadastro", {

        onInit: function() {
			var rota = this.getOwnerComponent().getRouter();
			rota.getRoute("cadastro").attachPatternMatched(this.aoCoincidirRota, this);

			this.byId("labelDataVencimento").setMinDate(new Date());
        },

		aoCoincidirRota: function () {
			this._criarModeloDoProduto();
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
			this.cadastrarNovoProduto(produto).then((idProduto) => {
			  var rota = this.getOwnerComponent().getRouter();
			  rota.navTo("detalhes", {
				id: idProduto
			  });
			});
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
		  }
	});
});