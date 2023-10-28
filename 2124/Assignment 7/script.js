/*
    Benjamin Grekl
    script.js
    INFO 2124
    Yi
    10/22/2023
*/
"use strict"

$(document).ready(() => {
    const dt = new Date();
    $('#year').text(dt.getFullYear());
});

let list = [];

/**
 * Adds an item to the HTML list
 * @param {string} item - The item to add to the list
 * @param {HTMLElement} htmlList - The HTML list to add the item to
 */
function addItemToList(item, htmlList) {
    const listItem = $('<li></li>').text(item);
    htmlList.appendChild(listItem[0]);
}

/**
 * Removes all items from the HTML list
 * @param {HTMLElement} htmlList - The HTML list to remove all items from
 */
function removeItemsFromList(htmlList) {
    while (htmlList.firstChild) {
        htmlList.removeChild(htmlList.firstChild);
    }
}

/**
 * Checks if the item is valid and returns an error message if it is not
 * @param {string} item - The item to check
 * @returns {string | boolean} - The error message if there is one, otherwise false
 */
function getErrorMessage(item) {
    let error = false;
    if (list.length >= 6) {
        error = "List is full!";
    } else if (item === '') {
        error = "Please enter a value!";
    } else if (list.some(e => e.toLowerCase() === item.toLowerCase())) {
        error = "Item already in list!";
    }
    return error;
}

$(document).ready(() => {
    $('#addItemToList').click(() => {
        const itemElement = $('#listItemInput');
        const itemHolderElement = $("#listItemsHolder")[0];
        const item = itemElement.val().trim();

        itemElement.val(item);

        const error = getErrorMessage(item);
        if (error) {
            alert(error);
            return;
        }

        list.push(item);
        addItemToList(item, itemHolderElement);
    });

    $('#clearList').click(() => {
        const itemHolderElement = $("#listItemsHolder")[0];
        removeItemsFromList(itemHolderElement);

        // Clear the list
        list = [];
    });
});
