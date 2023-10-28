/**
 * Benjamin Grelk
 * lib_convert.js
 * INFO 2124
 * Yi
 * 10/27/2023
 */
"use strict"


/**
 * @class SuperDate - Extends the Date class to add additional functionality.
 */
class SuperDate extends Date {
    /**
     * @constructor Creates a new SuperDate object.
     * @param {Date} unit - The date unit to convert.
     */
    constructor(unit) {
        if (unit === undefined) {
            super();
        } else {
            super(unit);
        }
    }

    /**
     * @returns {string} - The full name of the month.
     */
    getFullDayName() {
        // Create an array of the days and index the current day.
        return ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"][this.getDay()];
    }

    /**
     * @returns {string} - The first three letters of the day.
     */
    getShortDayName() {
        return this.getFullDayName().substring(0, 3);
    }

    /**
     * @returns {string} - The full name of the month.
     */
    getFullMonthName() {
        return ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"][this.getMonth()];
    }

    /**
     * @returns {string} - The first three letters of the month.
     */
    getShortMonthName() {
        return this.getFullMonthName().substring(0, 3);
    }
}
