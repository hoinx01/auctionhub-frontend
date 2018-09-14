function login(userName, password) {
    $.ajax(
        "/common/accounts/login",
        {
            method: "POST",
            contentType: "application/json; charset=UTF-8",
            dataType: "application/json; charset=UTF-8",
            data: { userName: userName, password: password }
        }
    ).done(function () {
        alert("Đăng nhập thành công");
    }).fail(function (error) {
        console.log(error);
    });
}