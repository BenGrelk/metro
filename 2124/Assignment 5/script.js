/*
    Benjamin Grekl
    script.js
    INFO 2124
    Yi
    10/09/2023
*/
"use strict"


$(document).ready(() => {
    // Cache the form
    const form = $('#contactForm');

    $('#submitButton').click((e) => {
        const emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;

        const firstName = form.find('#firstName').val().trim();
        const lastName = form.find('#lastName').val().trim();
        const emailAddress = form.find('#emailAddress').val().trim();
        const age = form.find('#age').val().trim();
        const mealHolder = form.find('input[name="meal"]:checked').val();
        const mealRating = form.find('input[name="rating"]:checked').val();

        // Replace contents to trimmed values
        form.find('#firstName').val(firstName);
        form.find('#lastName').val(lastName);
        form.find('#emailAddress').val(emailAddress);
        form.find('#age').val(age);

        let error = false;

        // Validate form
        if (firstName === "") {
            form.find('#firstName').next().text("First name is required!");
            error = true;
        } else {
            form.find('#firstName').next().text("");
        }
        if (lastName === "") {
            form.find('#lastName').next().text("Last name is required!");
            error = true;
        } else {
            form.find('#lastName').next().text("");
        }
        if (emailAddress === "") {
            form.find('#emailAddress').next().text("Email address is required!");
            error = true;
        } else if (!emailPattern.test(emailAddress)) {
            form.find('#emailAddress').next().text("Must be a valid email address!");
            error = true;
        } else {
            form.find('#emailAddress').next().text("");
        }
        if (age === "") {
            form.find('#age').next().text("Age is required!");
            error = true;
        } else if (isNaN(Number(age))) {
            form.find('#age').next().text("Must be a number!");
            error = true;
        } else if (age <= 0) {
            form.find('#age').next().text("Must be a positive number!");
            error = true;
        } else {
            form.find('#age').next().text("");
        }
        if (mealHolder === "" || mealHolder === undefined) {
            form.find('#mealHolder').next().text("Meal is required!");
            error = true;
        } else {
            form.find('#mealHolder').next().text("");
        }
        if (mealRating === "" || mealRating === undefined) {
            form.find('#mealRatingHolder').next().text("Meal rating is required!");
            error = true;
        } else {
            form.find('#mealRatingHolder').next().text("");
        }
        if (!error) {
            // If there are errors, submit the form
            form.submit();
        } else {
            // If there are errors, prevent the form from submitting
            e.preventDefault();
        }
    })

    $('#resetButton').click(() => {
        // When the reset button is clicked, clear the form and set focus to the first field
        form.find('#firstName').val('');
        form.find('#lastName').val('');
        form.find('#emailAddress').val('');
        form.find('#age').val('');
        form.find('#mealHolder').val('');
        form.find('#mealRatingHolder').val('');
        form.find('#firstName').focus();
    })
});