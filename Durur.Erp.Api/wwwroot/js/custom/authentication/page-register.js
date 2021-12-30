$(document).ready(function () {
    var regbutton = document.getElementById("register-button");
    regbutton.addEventListener("click", function (r) {
        r.preventDefault();

        $("#register-form").valid();
        console.log(validator.numberOfInvalids());
        if (validator.numberOfInvalids() === 0) {
            //var userModel = {
            //    userName: $("[name='username']").val(),
            //    email: $("[name='email']").val(),
            //        passwordHash: $("[name='password']").val()
            //};
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
                success: function (data) {
                    Swal.fire({
                        text: "Succesfully registered.",
                        icon: "success",
                        buttonsStyling: !1,
                        confirmButtonText: "Ok, got it!",
                        customClass: { confirmButton: "btn btn-primary" }
                    }).then((function (t) {
                        if (t.isConfirmed === true)
                            window.location.href = "Login";
                    }));
                },
                error: function (data) {
                    console.log(data);
                }
            });
        }

    });
});