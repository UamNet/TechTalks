
//Tres cartas
var amuletoDelDestino = function (jugador, destino) {
    jugador.mana -= 200;
    destino.mana -= 500 * Math.random();
}

var flechaIgnea = function (jugador, destino) {
    jugador.mana -= 200;
    destino.vida -= 400;
}

var zanahoriaExplosiva = function (jugador, destino) {
    jugador.mana -= 50;
    destino.vida -= destino.mana/3;
}


//Dos jugadores
var jugador1 = { mana: 1000, vida: 1000, toString: function () { return this.vida + " health;   " + this.mana + " mana" } };
var jugador2 = { mana: 1000, vida: 1000, toString: function () { return this.vida + " health;  " + this.mana + " mana" }};

jugador1.usarCarta = function (carta) {
    carta(jugador1, jugador2);
}

jugador2.usarCarta = function (carta) {
    carta(jugador2, jugador1);
}

//Partida
console.log("Comienzo de la partida:");
console.log("J1:  "+jugador1);
console.log("J2:  " + jugador2);
console.log("J1 usa zanahoria explosiva:");
jugador1.usarCarta(zanahoriaExplosiva);
console.log("J1:  " + jugador1);
console.log("J2:  " + jugador2);
console.log("J2 usa flecha ignea:");
jugador2.usarCarta(flechaIgnea);
console.log("J1:  " + jugador1);
console.log("J2:  " + jugador2);
console.log("J1 usa amuleto del destino:");
jugador1.usarCarta(amuletoDelDestino);
console.log("J1:  " + jugador1);
console.log("J2:  " + jugador2);