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
