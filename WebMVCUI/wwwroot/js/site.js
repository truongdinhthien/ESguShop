// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(".AddToCart").submit(function (e) {
        e.preventDefault();
        var form = $(this);
        $.ajax({
            type: 'POST',
            url: '/Basket/AddToCart',
            data: form.serialize(),
            success: function (data) {
                $("#AmountItemInBasket").text(`(${data.totalAmount})`);
            }
        })
    })

    $("#DeleteAllCart").click(function (e) {
        $.ajax({
            type: 'POST',
            url: '/Basket/DeleteAllCart',
            success: function (data) {
                $("#BasketBodyTable").html(data);
            }
        })
    })

    $("#CheckOut").click(function (e) {
        console.log("Click");
        $.ajax({
            type: 'POST',
            url: '/Basket/CheckOut',
            success: function (data) {
                alert(data);
            },
            error: function (data) {
                alert(data.responseText);
            },
        })
    })
});