export function positivos(...a){
	return a.filter(x=>x>0);
}

export function suma(...a){
	return a.reduce((x,y)=>x+y);
}

export function sumaPotencias(n,...a){
	return a.map(x=>Math.pow(x,n)).reduce((x,y)=>x+y);
}

export function functionToMap(f,...a){
	let map = new Map();
	a.forEach(function(x){
		map.set(x,f(x));
	});
	return map;
}

var datosInternos;
let masDatosInternos;