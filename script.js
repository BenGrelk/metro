/**
 * @fileoverview This file contains the main script for the website.
 * @author Ben Grelk
 * @license MIT
 */
"use strict";

/**
 * Obtain the json values from the manifest
 * @returns {JSON} The json values from the manifest
 */
function loadManifest() {
    let json;
    let request = new XMLHttpRequest();
    request.open("GET", "./mainifest.json", false);
    request.send(null);
    json = JSON.parse(request.responseText);
    return json;
}

/**
 * Add assignment to a list
 * @param {string} course The name of the course
 * @param {string} name The name of the assignment
 * @param {string} folder The due date of the assignment
 * @param {Element} list The list to add the assignment to
 */
function addAssignmentToList(course, name, folder, list) {
    let li = $("<li></li>");
    let a = $("<a></a>");

    a.attr("href", `./${course}/${folder}`);
    a.text(name)

    li.append(a);
    list.append(li);
}
