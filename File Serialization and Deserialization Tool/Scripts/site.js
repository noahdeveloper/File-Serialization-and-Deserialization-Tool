/**
 * Copies cotent from element to clipboard.
 * @param {string} inputId the name of the element Id from which the content is copied to the clipboard.
 */
function copyToClipboard(inputId) {
    //Get the text field 
    var copyText = $("#" + inputId);

    // Select the text field
    copyText.select();

    // Copy the text inside the text field
    document.execCommand("copy");
}