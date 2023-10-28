/*
    Benjamin Grekl
    main.js
    INFO 2124
    Yi
    09/10/2023
*/
"use strict";

// Prompt the user for their weight in pounds, height in inches, and the current temperature in Fahrenheit.
const lbs = parseFloat(prompt("Please enter your weight in pounds."));
const inches = parseFloat(prompt("Please enter your height in inches"));
const fahrenheit = parseFloat(prompt("Please enter the current temperature in Fahrenheit"));

//kg = lb x 0.45359237
const kg = parseFloat((lbs * 0.45359237).toString());

// Convert inches to centimeters
const cm = parseFloat((inches * 2.54).toString());

// Convert Fahrenheit to Celsius
const celsius = parseFloat((fahrenheit - 32).toString()) * 5 / 9;

// Define the HTML to display the results
const html = `
        <h1>The Metroficator</h1>
        <p>${lbs.toFixed(2)} pounds equals ${kg.toFixed(2)} kg</p>
        <p>${inches.toFixed(2)} inches equals ${cm.toFixed(2)} cm</p>
        <p>${fahrenheit.toFixed(2)} F equals ${celsius.toFixed(2)} C</p>
    `;
document.write(html);
