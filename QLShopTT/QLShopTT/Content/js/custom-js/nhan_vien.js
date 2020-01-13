function loginNhanVien() {
    var user = $('#email_login').val();
    var pass = $('#email_pass').val();
    $.ajax({
        dataType: 'text',
        method: 'GET',
        url: '/NhanViens/LoginByStoredProcedure',
        data: { username : user, password: pass }
    }).done(function (data) {
        console.log(data);
    }).fail(function (jqXHR, textStatus, errorThrown) {

        console.log(textStatus + ': ' + errorThrown);
    });
}