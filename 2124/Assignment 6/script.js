/*
    Benjamin Grekl
    script.js
    INFO 2124
    Yi
    10/15/2023
*/
"use strict"


//This is a helper function to convert a string
//to a numeric value
//Returns:
//      - An integer or a float value of the string
//Throws:
//      - Error if the string is not a number
function convertToNumber(numVal) {
    if (!isNaN(numVal)) {
        /*
        if (Number.isInteger(numVal)) {
            return parseInt(numVal);
        } else {
            return parseFloat(numVal);
        }
         */
        return (Number.isInteger(numVal)) ? parseInt(numVal) : parseFloat(numVal);
    } else {
        throw new Error("Value to convert must be a number!");
    }
}

$(document).ready(() => {
    const convertButton = $('#convertButton');
    let valueToConvert = 0;
    const valueHolder = $('#valueHolder');

    convertButton.on('click', () => {
        const selectedOptionValue = $('#conversionSelector :selected').val();

        try {
            // Get number from valueHolder
            valueToConvert = valueHolder.val();
            valueToConvert = convertToNumber(valueToConvert);
        } catch (error) {
            alert("Error: Value to convert must be a number!");
            reset()
            return;
        }

        if (valueToConvert < 0) {
            alert("Error: Value to convert cannot be less than zero!");
            reset()
            return;
        } else if (valueToConvert === 0) {
            alert("Error: Value to convert must be greater than zero!");
            reset()
            return;
        }

        // Perform conversion
        let convertedValue, unit1, unit2;
        switch (selectedOptionValue) {
            case "m2k":
                convertedValue = valueToConvert * 1.60934;
                unit1 = "miles";
                unit2 = "kilometers";
                break;
            case "k2m":
                convertedValue = valueToConvert * 0.621371;
                unit1 = "kilometers";
                unit2 = "miles";
                break;
            case "p2k":
                convertedValue = valueToConvert * 0.453592;
                unit1 = "pounds";
                unit2 = "kilograms";
                break;
            case "k2p":
                convertedValue = valueToConvert * 2.20462;
                unit1 = "kilograms";
                unit2 = "pounds";
                break;
            case "f2m":
                convertedValue = valueToConvert * 0.3048;
                unit1 = "feet";
                unit2 = "meters";
                break;
            case "m2f":
                convertedValue = valueToConvert * 3.28084;
                unit1 = "meters";
                unit2 = "feet";
                break;
            case "f2c":
                convertedValue = (valueToConvert - 32) * (5 / 9);
                unit1 = "fahrenheit";
                unit2 = "celsius";
                break;
            case "c2f":
                convertedValue = (valueToConvert * (9 / 5)) + 32;
                unit1 = "celsius";
                unit2 = "fahrenheit";
                break;
            default:
                alert("Error: Invalid option selected!");
                reset()
                return;
        }

        // Display result
        alert(`${valueToConvert} ${unit1} is ${convertedValue.toFixed(2)} ${unit2}`);

        function reset() {
            // Set value in valueHolder to 0
            valueHolder.val(0);
        }
    });
});
