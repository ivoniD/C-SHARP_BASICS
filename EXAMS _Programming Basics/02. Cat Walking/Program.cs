using System.Runtime.ConstrainedExecution;
using System;

function catWalking(input)
{
    let minutesPerDay = Number(input[0]);
    let numWalkingsPerDay = Number(input[1]);
    let catCaloriesPerDay = Number(input[2]);

    let allcatWalkMinutes = numWalkingsPerDay * minutesPerDay;
    let burnedCalories = allcatWalkMinutes * 5;

    if (burnedCalories >= (catCaloriesPerDay / 2))
    {
        console.log(`Yes, the walk for your cat is enough.Burned calories per day: ${ burnedCalories}.`)
    }
    else
{
    console.log(`No, the walk for your cat is not enough.Burned calories per day: ${ burnedCalories}.`)
    }

}