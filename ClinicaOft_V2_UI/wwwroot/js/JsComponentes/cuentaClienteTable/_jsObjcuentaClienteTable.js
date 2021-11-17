

//activar el contenido del acordeon
const enableActiveAccordion = tagId => {
    let activeTag = document.getElementsByClassName("ActiveAccordion");
    if (activeTag.length != 0) {
        let activeTagElement = activeTag.item(0);
        activeTagElement.classList.replace("ActiveAccordion", "InactiveAccordion");

        if (activeTagElement.id != "colapseFile-" + tagId) {
            document.getElementById("colapseFile-" + tagId).classList.replace("InactiveAccordion", "ActiveAccordion");
        }
    } else {
        document.getElementById("colapseFile-" + tagId).classList.replace("InactiveAccordion", "ActiveAccordion");
    }

}








