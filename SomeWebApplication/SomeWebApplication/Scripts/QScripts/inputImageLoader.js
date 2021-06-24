function readURL(input) {
    if (input.files && input.files[0]) {
        const reader = new FileReader();

        reader.onload = function (e) {
            $('#cover-display').attr('src', e.target.result);
            console.log('read UrlOnLoad');
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#CoverFile").change(function () {
    readURL(this);
});