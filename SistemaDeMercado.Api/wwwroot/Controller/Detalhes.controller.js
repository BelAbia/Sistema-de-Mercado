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

		},
		carregarProdutoPoriD: function(id){
			const url='https://localhost:7047/api/Produto/'
			fetch(url`${id}`)
			.then(response => response.json())
			.then(json => this.getView().setModel(new JSONModel(json), 'detalhes'));
		}
	});
});