$(document).ready(function () {
    $(".searhFormForGreetingCard").hide();
});

$(".btnToggleSearch").click(function () {
    $(".searhFormForGreetingCard").toggle();
});

$("#defaultImageGreetingCard").click(function () {
    $("#selectImageSearchGreetingCard").replaceWith("<input name='image' class='form-control'/>");
});

$("#defaultRecipientBtnGreetingCard").click(function () {
    $("#selectRecipientGreetingCards").replaceWith("<input id='recipientUserEmail' asp-for='recipientUserEmail' type='text' data-val='true' data-val-required='The Recipient User field is required' name='recipientUserEmail' class='form-control' value=''/>");
});

$("#defaultRecipientBtn").click(function () {
    $("#selectRecipient").replaceWith("<input id='recipientUserEmail' asp-for='recipientUserEmail' type='text' data-val='true' data-val-required='The Recipient User field is required' name='recipientUserEmail' class='form-control' value=''/>");
});



//---- google maps api ----------
var geocoder;
var map;
function initialize() {
    geocoder = new google.maps.Geocoder();
    var latlng = new google.maps.LatLng(32.109333, 34.855499);
    var mapOptions = {
        zoom: 9,
        center: latlng
    }
    map = new google.maps.Map(document.getElementById('map'), mapOptions);

    var tableRows = document.getElementsByTagName("tbody")[0].rows;
    for (i = 0; i < tableRows.length; i++) {
        row = tableRows[i];
        cell = row.cells[5];
        innerText = cell.innerText;
        codeAddress(innerText);
    }
}

//converts address to langtitude and latitude
function codeAddress(address) {
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status == 'OK') {
            map.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location
            });
        } else {
            alert('Geocode was not successful for the following reason: ' + status);
        }
    });
}

//---------------------------------
function initializeCanvas() {
    var c = document.getElementById("myCanvas");
    var ctx = c.getContext("2d");
    ctx.font = "30px Arial";
    ctx.fillText("Welcome!", 10, 50);
}