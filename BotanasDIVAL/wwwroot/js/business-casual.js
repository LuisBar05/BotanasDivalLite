function checkSession(){
    var adminSession = sessionStorage.getItem("admin-session");
    if (adminSession != "true") {
        location.replace("/Home/Login");     
    }    
}

function endSession() {
    sessionStorage.removeItem("admin-session");
}

function checkCreds() {
    var form = document.getElementById("publicToAdmin"); 
    if(form.email.value==f1) {
        if (form.password.value == f2) {
            sessionStorage.setItem("admin-session","true");
            localStorage.setItem("selected-id", 'homeLinkTitle');
            location = "/Home";      
        } else {
            swal({
                type: 'error',
                title: 'Oops...',
                text: '¡La contraseña que ingresaste es incorrecta!'
            })
        }
    } else {  
        swal({
            type: 'error',
            title: 'Oops...',
            text: '¡El E-mail que ingresaste es incorrecto!'        
        })
    }
}