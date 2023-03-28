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
			.then(resposta => resposta.json())
			.then(dados => produtosRetornados = dados)
	
			return produtosRetornados
		},

		aoClicarNaListaDeProduto: function(eventoDoObjeto) {
			var idProduto = eventoDoObjeto.getSource().getBindingContext("listaProdutos").getObject().id;
			var rota = this.getOwnerComponent().getRouter();
			rota.navTo("detalhes", {
				id: idProduto
			});
		},

		aoFiltrarProdutos: function (eventoDoObjeto) {
			var filtro = [];
			var consulta = eventoDoObjeto.getParameter("query");
			if (consulta) {
				filtro.push(new Filter("nome", FilterOperator.Contains, consulta));
			}
			var listaDeProdutos = this.byId("idTabelaDeProdutos");
			var oBinding = listaDeProdutos.getBinding("items");
			oBinding.filter(filtro);
		},
		
		aoClicarEmNovoProduto:  function (oEvent) {
			var rota = this.getOwnerComponent().getRouter();
			rota.navTo("cadastro");
		}
	});
});