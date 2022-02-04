function IsDigit(e) {
    var keyCode = e.which ? e.which : e.keyCode
    var result = ((keyCode >= 48 && keyCode <= 57) || keyCode == 9 || keyCode == 8);
    return result;
}