/*
    Benjamin Grekl
    script.js
    INFO 2124
    Yi
    09/25/2023
*/
"use strict"


function calculateTax(subtotal, taxRate) {
    const tax = parseFloat(subtotal * taxRate);
    return tax.toFixed(2);
}

function print(grossWages, federalTax, stateTax, ssTax, medicareTax, netWages) {
    const msg = `
                Gross wages: $${grossWages.toFixed(2)}

                Deductions:
                --------------------------------
                Federal Taxes:   $${federalTax.toFixed(2)}
                State Taxes:     $${stateTax.toFixed(2)}
                Social Security: $${ssTax.toFixed(2)}
                Medicare:        $${medicareTax.toFixed(2)}

                Net wages: $${netWages.toFixed(2)}
    `;
    alert(msg);
}

const $ = (id) => document.getElementById(id);

// Wait for the DOM to load
document.addEventListener("DOMContentLoaded", () => {
    // Wait for the button to be clicked
    const btn = $("calculateTaxes");
    btn.addEventListener("click", () => {
        // Calculate the taxes
        const grossWages = parseFloat($("monthlySalary").value);
        const federalTax = parseFloat(calculateTax(grossWages, 0.12));
        const stateTax = parseFloat(calculateTax(grossWages, 0.05));
        const ssTax = parseFloat(calculateTax(grossWages, 0.06));
        const medicareTax = parseFloat(calculateTax(grossWages, 0.015));
        const netWages = parseFloat((grossWages - federalTax - stateTax - ssTax - medicareTax).toString());

        // Print the results
        print(grossWages, federalTax, stateTax, ssTax, medicareTax, netWages);
    });
});
