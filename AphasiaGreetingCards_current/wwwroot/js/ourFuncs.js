$(document).ready(function () {
    $("#searhFormForGreetingCard").hide();
});

$("#btnToggleSearch").click(function () {
    $("#searhFormForGreetingCard").toggle();
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
