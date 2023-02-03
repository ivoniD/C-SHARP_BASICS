using System;

function energyBooster(input)
{
    let fruit = input[0];
    let set = input[1];
    let numSets = Number(input[2]);
    let price;
    if (fruit == "Watermelon")
    {
        if (set == "small")
        {
            price = numSets * (2 * 56);
        }
        else if (set == "big")
        {
            price = numSets * (5 * 28.70);
        }
    }
    else if (fruit == "Mango")
    {
        if (set == "small")
        {
            price = numSets * (2 * 36.66);
        }
        else if (set == "big")
        {
            price = numSets * (5 * 19.60);
        }
    }
    else if (fruit == "Pineapple")
    {
        if (set == "small")
        {
            price = numSets * (2 * 42.10);
        }
        else if (set == "big")
        {
            price = numSets * (5 * 24.80);
        }
    }
    else if (fruit == "Raspberry")
    {
        if (set == "small")
        {
            price = numSets * (2 * 20); // 50 * 40
        }
        else if (set == "big")
        {
            price = numSets * (5 * 15.20);
        }
    }

    if (price >= 400 && price <= 1000)
    {
        price = price - (price * 0.15);
    }
    if (price > 1000)
    {
        price = price / 2;
    }

    console.log((price).toFixed(2) + " lv.");
}