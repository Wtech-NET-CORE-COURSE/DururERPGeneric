$(document).ready(function () {
    $("#register-button").click(function (r) {
        r.preventDefault();
        var userModel = {
            userName: document.getElementById('username').value,
            email: document.getElementById('email').value,
            passwordHash: document.getElementById('password').value,
        };
        //var userModel = {
        //    userName: $("[name='username']").val(),
        //    email: $("[name='email']").val(),
        //        passwordHash: $("[name='password']").val()
        //};
        $.ajax({
            type: "POST",
            url: "/api/login/create",
            contentType: "application/json;charset=utf-8",
            data: JSON.stringify(userModel),
            dataType: "json",
            success: function (data) {
                console.log(data);
                Swal.fire({
                    text: "Succesfully registered.",
                    icon: "success",
                    buttonsStyling: !1,
                    confirmButtonText: "Ok, got it!",
                    customClass: { confirmButton: "btn btn-primary" }
                }).then((function (t) {
                    if (t.isConfirmed === true)
                        window.location.href = "Login";
                }))
            },
            error: function (data) {
                console.log(data);
            }
        });

    });

});



function loginUser() {
    var userModel = {
        UserCredential: document.getElementById('username').value,
        password: document.getElementById('password').value,
    };
    $.ajax({
        type: "POST",
        url: "/api/login/login",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(userModel),
        dataType: "json",
        success: function (data) {
            // window.open("Suppliers");
            if (data !== undefined) {
                Swal.fire({
                    text: "Succesfully logged in. Redirecting..",
                    icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
                    customClass: { confirmButton: "btn btn-primary" }
                }).then((function (t) {
                    if (t.isConfirmed === true)
                        window.location.href = "Suppliers";
                }));
            }
            else {

            }


        },
        error: function (data) {
            console.log(data);
        }
    });
}