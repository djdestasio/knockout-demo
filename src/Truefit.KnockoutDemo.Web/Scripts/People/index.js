$(function (demo, $, undefined) {
    demo.personModel = (function () {

        var model = function (serverModel) {
            var self = this;
            this.people = ko.observableArray(serverModel || []);

            // adds a person.
            this.addPerson = function () {
                this.people.push({
                    Id: 0,
                    FirstName: '',
                    LastName: '',
                    Position: ''
                });

                // this call fixes unobtrusive validation on dynamically added element
                $.validator.unobtrusive.parseDynamicContent('.person:last');
            };

            // removes a person.
            this.removePerson = function (person) {
                if (confirm("Are you sure you want to delete this person")) {
                    var url = demo.deletePersonUrl + '/' + person.Id;
                    $.post(url, function () {
                        self.people.remove(person);
                    });
                }
            };

            // saves all new / modified people
            this.save = function () {
                var form = $('#PeopleForm'),
                    saveUrl = form.attr('action');

                $.ajax({
                    type: 'POST',
                    dataType: 'json',
                    contentType: 'application/json',
                    url: saveUrl,
                    data: ko.toJSON(self.people()),
                    success: function (result) {
                        window.location.reload();
                    }
                });
            };
        };

        return {
            init: function (serverModel) {
                var viewModel = new model(serverModel);
                ko.applyBindings(viewModel);

                // hook into validation for save
                $(document).ready(function () {
                    $('#PeopleForm').validate({
                        submitHandler: function (form) {
                            viewModel.save();
                        }
                    });
                });
            }
        };

    })();
} (window.demo = window.demo || {}, jQuery));