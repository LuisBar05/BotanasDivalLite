var form = document.getElementById("publicToAdmin");
function checkCreds() {
    if(form.email.value==f1) {
        if(form.password.value==f2) {
            localStorage.setItem("selected-id", 'homeLinkTitle');
            location="/Home"; 
        } else {
            alert("La contraseña que ingresaste es incorrecta.");
        }
    } else {  
        alert("El E-mail que ingresaste es incorrecto.");
    }
}