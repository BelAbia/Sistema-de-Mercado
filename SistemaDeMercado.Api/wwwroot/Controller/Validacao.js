sap.ui.define([
	"sap/ui/base/ManagedObject",
	"sap/ui/model/json/JSONModel"

], function (ManagedObject, JSONModel) {
	"use strict";

	return ManagedObject.extend("sap.ui.demo.walkthrough.controller.Validacao", {

		_criarModeloDeListaDeAvisos: function () {
			let modeloDeLista = new JSONModel({
				avisos: []
			});
			this.getView().setModel(modeloDeLista, "ListaAvisos");
		},

		ValidarProdutos: function (produto) {
			let listaDeMensagensDeAviso = [];
			if (produto.codigoBarras.length !== 13) {
				listaDeMensagensDeAviso += this.getView().getModel("i18n").getResourceBundle().getText("AvisoTamanhoDoCodigoDeBarras");
				this.getView().byId("labelCodigoBarras").setValueState("Error");
			}
			if (!produto.codigoBarras.startsWith("789")) {
				listaDeMensagensDeAviso += this.getView().getModel("i18n").getResourceBundle().getText("AvisoPadraoCodigoDeBarras");
				this.getView().byId("labelCodigoBarras").setValueState("Error");
			}
			if (!produto.nome) {
				listaDeMensagensDeAviso += this.getView().getModel("i18n").getResourceBundle().getText("AvisoNome");
				this.getView().byId("labelNome").setValueState("Error");
			}
			if (!produto.marca) {
				listaDeMensagensDeAviso += this.getView().getModel("i18n").getResourceBundle().getText("AvisoMarca");
				this.getView().byId("labelMarca").setValueState("Error");
			}
			if (!produto.dataVencimento) {
				listaDeMensagensDeAviso += this.getView().getModel("i18n").getResourceBundle().getText("AvisoDataVencimento");
				this.getView().byId("labelDataVencimento").setValueState("Error");
			}
			if (listaDeMensagensDeAviso.length > 0) {
				this.getView().getModel("ListaAvisos").setProperty("/avisos", listaDeMensagensDeAviso);
			}
		}
	});
});