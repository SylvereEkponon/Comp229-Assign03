/*custom javascript goes here */

/* Name: Sylvere Ekponon */
/* Student ID: 300936445 */
/* Date: November 06, 2017 */
/* app.js file */

$(document).ready(function () {
    $("a.btn.btn-danger.btm-sm").click(function () {
        return confirm("Are you sure you want to delete this record?");
    });
});