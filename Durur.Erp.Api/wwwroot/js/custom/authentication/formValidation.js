var validator;
$(document).ready(function () {
    $(function () {

        //$('select[required]').css({
        //    position: 'absolute',
        //    display: 'inline',
        //    height: 0,
        //    padding: 0,
        //    border: '1px solid rgba(255,255,255,0)',
        //    width: 0
        //});

        validator=$("#register-form").validate({
            rules: {
                username: {
                    required: true,
                    minlength: 5
                },
                email: {
                    required: true,
                    email: true
                },
                password: {
                    required: true,
                    minlength: 5
                },
                "password-again": {
                    required: true,
                    minlength: 5,
                    equalTo: "#password"
                },
            },
            //For custom messages
            messages: {
                username: {
                    required: "Enter a username",
                    minlength: "Enter at least 5 characters"
                },
            },
            errorElement: 'div',
            errorPlacement: function (error, element) {
                var placement = $(element).data('error');
                if (placement) {
                    $(placement).append(error)
                } else {
                    error.insertAfter(element);
                }
            }
        });
    });
});