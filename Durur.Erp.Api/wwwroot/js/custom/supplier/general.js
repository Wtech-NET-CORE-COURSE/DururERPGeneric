$(document).ready(function(e) {
    $('.modal').modal();


    $.ajax({
        type: "GET",
        url: "/api/supplier",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function(data) {
            var table = $("#suppliers-list-datatable").DataTable();


            $.each(data, function(key, val) {
                // table.row.add([
                //     "",
                //     data[key].supplier_ID,
                //     data[key].supplier_Name,
                //     data[key].createdDate,
                //     data[key].lastModifiedDate
                // ]).draw(false);
                table.row.add([
                    '<td>' + data[key].supplier_ID + '</td>',
                    '<td><a href="page-users-view">' + data[key].supplier_Name + '</a></td>',
                    '<td>' + data[key].createdDate + '</td>',
                    '<td>' + data[key].lastModifiedDate + '</td>',
                    '<td><div class="center-align"><a href="page-users-edit"><i class="material-icons">edit</i></a><a href="page-users-view"><i class="material-icons">remove_red_eye</i></a></div></td>'
                ]).draw(false);
                //$("#users-list-datatable").append('<tr><td></td><td>' + data[key].supplier_ID + '</td><td><a href="page-users-view.html">' + data[key].supplier_Name + '</a></td><td>' + data[key].createdDate + '</td><td>' + data[key].lastModifiedDate + '</td></tr>');

            });
        },
        _error: function(data) {
            alert(data)
        }
    });

    //$("#add-user-button")
    //var model = {
    //    name: $("[name='first-name']").val(),
    //    surname: $("[name='last-name']").val(),
    //    email: $("[name='email']").val(),
    //    password: $("[name='password']").val()
    //};

    //$.ajax({
    //    type: "POST",
    //    url: "/api/supplier/create",
    //    contentType: "application/json;charset=utf-8",
    //    data: JSON.stringify(theContact),
    //    dataType: "json",
    //    success: function (data) {
    //        Swal.fire({
    //            text: "You have successfully reset your password!",
    //            icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
    //            customClass: { confirmButton: "btn btn-primary" }
    //        }).then((function (t) { t.isConfirmed && (e.reset()) }))
    //    },
    //    error: function (data) {

    //    }

    //});

});