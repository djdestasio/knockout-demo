$(function (demo, $, undefined) {
    demo.personModel = (function () {

        var model = function (serverModel) {
            var self = this;
            
            // maintains the list of people on the page.
            self.people = ko.observableArray(serverModel || []);

            // adds a person.
            self.addPerson = function () {
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
            self.removePerson = function (person) {
                if (person.Id > 0) {
                    if (confirm("Are you sure you want to delete this person")) {
                        var url = demo.deletePersonUrl + '/' + person.Id;
                        $.post(url, function () {
                            self.people.remove(person);
                        });
                    }
                } else {
                    self.people.remove(person);
                }
            };

            // saves all new / modified people
            self.save = function () {
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

            // group the positions for the people in the list.
            self.positionGroups = ko.computed(function () {
                var people = self.people();
                var countedPositions = [];
                var positionDetail = [];

                ko.utils.arrayForEach(people, function (person) {
                    var position = person.Position;

                    if (countedPositions.indexOf(position) < 0) {
                        var matches = ko.utils.arrayFilter(self.people(), function (p) {
                            return p.Position == position;
                        });

                        countedPositions.push(position);
                        positionDetail.push({ position: position.length > 0 ? position : 'Unknown', count: matches.length });
                    }
                });

                return positionDetail;

            }, self);
        };

        return {
            init: function (serverModel) {
                var viewModel = new model(serverModel);
                ko.applyBindings(viewModel);

                // hook into validation for save
                $(document).ready(function () {
                    var $form = $('#PeopleForm');

                    $form.submit(function () {
                        if ($(this).valid()) {
                            viewModel.save();
                        }
                    });
                });
            }
        };

    })();
} (window.demo = window.demo || {}, jQuery));