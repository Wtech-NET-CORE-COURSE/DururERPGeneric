var validator;
$(document).ready(function () {
    $(function () {
        validator = $("#supplierForm").validate({
            rules: {
                supplierName: {
                    required: true,
                    minlength: 5
                }
            },
            //For custom messages
            messages: {
                supplierName: {
                    required: "Enter a supplier name",
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