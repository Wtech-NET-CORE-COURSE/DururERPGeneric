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
                    icon: "success",
                    showConfirmButton:false,
                    timer: 1500
                }).then((function () {

                    console.log(data)
                        window.location.href = "Suppliers";
                }));
            }
            else {
                document.getElementById('errorCred').innerHTML ="Incorrect username or password.";
            }
        },
        error: function (data) {
            console.log(data);
        }
    });
}