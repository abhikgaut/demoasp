function validate()
{
    var un = document.getElementById("txtuser").value;
    var pwd = document.getElementById("txtpass").value;
    if (un.length == 0 || pwd.length == 0) {
        alert("enter username/password");
        return false;
    }
    else
        return true;
}