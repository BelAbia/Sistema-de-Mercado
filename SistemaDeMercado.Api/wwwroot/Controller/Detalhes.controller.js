sap.ui.define([
	"sap/ui/core/mvc/Controller",
	"sap/ui/model/json/JSONModel"
], function(Controller, JSONModel) {
	"use strict";

	return Controller.extend("sap.ui.demo.walkthrough.controller.Detalhes", {

		onInit: function() {

            fetch('https://jsonplaceholder.typicode.com/users')
                .then(response => response.json())
                .then(json => this.getView().setModel(new JSONModel(json), 'detalhes', {Id}));
		}
	});
});