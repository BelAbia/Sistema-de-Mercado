sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/model/Filter",
	"sap/ui/model/FilterOperator"
], function(Controller, JSONModel, Filter, FilterOperator) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.ListaProduto", {

		onInit: function() {
			this.exibirProduto()
		},
		exibirProduto: function () {
			var listaRetornada = this.buscarProdutos();
        	listaRetornada.then(lista =>{
            var modelo = new JSONModel(lista)
            this.getView().setModel(modelo, "listaProdutos")
        	})
		},

		buscarProdutos : async function(){
			var produtosRetornados;
			 await fetch("https://localhost:7047/api/Produto")
			.then(response => response.json())
			.then(data => produtosRetornados = data)
	
			return produtosRetornados
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
		},
		
	});
});