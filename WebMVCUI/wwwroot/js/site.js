// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var totalAmount = localStorage.getItem("totalAmount");
    if (totalAmount == null) {
        $("#AmountItemInBasket").text("");
    }
    else {
        $("#AmountItemInBasket").text(`(${totalAmount})`);
    }

    $(".AddToCart").submit(function (e) {
        e.preventDefault();
        var form = $(this);
        $.ajax({
            type: 'POST',
            url: '/Basket/AddToCart',
            data: form.serialize(),
            success: function (data) {
                console.log(data);
                $("#AmountItemInBasket").text(`(${data.totalAmount})`);
                localStorage.setItem("totalAmount", data.totalAmount);
            }
        })
    })

    $("#DeleteAllCart").click(function (e) {
        $.ajax({
            type: 'POST',
            url: '/Basket/DeleteAllCart',
            success: function (data) {
                $("#BasketBodyTable").html(data);
                $("#AmountItemInBasket").text("");
                localStorage.removeItem("totalAmount");
            }
        })
    })
});