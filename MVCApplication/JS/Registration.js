function CallbackSuccess(data) {
    alert("js");
    if (data == "success") {
        $("#txtFirstName").val("");
        $("#txtLastName").val("");
        $("#txtEmail").val("");
        $("#txtMobilenumber").val("");
        $("#txtPassword").val("");
        $("#txtRetypepassowrd").val("");
        $("#txtUserName").val("");
        SuccessMessage("User has been registered successfully.", "/Account/Register");
    }
    else {
        WarningMessage("Something went wrong. Please tryt again.");
        return false;
    }
}

function PasswordEyeviewStatus(txtid, iconid) {
    $("i#" + iconid).hasClass("fa-eye-slash") ? (
        $("#" + txtid).prop("type", "text"),
        $("i#" + iconid).removeClass(" fa-eye-slash "),
        $("i#" + iconid).addClass(" fa-eye ")) : ($("#" + txtid).prop("type", "password"), $("i#" + iconid).removeClass("fa-eye"),
            $("i#" + iconid).addClass("fa-eye-slash"))
}
