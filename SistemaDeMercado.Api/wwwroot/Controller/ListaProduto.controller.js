sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/model/Filter",
	"sap/ui/model/FilterOperator"
], function(Controller, JSONModel, Filter, FilterOperator) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.ListaProduto", {

		onInit: function() {
			const url = `https://localhost:7047/api/Produto`;
			fetch(url)
                .then(response => response.json())
                .then(json => this.getView().setModel(new JSONModel(json), 'listaProdutos'));
		},
		aoClicarNaListaDeProduto: function(oEvent) {
			var idProduto = oEvent.getSource().getBindingContext("listaProdutos").getObject().id;
			var oRouter = this.getOwnerComponent().getRouter();
			oRouter.navTo("detalhes", {
				id: idProduto
			});
		},
		aoClicarNaBarraDePesquisa: function (oEvent) {
			var aFilter = [];
			var sQuery = oEvent.getParameter("query");
			if (sQuery) {
				aFilter.push(new Filter("nome", FilterOperator.Contains, sQuery));
			}
			var oList = this.byId("idTabelaDeProdutos");
			var oBinding = oList.getBinding("items");
			oBinding.filter(aFilter);
		}
	});
});