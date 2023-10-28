/*
    Benjamin Grekl
    main.js
    INFO 2124
    Yi
    09/18/2023
*/
"use strict"

let cargoWeight, totalCargoWeight, itemWeight, average
cargoWeight = [];
totalCargoWeight = 0;
itemWeight = 0;
const maxWeightLbs = 1000;
average = 0;

// Get the weight of each item
do {
    itemWeight = parseFloat(prompt("Please enter the item weight in pounds, or input -1 to exit."));
    if (itemWeight >= 0) {
        cargoWeight[cargoWeight.length] = itemWeight;
    } else if (itemWeight !== -1) {
        alert("Item weight must be a valid number that is greater than zero pounds!");
    }
} while (itemWeight !== -1)

// Find the total and average weight
if (cargoWeight.length > 0) {
    for (const i of cargoWeight) {
        totalCargoWeight = totalCargoWeight + i;
    }
    average = totalCargoWeight / cargoWeight.length;
}

// Determine if the rocket can take off
let takeoffStatus;
if (maxWeightLbs > totalCargoWeight) {
    takeoffStatus = "Congratulations! The rocket can take off!"
} else {
    takeoffStatus = "Oh no! Your rocket is too heavy to take off!<br>The rocket must be less than 1000 pounds to take off!"
}

// alert("Total cargo weight is " + totalCargoWeight + "; average item weight is " + average);
let html = `
<h1>Space Weight</h1>
<p>Total cargo weight: ${totalCargoWeight.toFixed(2)}</p>
<p>Average item weight: ${average.toFixed(2)}</p>
<p>${takeoffStatus}</p>
`;
document.write(html);
