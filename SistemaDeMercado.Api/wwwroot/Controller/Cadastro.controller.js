sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel",
	"sap/ui/core/routing/History"
], function(Controller, JSONModel, History) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.Cadastro", {

        onInit: function() {
			
            var modelo = new sap.ui.model.json.JSONModel( {
                minDate: new Date()
            });
    
            this.getView().setModel(modelo, "ModeloDeData");

        },

       AoClicarNoBotaoDeVoltar: function () {
			var historia = History.getInstance();
			var hashAnterior = historia.getPreviousHash();

			if (hashAnterior !== undefined) {
				window.history.go(-1);
			} else {
				var rota = this.getOwnerComponent().getRouter();
				rota.navTo("listaProduto", {}, true);
			}
		},

		aoPressionarCancelar: function() {
			var rota = this.getOwnerComponent().getRouter();
				rota.navTo("listaProduto", {}, true);
		},

			aoPressionarSalvar: async function() {
			const LabelNomeDoProduto = sap.ui.getCore().byId("LabelNomeDoProduto")
			const LabelMarcaDoProduto = sap.ui.getCore().byId("LabelMarcaDoProduto").getValue()
			const LabelCodigoBarrasDoProduto = document.getElementById('codigoBarras')
			const IdDatePickerDataVencimento = document.getElementById('dataVencimento')

			const produto = {
				nome: LabelNomeDoProduto.getValue(),
				marca: LabelMarcaDoProduto.value,
				codigoBarras: number(LabelCodigoBarrasDoProduto.value),
				dataVencimento:	IdDatePickerDataVencimento.value
			}

			//chamar post na API
			const response = await fetch('https://localhost:7047/api/Produto', {
				method: 'POST',
				headers: {
				  'Accept': 'application/json',
				  'Content-Type': 'application/json'
				},
				body: JSON.stringify(produto)
			  })
			const dados = await response.json()
		}
	});
});