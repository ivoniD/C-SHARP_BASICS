using System;

function moneyForExcursion(input)
{
    let bitcoin = Number(input[0]); // 1 
    let UNA = Number(input[1]); // 5
    let comis = Number(input[2]); // 5

    let leva = bitcoin * 1168; // 23360
    let dollar = UNA * 0.15; // 851.7
    let dollatToLev = dollar * 1.76; // 
    let euro = (leva + dollatToLev) / 1.95;
    let commision = euro * (comis / 100);
    let total = (euro - commision).toFixed(2);

    console.log(total);

}