$(document).ready(function (e) {
    $('.modal').modal();


    $.ajax({
        type: "GET",
        url: '/api/country',
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var data = $.map(result, function (obj) {
                obj.id = obj.id || obj.country_ID; // replace pk with your identifier
                obj.text = obj.text || obj.country_Name;
                return obj;
            });
            $('#countrySelection').select2({
                data: data,
                matcher: matchCustom,
                dropdownParent: $("#addsuppliermodal")
            });
        }
    });



    //$.ajax({
    //    type: "GET",
    //    url: "/api/supplier",
    //    contentType: "application/json;charset=utf-8",
    //    dataType: "json",
    //    success: function (data) {
    //        var table = $("#suppliers-list-datatable").DataTable();


    //        $.each(data, function (key, val) {
    //            // table.row.add([
    //            //     "",
    //            //     data[key].supplier_ID,
    //            //     data[key].supplier_Name,
    //            //     data[key].createdDate,
    //            //     data[key].lastModifiedDate
    //            // ]).draw(false);
    //            table.row.add([
    //                '<td>' + data[key].supplier_ID + '</td>',
    //                '<td><a href="page-users-view">' + data[key].supplier_Name + '</a></td>',
    //                '<td>' + data[key].createdDate + '</td>',
    //                '<td>' + data[key].lastModifiedDate + '</td>',
    //                '<td><div class="center-align"><a href="page-users-edit"><i class="material-icons">edit</i></a><a href="page-users-view"><i class="material-icons">remove_red_eye</i></a></div></td>'
    //            ]).draw(false);
    //            //$("#users-list-datatable").append('<tr><td></td><td>' + data[key].supplier_ID + '</td><td><a href="page-users-view.html">' + data[key].supplier_Name + '</a></td><td>' + data[key].createdDate + '</td><td>' + data[key].lastModifiedDate + '</td></tr>');

    //        });
    //    },
    //    _error: function (data) {
    //        alert(data)
    //    }
    //});

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


$('.lang').click(function () {
    $('#suppliers-list-datatable').DataTable().clear().destroy();
    var pageLang = $(this).data('language');
    var datatableLanguages = {
        'tr': '//cdn.datatables.net/plug-ins/1.11.3/i18n/tr.json',
        'en': '',
        'fr': '//cdn.datatables.net/plug-ins/1.11.3/i18n/fr_fr.json',
        'pt': '//cdn.datatables.net/plug-ins/1.11.3/i18n/pt_br.json',
        'de': '//cdn.datatables.net/plug-ins/1.11.3/i18n/de_de.json'
    };

    $("#suppliers-list-datatable").DataTable({
        serverSide: true,
        processing: true,
        filter: true,
        autoWidth: false,
        language: {
            url: datatableLanguages[pageLang]
        },
        responsive: !0,
        "ajax": {
            "url": "/api/supplier/GetSuppliersFiltered",
            "type": "POST",
            "datatype": "json"
        },
        columnDefs: [
            { orderable: !1, targets: [4] },
            { width: "1%", targets: 0 },
            { width: "120px", targets: 1 }
        ],
        columns: [
            { "data": "supplier_ID", "name": "Supplier_ID" },
            { "data": "supplier_Name", "name": "Supplier_Name" },
            { "data": "createdDate", "name": "CreatedDate" },
            { "data": "lastModifiedDate", "name": "LastModifiedDate" },
            { "render": function (data, row) { return '<div class="center-align"><a href="page-users-edit"><i class="material-icons">edit</i></a><a href="page-users-view"><i class="material-icons">remove_red_eye</i></a></div>' } }
        ]
    });

});

function updateLocations() {

    var results = $('#countrySelection').select2('data');
    var locaApiUri = '/api/location/GetByCountryID/' + results[0].country_ID;
    $('#locationselect').empty();
    $.ajax({
        type: "GET",
        url: locaApiUri,
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var data = $.map(result, function (obj) {
                obj.id = obj.id || obj.location_ID; // replace pk with your identifier
                obj.text = obj.text || obj.city;
                return obj;
            });
            $('#locationselect').select2({
                data: data
            });
        }
    });
}

function matchCustom(params, data) {
    // If there are no search terms, return all of the data
    if ($.trim(params.term) === '') {
        return data;
    }

    // Do not display the item if there is no 'text' property
    if (typeof data.text === 'undefined') {
        return null;
    }

    // `params.term` should be the term that is used for searching
    // `data.text` is the text that is displayed for the data object
    if (data.text.indexOf(params.term) > -1) {
        var modifiedData = $.extend({}, data, true);
        modifiedData.text += ' (matched)';

        // You can return modified objects from here
        // This includes matching the `children` how you want in nested data sets
        return modifiedData;
    }

    // Return `null` if the term should not be displayed
    return null;
}