$("#btn-putOn").on("click", function (e) {
    var data = $("#form-putOn").serialize();
    $.post("/MoneyBox/PutOn", data, function (data) { });
});

$("#btn-getMoneyAmount").on("click", function (e) {
    $.get("/MoneyBox/GetMoneyAmount", null, function (data) {
        $("#p-moneyBox").html(data);
    });
})