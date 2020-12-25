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
                alert("Thêm giỏ hàng thành công");
                $("#AmountItemInBasket").text(`(${data.totalAmount})`);
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Not enough in stock');
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
        var deliveryAddress = $("#DeliveryAddress").val();
        var deliveryDateTime = $("#deliveryDateTime").val();
        $.ajax({
            type: 'POST',
            url: '/Basket/CheckOut',
            data: {
                deliveryAddress: deliveryAddress,
                deliveryDateTime: deliveryDateTime,
            },
            success: function (data) {
                alert("Thêm hóa đơn thành công");
                $("#BasketBodyTable").html(data);
            },
            error: function (data) {
                alert(data.responseText);
            },
        })
    })
});