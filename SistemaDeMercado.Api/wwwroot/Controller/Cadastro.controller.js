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
			const nomeParaSalvar = this.getView().byId("nome").getValue();
			const marcaParaSalvar = this.getView().byId("marca").getValue();
			const codigoBarrasParaSalvar = this.getView().byId("codigoBarras").getValue();
			const dataVencimentoParaSalvar = this.getView().byId("dataVencimento").getDateValue();
			const dataFormatada = sap.ui.core.format.DateFormat.getDateTimeInstance({pattern: "yyyy-MM-ddTHH:mm:ss.SS"});
			const dataAtual = new Date()

			const produto = {
				nome: nomeParaSalvar,
				marca: marcaParaSalvar,
				codigoBarras: codigoBarrasParaSalvar,
				dataVencimento:	dataVencimentoParaSalvar,
				dataCadastro: dataFormatada.format(dataAtual)
			}

			//chamar post na API
			const response = await fetch('https://localhost:7047/api/Produto', {
				method: 'POST',
				headers: {
				  'Content-Type': 'application/json'
				},
				body: JSON.stringify(produto)
			  })
			const dados = await response.json()

			var rota = this.getOwnerComponent().getRouter();
				rota.navTo("detalhes", {
					id: id
				});
		},
		
			navegarParaTelaDeDetalhes: function() {
				
		}
	});
});