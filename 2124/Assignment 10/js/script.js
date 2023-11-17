/**
 * Benjamin Grelk
 * script.js
 * INFO 2124
 * Yi
 * 11/16/2023
 */
"use strict"

// When the document is ready, do all the code inside
$(document).ready(() => {
    // Define constants used in this scope
    const baseUrl = 'https://www.mccinfo.net/epsample/employees';
    const employeeList = document.getElementById('employeeList');
    const employeeInfo = document.getElementById('employeeInfo');

    // Hide fields that shuoldn't be shown yet
    $('#errorHolder').hide();
    $('#loadingHolder').hide();
    $('#employeeList').hide();

    // When the "Get Employees" button is clicked, run the following
    $('#getEmployees').click((evt) => {
        // Cool animations
        $(evt.target).parent().slideUp();
        $('#loadingHolder').slideDown();

        // Use promises to get data from the web server
        fetch(baseUrl)
            .then(response => response.json())
            .then((employees) => {
                // Add each employee to the DOM
                for (let employee of employees) {
                    let div = document.createElement('div');
                    let a = document.createElement('a');
                    a.href = '#';
                    a.id = employee.id;
                    a.innerHTML = `${employee.first_name} ${employee.last_name}`;
                    a.addEventListener('click', onEmployeeClicked);
                    div.appendChild(a);
                    employeeList.appendChild(div);
                }

                $('#loadingHolder').fadeOut(400, () => {
                    $('#employeeList').fadeIn();
                });
            })
    });

    /**
     * When an employee is clicked, get their information from the server
     * @param e The event that was triggered
     */
    const onEmployeeClicked = (e) => {
        $('#errorHolder').hide();
        $('#errorHolder').html('');
        employeeInfo.innerHTML = '';

        fetch(`${baseUrl}\/${e.currentTarget.id}`)
            .then(response => response.json())
            .then((employee) => {
                // Add the employee info to the DOM
                let div = document.createElement('div');

                // Load the image
                let img = document.createElement('img');
                img.src = employee.image_filename;
                img.alt = `${employee.first_name} ${employee.last_name}`;

                let h1 = document.createElement('h1');
                h1.innerText = `${employee.first_name}  ${employee.last_name}`;

                let divDepartment = document.createElement('div');
                divDepartment.innerText = ``;

                let divSalary = document.createElement('div');
                const salaryAmount = employee.annual_salary;
                // Format the salary with the accounting.js library
                const salaryFormatted = accounting.formatMoney(salaryAmount);
                divSalary.innerText = `Annual Salary: ${salaryFormatted}`;

                let divHireDate = document.createElement('div');
                divHireDate.innerText = `Hire Date: ${employee.hire_date}`

                // Add everything to the div
                div.appendChild(img);
                div.appendChild(h1);
                div.appendChild(divDepartment);
                div.appendChild(divSalary);
                div.appendChild(divHireDate);

                employeeInfo.appendChild(div);
            })
            .catch((e) => {
                // If there's an error, show it to the user
                console.log(`Error: ${e}`);
            });
    }
});