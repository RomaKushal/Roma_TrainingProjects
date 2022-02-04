function ConformDelete(func, id) {
    swal({
        title: "Are you sure,you want to delete?",
        text: "",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#f37234",
        confirmButtonText: "Yes",
        cancelButtonText: "No",
        closeOnConfirm: false,
        closeOnCancel: true
    }, function (isConfirm) {
        if (isConfirm) {
            try { func(id); }
            catch (err) { alert(err.message); }
            //swal("Deleted!", "Your Record is Deleted", "success");
        }
    });
    return false;
}

/**
 * Date : 03-12-2019
 * this funcation get daynamic param 
 * @param func is name on callback funcation
 * @param id its is list of param add into
 * Bhupat
 */
function ConformDeleteMultiParam(func, id) {
    swal({
        title: "Are you sure,you want to delete?",
        text: "",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#f37234",
        confirmButtonText: "Yes",
        cancelButtonText: "No",
        closeOnConfirm: false,
        closeOnCancel: true
    }, function (isConfirm) {
        if (isConfirm) {
            try { func(id); }
            catch (err) { alert(err.message); }
        }
    });
    return false;
}

function SuccessMessage(txt, url) {
    swal({
        title: "Success!",
        type: "success",
        text: txt,
        confirmButtonColor: "#8fd468",
    }, function () {
        if (url != "")
        window.location.href = url;
    });
    return false;
}

function ErrorMessage(txt) {
    swal({
        title: "Error!",
        type: "error",
        text: txt,
        confirmButtonColor: "#ff9494",
    });
    return false;
}

function WarningMessage(txt) {
    swal({
        title: "",
        type: "warning",
        text: txt,
        confirmButtonColor: "#DD6B55",
    });
    return false;
}

/*
 * Date : 31-12-2019
 * Note : session timeout
*/

function SessionExpiredMessage(txt, url) {
    swal({
        title: "Session Timeout!",
        type: "error",
        text: txt,
        confirmButtonColor: "#ff9494",
    }, function () {
        if (url != "")
            window.location.href = url;
    });
    return false;
}

//Confirm Options.
function ConformPrompt(func, id, status, layername, titlemsg) {
    swal({
        title: titlemsg,
        text: "",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#f37234",
        confirmButtonText: "Yes",
        cancelButtonText: "No",
        closeOnConfirm: false,
        closeOnCancel: true
    }, function (isConfirm) {
        if (isConfirm) {
            try { func(id, status, layername); }
            catch (err) { alert(err.message); }
            //swal("Deleted!", "Your Record is Deleted", "success");
        }
    });
    return false;
}