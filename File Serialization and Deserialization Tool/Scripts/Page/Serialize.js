$(document).ready(function ready() {
    /*
     * Page load
    */

    //hide result section.
    $("#serialize-result-section").hide();


    /*
    * Dynamic
    */

    //File name text on file input element on file change.
    $('input[type="file"]').change(function (e) {
        var fileName = e.target.files[0].name;
        $(".custom-file-label").html(fileName);
    });

    //File submit: prevent default submit and subit via Ajax.
    $("form").submit(function (event) {
        event.preventDefault();

        $.ajax({
            url: this.action,
            type: this.method,
            data: new FormData(this),
            cache: true,
            contentType: false,
            processData: false,
            success: function (response) {

                //Display result section with result text.
                $("#serialize-result-section").show();
                $("#serialize-result").val(response.data);
            },
            error: function (xhr, error, status) {
                //Error action
            }
        });
    });
    
    //Hide result section.
    $("#serialize-result-hide-button").click(function () {
        $("#serialize-result-section").toggle();
    });

    //Copy result text to clipboard.
    $("#copy-button").click(function () {
        copyToClipboard("serialize-result");
    });

});