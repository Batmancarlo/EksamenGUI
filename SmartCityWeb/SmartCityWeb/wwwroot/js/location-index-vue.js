// Vue code for the Job applecation page - create.cshtml
vm = new Vue({
    el: '#vueApp',
    data: {
        introText:'hej',
        locations: [],
        searchlocations: [],
        searchbox: "",
        specificSensors: [],
        showsensors: false,
        specificTrees: [],
        showTrees: false,


    },
    methods: {
        sendApplication() {
            var vuecomponent = this;
           
            fetch('api/LocationsAPI')
                .then(function(response) {
                    if (response.status == '200') {
                        response.json()
                            .then(data => ({ body: data }))
                            .then(function(data) {
                                for (let i = 0; i < data.body.length; i++) {
                                    vuecomponent.$set(vuecomponent.locations, i, data.body[i]);
                                    vuecomponent.$set(vuecomponent.searchlocations, i, data.body[i]);
                                }
                            });
                    }
                });
            this.showsensors = false;
        },
        searchLocations() {
            this.specificTrees = [];
            this.specificSensors = [];
            this.showsensors = false;
            this.showTrees = false;
            this.searchlocations = [];
            for(var location of this.locations)
            {
                if (location.name.startsWith(this.searchbox)) {
                    this.searchlocations.push(location);
                }
            }
        },
        showSensorsfunction: function (id) {
            this.specificSensors = [];
            this.specificTrees = [];
            var vuecomponent = this;

            fetch('api/SensorsAPI/' + id)
                .then(function(response) {
                    if (response.status == '200') {
                        response.json()
                            .then(data => ({ body: data }))
                            .then(function(data) {
                                for (let i = 0; i < data.body.length; i++) {
                                    vuecomponent.$set(vuecomponent.specificSensors, i, data.body[i]);
                                   
                                }
                            });
                    }
                });
            this.showsensors = true;
        
            

            fetch('api/TreesAPI/' + id)
                .then(function(response) {
                    if (response.status == '200') {
                        response.json()
                            .then(data => ({ body: data }))
                            .then(function(data) {
                                for (let i = 0; i < data.body.length; i++) {
                                    vuecomponent.$set(vuecomponent.specificTrees, i, data.body[i]);
                                   
                                }
                            });
                    }
                });
            this.showTrees = true;
        },
        deletelocation: function (id) {
            fetch(('api/LocationsAPI/' + id), { method: 'DELETE' }).then(location.reload());
            

        },
        deleteSensor: function (id) {
            fetch(('api/SensorsAPI/' + id), { method: 'DELETE' }).then(location.reload());


        },
        deleteTree: function (id) {
            fetch(('api/TreesAPI/' + id), { method: 'DELETE' }).then(location.reload());
           

        }
        
    },
    beforeMount() {
        this.sendApplication();
    }
});