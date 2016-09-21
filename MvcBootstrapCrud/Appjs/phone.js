$(function () {
    $.ajaxSetup({ cache: false });
    //$("a[data-modal]").on("click", function (e) {
    $(document).on("click","a[data-modal]", function (e) {
        $('#myModalContent').load(this.href, function () {
            $('#myModal').modal({
                keyboard: true
            }, 'show');
            bindForm(this);
        });
        return false;
    });
});

function bindForm(dialog) {
    $('form', dialog).submit(function () {
        $('#progress').show();
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
           
            success: function (result) {
                if (result.success) {
                    $('#myModal').modal('hide');
                    $('#progress').hide();
                    //$('#ajaxgrid').html(result);
                    location.reload();
                    
                } else {
                    $('#progress').hide();
                    $('#myModalContent').html(result);
                    bindForm();
                }
            }
        });
        return false;
    });
}


