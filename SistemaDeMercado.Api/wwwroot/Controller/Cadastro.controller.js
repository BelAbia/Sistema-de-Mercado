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
        },

		aoCoincidirRota: function (oEvent) {
			this._criarModeloDoProduto();
		},

		_criarModeloDoProduto: function(){

			let modeloProduto = new JSONModel({
				nome: "",
				marca: "",
				codigoBarras: "",
				dataVencimento: "",
				dataCadastro: new Date('08/02/2003'),
			});
			this.getView().setModel(modeloProduto, "Produto");
		},

       AoClicarNoBotaoDeVoltar: function () {
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

		aoPressionarSalvar: async function() {
			var produto = this.getView().getModel("Produto").getData()

			await fetch('https://localhost:7047/api/Produto', {
				method: 'POST',
				headers: {
					'content-type': 'application/json'
				},
				body: JSON.stringify(produto)
			})
			.then((resposta) => resposta.json())
		}
	});
});