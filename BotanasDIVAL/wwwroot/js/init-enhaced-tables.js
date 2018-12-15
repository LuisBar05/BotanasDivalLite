//Script to initialize control functions on all tables when ready on DOM
//Added: by default filtering to "Disponible" entries but allowing the user to refine the search 
//@BalbyReny

$(document).ready(function () {
    $('#comprasTable').dataTable();
    $('#detCompraTable').dataTable();
    $('#ventasTable').dataTable();
    $('#pedidosTable').dataTable();
    $('#statusTable').dataTable();
    $('#categoriasTable').dataTable();
    $('#presentacionesTable').dataTable();
    $('#unimedTable').dataTable();
    $('#almacenTable').dataTable();
    $('#ingredientesTable').dataTable();
    $('#inventarioTable').dataTable();
    $('#productosTable').dataTable();
    $('#recetasTable').dataTable();
});