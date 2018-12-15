
$(document).on('click', '#deleteBtn', function (e) {
    e.preventDefault();
    var _form = $(this).parents('#deleteForm');
    swal({
        title: '¿Estás seguro?',
        text: 'De nuevo, esto no se puede deshacer.',
        type: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#FF8400',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Sí, estoy seguro',
        cancelButtonText: 'No, cancelar',
        closeOnConfirm: true,
        closeOnCancel: true
    },

    function (isConfirm) {
        if (isConfirm) {
            _form.submit();
        }
    });
});


