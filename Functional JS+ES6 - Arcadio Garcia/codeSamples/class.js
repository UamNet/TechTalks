class Perro {
	constructor(nombre){
		this.nombre=nombre;
	}
	ladrar(){
		console.log(this.nombre+ " va a decir algo...");
		//En realidad es window.setTimeout
		setTimeout( function(){console.log(this.nombre +" dice guau!")},1000);
	}
}

let perro=new Perro("Jake");
perro.ladrar();