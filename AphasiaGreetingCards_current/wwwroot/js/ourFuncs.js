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

//--------WORDS API (Web API)---------
function wordsApi(word) {
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "https://wordsapiv1.p.rapidapi.com/words/" + word + "/typeOf",
        "method": "GET",
        "Content-type": "application/json",
        "headers": {
            "x-rapidapi-host": "wordsapiv1.p.rapidapi.com",
            "x-rapidapi-key": "49f063579cmsh838038dc0f5aa11p1f0acajsn6ca64000c24a"
        }
    }

    //handle the response
    $.ajax(settings).done(function (response) {
        var result = JSON.parse(JSON.stringify(response));
        var typeOf = result['typeOf'];
        var finalresult = "";
        for (i = 0; i < typeOf.length; i++) {
            finalresult += typeOf[i];
            if (i < typeOf.length - 1) {
                finalresult += ", ";
            }
        }
        $("#dictionaryResultLbl").replaceWith("<label class='control-label' id='dictionaryResultLbl'>" + finalresult + "</label>");
    });
}

$("#dictionaryBtn").click(function () {
    var word = document.getElementById("dictionaryInput").value;
    wordsApi(word);
});