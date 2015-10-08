// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
	"use strict";

	var app = WinJS.Application;
	var activation = Windows.ApplicationModel.Activation;

	var v = Windows.UI.ViewManagement.ApplicationView.getForCurrentView();
	v.titleBar.buttonBackgroundColor = Windows.UI.Colors[CLOCKWORKCONFIG.appbar_buttonBackgroundColor];
	v.titleBar.buttonForegroundColor = Windows.UI.Colors[CLOCKWORKCONFIG.appbar_buttonForegroundColor];
	v.titleBar.backgroundColor = Windows.UI.Colors[CLOCKWORKCONFIG.appbar_backgroundColor];
	v.titleBar.foregroundColor = Windows.UI.Colors[CLOCKWORKCONFIG.appbar_foregroundColor];

	app.onactivated = function (args) {
		if (args.detail.kind === activation.ActivationKind.launch) {
			if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
				
			    document.getElementById("canvas").style.width = window.innerWidth;
			    document.getElementById("canvas").style.height = window.innerHeight;
			    document.getElementById("canvas").width = window.innerWidth;
			    document.getElementById("canvas").height = window.innerHeight;
			    setUpAnimation(setUpEngine);


			} else {
				// TODO: This application has been reactivated from suspension.
				// Restore application state here.
			}
			args.setPromise(WinJS.UI.processAll());
		}
	};

	app.oncheckpoint = function (args) {
		// TODO: This application is about to be suspended. Save any state that needs to persist across suspensions here.
		// You might use the WinJS.Application.sessionState object, which is automatically saved and restored across suspension.
		// If you need to complete an asynchronous operation before your application is suspended, call args.setPromise().
	};

	app.start();


	function setUpAnimation(callback) {
	    var canvasAnimation = new Spritesheet();
	    canvasAnimation.setUp(document.getElementById("canvas"), CLOCKWORKCONFIG.animationfps);
	    canvasAnimation.setBufferSize(CLOCKWORKCONFIG.screenbuffer_width, CLOCKWORKCONFIG.screenbuffer_height);
	    canvasAnimation.setRenderMode(function (contextinput, contextoutput) {
	        contextoutput.clearRect(0, 0, contextoutput.canvas.width, contextoutput.canvas.height);
	        //All the width available will be used, the aspect ratio will be the same and the image will be centered vertically
	        if (contextoutput.canvas.width / contextinput.canvas.width < contextoutput.canvas.height / contextinput.canvas.height) {
	            var xpos = 0;
	            var ypos = (contextoutput.canvas.height - contextinput.canvas.height * contextoutput.canvas.width / contextinput.canvas.width) / 2;
	            var width = contextoutput.canvas.width;
	            var height = (contextinput.canvas.height * contextoutput.canvas.width / contextinput.canvas.width);
	        } else {
	            var xpos = (contextoutput.canvas.width - contextinput.canvas.width * contextoutput.canvas.height / contextinput.canvas.height) / 2;
	            var ypos = 0;
	            var width = (contextinput.canvas.width * contextoutput.canvas.height / contextinput.canvas.height);
	            var height = contextoutput.canvas.height;
	        }
	        contextoutput.drawImage(contextinput.canvas, xpos, ypos, width, height);
	    });
	    canvasAnimation.setFullScreen();
	    canvasAnimation.asyncLoad("game/data/spritesheets.xml", (function (c) { return function () { callback(c) }; })(canvasAnimation));
	}


	function setUpEngine(animLib) {
	    var engineInstance = new Clockwork();
	    engineInstance.setAnimationEngine(animLib);
	    engineInstance.registerCollision(ClockworkCollisions.pointsAndBoxes);
	    engineInstance.loadPresets(game_presets);
	    engineInstance.loadPresets(keyboard);
	    engineInstance.loadPresets(pointerAPI);
	    engineInstance.loadPresets(sound);
	    engineInstance.loadPresets(W10API);
	    engineInstance.loadPresets(basicClickPreset);
	    engineInstance.loadPresets(storage);

	    engineInstance.loadLevelsFromXML("game/data/levels.xml", function () {
	        engineInstance.start(CLOCKWORKCONFIG.enginefps, document.getElementById("canvas"));
	    });
	    

	}
})();
