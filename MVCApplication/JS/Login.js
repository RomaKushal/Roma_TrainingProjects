
function ValidateLogin() {
    if ($("#txtLoginName").val() == "") {
        $("#spnLoginName").text("Please enter Login Name");
        return false;
    }
    else if ($("#txtLoginPassword").val() == "") {
        $("#spnLoginPassword").text("Please enter Password");
        return false;
    }
    $.ajax({
        type: "Post",
        url: "/Account/ValidateLogin",
        cache: false,
        dataType: "json",
        data: {
            username: $("#txtLoginName").val(),
            password: $("#txtLoginPassword").val()
        },
        success: function (data, status, xhr) {
            if (data == "success") {
                
                var action = "/Account/Dashboard";
                SuccessMessage(data, action);
            } else {
                $("#txtLoginName").val("");
                $("#txtLoginPassword").val("");
                ErrorMessage("Invalid Credentials");
            }
        }
    });
}

