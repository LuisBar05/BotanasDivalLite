//Script to dinamically select the items on the side-menu
//@BalbyReny

function autoSelect() {
    var selectedID = localStorage.getItem("selected-id");
    var listItems = document.getElementsByTagName("li");

    for (i = 0; i < listItems.length; i++) {
        listItems[i].classList.remove("selected");
    }

    if (selectedID == "homeLinkImg" || selectedID == "homeLinkTitle") {
        document.getElementById("homeLink").classList.add("selected");
    }
    if (selectedID == "helpIndexLink") {
        document.getElementById("helpLink").classList.add("selected");
    }
    if (selectedID != "homeLinkImg" && selectedID != "homeLinkTitle" && selectedID != "helpLink") {
        document.getElementById(selectedID).classList.add("selected");
    }
    
}

function saveSelect(sID) {
    localStorage.setItem("selected-id",sID);
}