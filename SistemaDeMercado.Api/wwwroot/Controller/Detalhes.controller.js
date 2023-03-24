sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel"
], function(Controller, JSONModel) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.Detalhes", {

		onInit: function() {
			var oRouter = this.getOwnerComponent().getRouter();
			oRouter.getRoute("detalhes").attachPatternMatched(this._onObjectMatched, this);
		},
		_onObjectMatched: function (oEvent) {
			let id = oEvent.getParameter("arguments").id;
			this.exibirProduto(id);
		},
		exibirProduto: function (id) {
			var listaRetornada = this.buscarDetalheDoProduto(id);
			listaRetornada.then(produto => {
				var modelo = new JSONModel(produto)
				this.getView().setModel(modelo, "detalhes");
				this.getView().byId("objectHeader").bindElement({
					path: "detalhes>/",
					parameters: {
						expand: "categoria"
					}
				});
			});
		},
		buscarDetalheDoProduto : async function(id){
            return await fetch (`https://localhost:7047/api/Produto/${id}`)
            .then(res => res.json());
        }
	});
});