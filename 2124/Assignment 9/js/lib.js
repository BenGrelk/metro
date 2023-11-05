/**
 * Benjamin Grelk
 * lib.js
 * INFO 2124
 * Yi
 * 11/4/2023
 */
"use strict"


/**
 * WeatherForecast class that holds weather forecast data
 */
class WeatherForecast {
/**
     * Constructor for WeatherForecast
     * @param {string} d - date
     * @param {number} t - temperature
     * @param {number} tM - min temperature
     * @param {number} tX - max temperature
     */
    constructor(d, t, tM, tX) {
        console.log(d, t, tM, tX);
        this.date = d;
        this.temp = t;
        this.tempMin = tM;
        this.tempMax = tX;
    }

    /**
     * Returns the date
     * @returns {Date} - date
     */
    getDate() {
        return new Date(this.date);
    }

    /**
     * Returns the temperature
     * @returns {number} - temperature
     */
    getTemp() {
        return this.temp;
    }

    /**
     * Returns the max temperature
     * @returns {number} - max temperature
     */
    getMaxTemp() {
        return this.tempMax;
    }

    /**
     * Returns the min temperature
     * @returns {number}
     */
    getMinTemp() {
        return this.tempMin;
    }

    /**
     * Returns the day string
     * @returns {string}
     */
    getDayString() {
        let d = new Date(this.date);
        let day = d.getDay();
        let date = d.getDate();
        let mon = d.getMonth() + 1;
        let dayName = '';
        switch (day) {
            case 0:
                dayName = 'Sun';
                break;
            case 1:
                dayName = 'Mon';
                break;
            case 2:
                dayName = 'Tue';
                break;
            case 3:
                dayName = 'Wed';
                break;
            case 4:
                dayName = 'Thu';
                break;
            case 5:
                dayName = 'Fri';
                break;
            case 6:
                dayName = 'Sat';
                break;
        }

        let s = `${dayName}, ${mon}/${date}`;
        return s;
    }
}
