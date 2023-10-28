/*
    Benjamin Grekl
    convert_temp.js
    INFO 2124
    Yi
    10/02/2023
*/
"use strict"


//DO NOT MODIFY THE CODE BELOW 

/*********************
*  helper functions  *
**********************/
const $ = selector => document.querySelector(selector);
const calculateCelsius = temp => (temp-32) * 5/9;
const calculateFahrenheit = temp => temp * 9/5 + 32;
//ADD YOUR CODE BELOW
const calculateMeters = feet => feet / 3.2808;
const calculateFeet = meters => meters * 3.2808;

const toggleDisplay = (label1Text, label2Text) => {
    // Clear error message
    $("#message").textContent = "";

    $("#label_1").textContent = label1Text;
    $("#label_2").textContent = label2Text;
    $("#value_computed").value = "";
    let value_entered = $("#value_entered");
    value_entered.value = "";
    value_entered.focus();
}

const performConversion = () => {
    // Get all the elements
    let value_entered = $("#value_entered").value;
    let value_computed = $("#value_computed");
    let to_celsius = $("#to_celsius");
    let to_fahrenheit = $("#to_fahrenheit");
    let to_meters = $("#to_meters");
    let to_feet = $("#to_feet");
    let message = $("#message");

    // Check if value_entered is invalid
    if (isNaN(value_entered)) {
        // Set error message in div "message"
        message.textContent = "Please enter a valid number.";
        value_computed.value = ""
        $("#value_entered").focus();
        return false;
    }

    // Clear error message
    message.textContent = "";

    // Perform conversion
    let result;
    if (to_celsius.checked) {
        result = calculateCelsius(value_entered);
    } else if (to_fahrenheit.checked) {
        result = calculateFahrenheit(value_entered);
    } else if (to_meters.checked) {
        result = calculateMeters(value_entered);
    } else if (to_feet.checked) {
        result = calculateFeet(value_entered);
    }

    console.log("Converted value: " + result.toFixed(2) + " " + value_computed.name);
    // Put result in the value_computed input box
    value_computed.value = result.toFixed(2);
}

const toggleToCelsius = () => toggleDisplay("Enter F degrees:", "Degrees Celsius:");
const toggleToFahrenheit = () => toggleDisplay("Enter C degrees:", "Degrees Fahrenheit:");
const toggleToMeters = () => toggleDisplay("Enter feet:", "Meters:");
const toggleToFeet = () => toggleDisplay("Enter meters:", "Feet:");

document.addEventListener("DOMContentLoaded", () => {
	// Add event handlers
	$("#convert").addEventListener("click", performConversion);
    $("#to_celsius").addEventListener("click", toggleToCelsius);
    $("#to_fahrenheit").addEventListener("click", toggleToFahrenheit);
    $("#to_meters").addEventListener("click", toggleToMeters);
    $("#to_feet").addEventListener("click", toggleToFeet);

	// Move focus
	$("#value_entered").focus();
});



