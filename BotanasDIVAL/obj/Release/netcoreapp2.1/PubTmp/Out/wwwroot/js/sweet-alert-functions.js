
$(document).on('click', '#deleteBtn', function (e) {
    e.preventDefault();
    var _form = $(this).parents('#delete_form');
    swal({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        type: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, Delete it!',
        closeOnConfirm: true,
        closeOnCancel: true
    },

    function (isConfirm) {
        if (isConfirm) {
            _form.submit();
        }
    });
});


