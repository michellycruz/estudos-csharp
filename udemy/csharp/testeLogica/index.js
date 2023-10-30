let fruta = prompt(
`Por favor, informe qual fruta deseja comprar:
1 - Uva = R$5.30
2 - Morango = R$5.10
3 - Sair`);

let result = 0
let nomeFruta = ""

do {
    if(fruta == 1){
    fruta = 5.30
    nomeFruta = "Uvas"
} else{
    fruta = 5.10
    nomeFruta = "Morangos"
};

let quantidade = prompt(`Informe a quantidade de ${nomeFruta} que você gostaria de comprar`);
result += fruta * quantidade;

fruta = prompt(
    `Por favor, informe qual fruta deseja comprar:
    1 - Uva = R$5.30
    2 - Morango = R$5.10
    3 - Sair`);

} while(fruta != 3);

alert(`VALOR A PAGAR: R$ ${result}`);