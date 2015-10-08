// Preset for the Clockwork engine
// Arcadio Garcia Salvadores
var game_presets = [
{
    name: "dog",
    sprite: "paradog",
    events: [
        {
            name: "#setup", code: function (event) {
                this.setVar("#state", "RunR");
                this.setVar("vy", 0);
                this.setVar("ay", 0.5);
            }
        },
        {
            name: "#collide", code: function (event) {
                    if (event.shape2kind == "point" && this.engine.getObject(event.object).instanceOf("basicMouse")) {
                        //Shape2id==0   => Hover
                        //Shape2id==1   => Click
                        if (event.shape2id == 1) {
                            this.setVar("vy", -8);
                        }
                    }
                }
        },
		{
		    name: "#loop", code: function (event) {
                //La vy esta acotada a un maximo de 5 para que caiga de manera uniforme
		        if (this.getVar("vy") < 5) {
		            this.setVar("vy", this.getVar("vy") + this.getVar("ay"));
		        }
		        //Moverse en el eje y
		        if (this.getVar("#y") < 330 || this.getVar("vy")<0) {
		            this.setVar("#y", this.getVar("#y") + this.getVar("vy"));
		        }
		    }
		}
    ],
    collision: {
        "box": [
            //All the screen
            { "x": -1000, "y": -1000, "w": 2000, "h": 2000 },
        ]
    }
}
];
