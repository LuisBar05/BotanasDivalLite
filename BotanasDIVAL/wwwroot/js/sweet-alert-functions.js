
$(document).ready(function () {
    $(document).on('click', '#confirmBtn', function (e) {
        e.preventDefault();
        var _form = $(this).parents('#confirmForm');
        swal({
            title: 'Se necesita confirmación',
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#FF8400',
            cancelButtonColor: '#d33',
            confirmButtonText: '¡Sí, guárdalo!',
            cancelButtonText: 'No, cancélalo',
        }).then((result) => {
            if (result) {
                _form.submit();
            }
        });
    });

    $(document).on('click', '#deleteBtn', function (e) {
        e.preventDefault();
        var _form = $(this).parents('#deleteForm');
        swal({
            title: '¿Estás seguro?',
            text: 'De nuevo, esto no se puede deshacer',
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#FF8400',
            cancelButtonColor: '#d33',
            confirmButtonText: '¡Sí, estoy seguro!',
            cancelButtonText: 'No, cancelar',
        }).then((result) => {
            if (result) {
                _form.submit();
            }
        });
    });
});





