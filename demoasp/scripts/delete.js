function DValidate() {

    var eno = document.getElementById("Texteno").value;  
    //alert("hello");
    if (eno.length != 0 )
        return true;
    else {
        alert("enter all details");
        return false;
    }

}