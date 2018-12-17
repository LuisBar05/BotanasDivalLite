//Simple script to change body background on admin's panel to any image uploaded and select custom
//overlay color and transparency of the wrapper
//@BalbyReny

document.getElementById('getBackground').addEventListener('change', readURL, true);
document.getElementById('getColor').addEventListener('input', readColor, true);
document.getElementById('clear').addEventListener('change', clearAll, true);

function readURL() {
    var file = document.getElementById('getBackground').files[0];
    var reader = new FileReader();
    reader.onloadend = function () {
        document.getElementById('body').style.backgroundImage = "url("+reader.result+")";
        localStorage.setItem("backgroundString","url("+reader.result+")"); 
    }
    if(file) {
        reader.readAsDataURL(file);
    }
}

function readColor() {
    var hexColor = document.getElementById('getColor').value;
    localStorage.setItem("pureColorString", hexColor); //only hex value
    var hexColorAlpha = hexColor+"80"; //50% opacity
    document.getElementById('wrapper').style.backgroundColor = hexColorAlpha;
    localStorage.setItem("colorString", hexColorAlpha);
}

function autoCustomize() {
    
    var backgroundConfig = localStorage.getItem("backgroundString");
    document.getElementById('body').style.backgroundImage = backgroundConfig;

    document.getElementById('getColor').value = localStorage.getItem("pureColorString");
    var overlayConfig = localStorage.getItem("colorString");
    document.getElementById('wrapper').style.backgroundColor = overlayConfig;
}

function clearAll() {
    localStorage.removeItem("pureColorString");
    localStorage.removeItem("colorString");
    localStorage.removeItem("backgroundString");
    var path = '"../images/bg.jpg"';
    //restore defaults
    document.getElementById('body').style.backgroundImage = 'url('+path+')';
    document.getElementById('wrapper').style.backgroundColor = 'rgba(255, 253, 232, 0.56)';
    location.reload();
}