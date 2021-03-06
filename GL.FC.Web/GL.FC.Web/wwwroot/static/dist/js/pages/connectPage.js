var _gaq = _gaq || [];
_gaq.push(['_setAccount', 'UA-36251023-1']);
_gaq.push(['_setDomainName', 'jqueryscript.net']);
_gaq.push(['_trackPageview']);

(function () {
    var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
})();

$(document).on('change', '#UploadForm', function () {
    //readURL(this);
    imagesPreview(this, 'div.gallery');
});
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#prvwUploadedImg').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]); // convert to base64 string
        $('#prvwUploadedImg').show();
    }
}
function imagesPreview(input, placeToInsertImagePreview) {
    if (input.files) {
        if (!/\.(jpe?g|png|gif)$/i.test(input.files[0].name)) {
            return alert(input.files[0].name + " is not an image");
        }
        else {
            var filesAmount = input.files.length;

            for (i = 0; i < filesAmount; i++) {
                var reader = new FileReader();

                reader.onload = function (event) {
                    //$($.parseHTML('<img>')).attr('src', event.target.result).appendTo(placeToInsertImagePreview);
                    $($.parseHTML('<img>')).attr({
                        'src': event.target.result,
                        'height': 100,
                        'width': '200px'
                    }).css({
                        'margin-left': '5px',
                        'margin-bottom': '10px'
                    }).appendTo(placeToInsertImagePreview);
                }

                reader.readAsDataURL(input.files[i]);
            }
            //$('#prvwUploadedImg').show();
        }
    }
}

$(function () {
    $("#dropdown-menu-forBtn").on('click', 'li a', function () {
        $(".btn-catgry:first-child").text($(this).text());
        $(".btn-catgry:first-child").val($(this).text());
        $('input[name=CategoryId][value=' + ('' + (parseInt($(this).data("value"))) + ']')).prop('checked', true);
    });
});

