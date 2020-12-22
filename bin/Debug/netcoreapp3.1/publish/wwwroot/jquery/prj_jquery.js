
var colorBeckGround = '#F3F3F3' /* The Color of the table rows #ffffff */
var colorRowClick = '#E4E4E4' /* #CCE4F7  lightgray darkseagreen The Color of the selected row in a table */
var colorCellClick = '#FFDB00' /* #CCE4F7  #FFDB00 #FFE469 #FFFF80 */

function SelectedRowColorChange() {    
    $('table tr').each(function (a, b) {
        $(b).click(function () {
            $('table tr').css('background', colorBeckGround);
            $(this).css('background', colorRowClick);
        });
    });
}

function SelectedCellColorChange() {
    $('table td').each(function (a, b) {
        $(b).click(function () {        
            $('table td').css('background', colorBeckGround);
            $(this).css('background', colorCellClick);
        });
    });

}

function ResetSelectedRowColorChange() { 
    $(document).ready(function(){
        $('table td').css('background', colorBeckGround);
        $(this).css('background', colorBeckGround);
        });   
}

// S_TreeView
/*
var toggler = document.getElementsByClassName("caret");
var i;  
function TreeView22() {
   
    for (i = 0; i < toggler.length; i++) {
      toggler[i].addEventListener("click", function() {
        this.parentElement.querySelector(".nested").classList.toggle("active");
        this.classList.toggle("caret-down");
      });
    }
}
*/
// E_TreeView




