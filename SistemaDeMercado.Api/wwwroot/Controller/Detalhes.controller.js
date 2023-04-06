sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/core/routing/History"
], function(Controller, JSONModel, History) {
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
			var listaRetornada = this.buscarDetalheDoProduto(id);
			listaRetornada.then(produto => {
				var modelo = new JSONModel(produto)
				this.getView().setModel(modelo, "detalhes");
				this.getView().byId("IdObjectHeader").bindElement({
					path: "detalhes>/",
					parameters: {
						expand: "detalhes"
					}
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
			const produto = this.getView().getModel("detalhes").getData()
			let id = produto.id
			var rota = this.getOwnerComponent().getRouter();
			rota.navTo("cadastro", {
				id: id
			});
		}
	});
});