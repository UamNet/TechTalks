var tablasMultiplicar = [];

function conseguirTablas(n){
    return function(x){
        return n*x;
    }
}

for (var i = 0; i <= 10; i++) {
    tablasMultiplicar[i] = conseguirTablas(i);
}


for (var j = 0; j <= 10; j++) {
    for (var k = 0; k <= 10; k++) {
        console.log(j + " x " + k + " :" + tablasMultiplicar[j](k));
    }
}