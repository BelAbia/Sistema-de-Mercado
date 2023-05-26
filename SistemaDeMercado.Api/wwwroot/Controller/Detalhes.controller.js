sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/core/routing/History",
	"sap/m/MessageBox"
], function(Controller, JSONModel, History, MessageBox) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.Detalhes", {

		onInit: function() {
			var rota = this.getOwnerComponent().getRouter();
			rota.getRoute("detalhes").attachPatternMatched(this.aoCoincidirRota, this);
		},

		aoCoincidirRota: function (oEvent) {
			let id = oEvent.getParameter("arguments").id;
			this.exibirProduto(id);
		},
		
		exibirProduto: function (id) {
			var produtoDetalhado = this.buscarDetalheDoProduto(id);
			produtoDetalhado.then(produto => {
				var modelo = new JSONModel(produto)
				this.getView().setModel(modelo, "Produto");
				this.getView().byId("IdObjectHeader").bindElement({
					path: "Produto>/"
				});
			});
		},

		buscarDetalheDoProduto : async function(id){
            return await fetch (`https://localhost:7047/api/Produto/${id}`)
            .then(res => res.json());
        },

		aoClicarNoBotaoDeVoltar: function() {
			var historia = History.getInstance();
			var hashAnterior = historia.getPreviousHash();
			if (hashAnterior !== undefined) {
				window.history.go(-1);
			} else {
				var rota = this.getOwnerComponent().getRouter();
				rota.navTo("listaProduto", {}, true);
			}
		},

		aoPressionarEditar: function() {
			const produto = this.getView().getModel("Produto").getData()
			let id = produto.id
			var rota = this.getOwnerComponent().getRouter();
			rota.navTo("edicao", {
				id: id
			});
		},

		aoPressionarExcluir: function() {
			const produto = this.getView().getModel("Produto").getData();
			const i18nModel = this.getView().getModel("i18n");
			
				MessageBox.confirm(i18nModel.getResourceBundle().getText("MensagemParaConfirmarExclusao"), {
				title: "Confirmação",
				onClose: function (oAction) {
					if (oAction === sap.m.MessageBox.Action.OK) {
						let id = produto.id;
						this.excluirProduto(id);
						var rota = this.getOwnerComponent().getRouter();
						rota.navTo("listaProduto");
					}
				}.bind(this) 
			});
		},

		excluirProduto: async function(id) {
            return await fetch (`https://localhost:7047/api/Produto/${id}`, {
				method: 'DELETE'})
				.then(res => res.text())
				.then(res => console.log(res))
		}
	});
});