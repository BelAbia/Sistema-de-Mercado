sap.ui.define([
"sap/ui/base/ManagedObject"
], function(ManagedObject) { 
	"use strict";
	return Controller.extend("sap.ui.demo.walkthrough.controller.Validacao", {

	return ManagedObject.extend("sap.ui.demo.walkthrough.controller.Validacao", {

<<<<<<< HEAD
	ValidarProdutos: function (produto){
		let listaDeMensagensDeAviso = [];
		if (produto.codigoBarras.length !== 13){
			listaDeMensagensDeAviso += "Codigo de barras deve ter 13 digitos.\n";
			this.getView().byId("labelCodigoBarras").setValueState("Error");
		}
		if(!produto.codigoBarras.startsWith("789"))
		{
			listaDeMensagensDeAviso += "O codigo de barras deve começar com '789'.\n";
			this.getView().byId("labelCodigoBarras").setValueState("Error");
		}
		if(!produto.nome){
			listaDeMensagensDeAviso += "O nome não pode ser vazio.\n";
			this.getView().byId("labelNome").setValueState("Error");
		}
		if(!produto.marca){
			listaDeMensagensDeAviso += "A marca não pode ser vazio.\n";
			this.getView().byId("labelMarca").setValueState("Error");

		}
		if(!produto.dataVencimento){
			listaDeMensagensDeAviso += "A data de Vencimento não pode ser vazia.\n";
			this.getView().byId("labelDataVencimento").setValueState("Error");

		}
		if(listaDeMensagensDeAviso.length > 0)
		{
			this.getView().getModel("ListaAvisos").setProperty("/avisos", listaDeMensagensDeAviso);
			//this.getView().byId("idMessageTrip").setVisible(true);
			//this.getView().byId("labelCodigoBarras").setValueStateText("O codigo de barras deve começar com '789'.");
		}
		}
	});
=======
	})
>>>>>>> 95645762e064a512747de9795b9ec5639ad97e6b
});