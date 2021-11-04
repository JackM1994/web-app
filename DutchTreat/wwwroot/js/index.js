$(document).ready(function () {
    const theForm = $("#theForm");
    theForm.hide();

    const button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying item");
    })
    const productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("clicked one of the items: " + $(this).text());
    });

    const $loginToggle = $("#loginToggle");
    const $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.slideToggle(1000);
    })
})

