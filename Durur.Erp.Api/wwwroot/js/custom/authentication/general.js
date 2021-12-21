function registerUser() {
    var userModel = {
        userName: document.getElementById('username').value,
        email: document.getElementById('email').value,
        passwordHash: document.getElementById('password').value,
    };
    $.ajax({
        type: "POST",
        url: "/api/login/create",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(userModel),
        dataType: "json",
        success: function(data) {
            console.log(data);
            Swal.fire({
                text: "Succesfully registered.",
                icon: "success",
                buttonsStyling: !1,
                confirmButtonText: "Ok, got it!",
                customClass: { confirmButton: "btn btn-primary" }
            }).then((function(t) { t.isConfirmed && (e.reset()) }))
        },
        error: function(data) {
            console.log(data);
        }
    }).done(function(data) {
        $.ajax({
            type: 'Get',
            url: '/Login'
        })
    });
}

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
        success: function(data) {
            // window.open("Suppliers");
            window.location.href = "Suppliers";
            // Swal.fire({
            //     text: "Succesfully logged in.",
            //     icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
            //     customClass: { confirmButton: "btn btn-primary" }
            // }).then((function (t) { t.isConfirmed && (e.reset()) }))
        },
        error: function(data) {
            console.log(data);
        }
    });
}