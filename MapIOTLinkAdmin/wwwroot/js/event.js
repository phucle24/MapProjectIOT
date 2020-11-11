/*
$(document).ready(function () {
    
    $("btncreate").click(function () {
        var name = $("#Name").val();
        console.log(name);
        alert(name);
    })
    /*$('#formCreateObject').submit(function (e) {
        //event.preventDefault();
        var arForm = $(this).serializeArray();
        $.ajax({
            type: "POST",
            url: "http://localhost:5050/api/objects",
            data: JSON.stringify({ formVars: arForm }),
            dataType: 'json',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            success: function () {
                alert(data);
                console.log(data);  

            },
            error: function () {
                alert(data);
                console.log(data);  

            }
        })
    });
});
$(document).ready(function () {
        $("#formUserCreate").submit(function (event) {
            event.preventDefault();
            var name = $("#Name").val();
            var longtitude = $("#Longtitude").val();
            var latitude = $("#Latitude").val();
            $.ajax({
                url: "http://localhost:8090/api/objects",
                type: "POST",
                data: JSON.stringify([name, longtitude, latitude]), //{ Name: name, 
                // Address: address, DOB: dob },
                contentType: 'application/json; charset=utf-8',
                success: function (data) { },
                error: function () { alert('error'); }
            });
        });
});     */
