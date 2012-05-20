$(function (demo, $, undefined) {
    demo.personModel = (function () {

        var model = function (serverModel) {
            var self = this;
            this.people = ko.observableArray(serverModel || []);

            // adds a person.
            this.addPerson = function () {
                // todo code to push new person.
            };

            // removes a person.
            this.removePerson = function (person) {
                self.people.remove(person);
            };

            this.save = function () {

            };
        };

        return {
            init: function (serverModel) {
                var viewModel = new model(serverModel);
                ko.applyBindings(viewModel);
            }
        };

    })();
} (window.demo = window.demo || {}, jQuery));