function Validate()
{

    var eno = document.getElementById("txteno").value;
    var ename = document.getElementById("txtname").value;
    var job = document.getElementById("txtjob").value;
    var mgr = document.getElementById("txtmid").value;
    var hd = document.getElementById("txtdate").value;
    var sal = document.getElementById("txtsal").value;
    var comm = document.getElementById("txtcom").value;
    var dno = document.getElementById("txtdno").value;
    //alert("hello");
    if (eno.length != 0 && ename.length != 0 && job.length != 0 && mgr.length != 0 && hd.length != 0 && sal.length != 0 && comm.length != 0 && dno.length != 0)
        return true;
    else {
        alert("enter all details");
        return false;
    }

}