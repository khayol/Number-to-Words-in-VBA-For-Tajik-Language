function msgbox(p_msg_txt) {
    alert(p_msg_txt);
}
function console_write(p_msg_txt) {
    console.log(p_msg_txt);
}

function saveMessage(firstName, lastName) {
    alert(firstName+''+lastName+'Record has been saved successfully');
}

// For Exporting Excel File 
function saveAsFile(fileName, byteBase64) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = 'data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;base64,' + byteBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}






