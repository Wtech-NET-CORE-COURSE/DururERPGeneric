
$(document).ready(function (e) {
    $("#")
    var model = {
        name: $("[name='first-name']").val(),
        surname: $("[name='last-name']").val(),
        email: $("[name='email']").val(),
        password: $("[name='password']").val()
    };

    $.ajax({
        type: "POST",
        url: "/api/supplier/create",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(theContact),
        dataType: "json",
        success: function (data) {
            Swal.fire({
                text: "You have successfully reset your password!",
                icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
                customClass: { confirmButton: "btn btn-primary" }
            }).then((function (t) { t.isConfirmed && (e.reset()) }))
        },
        error: function (data) {

        }

    });
}