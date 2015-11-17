$(function () {
    var ajaxFormSubmit = function () {
        var $form = $(this);
        var error_free = true;
        var error_message = "";
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };
        if ($('.datatitle').val() == false)
        {
            error_free = false;
            error_message = "title not written";
        }
        if ($('.databody').val() == false)
        {
            error_free = false;
            error_message = "body not written";
        }
        if (error_free)
        {
            $.ajax(options).done(function (data) {
                var $target = $($form.attr("data-gt-target"));
                $target.replaceWith(data);
            });
            return false;
        }
        else
        {
            alert("form incomplete "+ error_message);
            return false;
        }
        
    }
    $("form[data-gt-ajax=true]").submit(ajaxFormSubmit);
    

});