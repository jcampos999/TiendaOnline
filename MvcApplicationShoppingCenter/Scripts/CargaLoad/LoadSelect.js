
$(document).ready(function () {
    getAll();
});

function getAll()
 {
  
    $('#SelectArticle').empty();

    var url = "http://localhost:3762/ServiceSCA.svc/GetArticleList";
    $.ajax({
        type: "GET",
        url: url,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            console.log(data);
            $('#SelectArticle').append('<option value="' + '0' + '">' + 'Selecciona..'+ '</option>');

            $.each(data, function (i, Objeto) {
                $('#SelectArticle').append('<option value="' + Objeto.Id + '">' + Objeto.Name + '</option>');
            });



        },
        error: function (a, b, c) { console.log(a); }
    });
};


$('#SelectArticle').change(function () {
    var valorSelect = $(this).find(':selected').val();
    if (valorSelect != '0') {

        var url = "http://localhost:3762/ServiceSCA.svc/GetArticle/" + valorSelect;
        $.ajax({
            type: "GET",
            url: url,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                
                console.log(data);

                document.getElementById("TxtPrecio").value = data.Price;
                
                document.getElementById("ImgCompra").src = "/Images/" + data.Imagen ; 

            },
            error: function (a, b, c) { console.log(a); }
        });


       
    } else {
        document.getElementById("TxtPrecio").value = "";
    }
});


function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
    return true;

}


function calcularMonto() {
    
    document.getElementById("TxtSubTotal").value = document.getElementById("TxtPrecio").value * document.getElementById("TxtCantidad").value
    
}



   

    document.getElementById("BtnAgregar").onclick = function () {

        var articulo = $('#SelectArticle').find(':selected').text();
        var codArticulo = $('#SelectArticle').find(':selected').val();
        var cantidad = document.getElementById("TxtCantidad").value;
        var precio = document.getElementById("TxtPrecio").value;

        var subtotal = cantidad * precio;

        if (cantidad == '0' || precio == '0' || cantidad.trim() == '' || precio.trim() == '')
        { alert('La cantindad ni el precio pueden ser igual a 0'); }

        else {
            var tabla = document.getElementById("TblDetalle").getElementsByTagName("tr").length;
            addRow([tabla, articulo, codArticulo, cantidad, precio, subtotal]);
            limpiar();
        }
    }


function addRow(dataArr) {
    var tr = document.createElement('tr');
    var len = dataArr.length;
    for (var i = 0; i < len; i++) {
        var td = document.createElement('td');
        td.appendChild(document.createTextNode(dataArr[i]));
        tr.appendChild(td);
    }
    document.getElementById('TblBodyDetail').appendChild(tr);
    return true;
}




function limpiar() {

    document.getElementById("TxtCantidad").value = "";
    document.getElementById("TxtPrecio").value = "";
    document.getElementById("ImgCompra").src = "";
    document.getElementById("TxtSubTotal").value = "";
    $("#SelectArticle").val('0');
}

