sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/model/Filter",
	"sap/ui/model/FilterOperator"
], function(Controller, JSONModel, Filter, FilterOperator) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.ListaProduto", {

		onInit: function() {

            fetch('https://jsonplaceholder.typicode.com/users')
                .then(response => response.json())
                .then(json => this.getView().setModel(new JSONModel(json), 'listaProdutos'));
		},
		aoClicarNaListaDeProduto: function(oEvent) {
			var oRouter = this.getOwnerComponent().getRouter();
			oRouter.navTo("detalhes");
		},
		aoClicarNaBarraDePesquisa: function (oEvent) {
			var aFilter = [];
			var sQuery = oEvent.getParameter("query");
			if (sQuery) {
				aFilter.push(new Filter("name", FilterOperator.Contains, sQuery));
			}
			var oList = this.byId("idTabelaDeProdutos");
			var oBinding = oList.getBinding("items");
			oBinding.filter(aFilter);
		}
	});
});