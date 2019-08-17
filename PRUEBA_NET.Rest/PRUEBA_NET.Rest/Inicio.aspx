<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PRUEBA_NET.Rest.Inicio" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <h2>PRUEBA_NET</h2>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-body">
                    <h5 class="card-title">Insertar Nota</h5>
                    <div class="form-group">
                        <label for="inputName">Id</label>
                        <input type="text" class="form-control" id="inputId" placeholder="Ingrese Id de estudiante"/>
                    </div>
                    <div class="form-group">
                        <label for="inputName">Nota</label>
                        <input type="text" class="form-control" id="inputNota" placeholder="Ingrese Nota"/>
                    </div>
                    <a href="#" id="insertar" class="btn btn-primary">Click aqui</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-body">
                    <h5 class="card-title">Estudiantes</h5>
                        <table class="table table-responsive table-hover table-bordered" id="stds">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Nombre</th>    
                                    <th>Nota</th>              
                                </tr>                   
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-body">
                    <h5 class="card-title">Consulta Estudiantes Nota Maxima y Minima</h5>
                    <table class="table table-responsive table-hover table-bordered" id="list_table_json">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Nombre</th>    
                                <th>Nota</th>              
                            </tr>                   
                        </thead>
                    </table>
                    <a href="#" id="notas" class="btn btn-primary">Click aqui</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-body">
                    <h5 class="card-title">Consulta Promedio Notas</h5>
                    <div class="card-text" id=""><p id="notaPromedio">Promedio Notas:  </p></div>
                    <a href="#" id="promedio" class="btn btn-primary">Click aqui</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script>
        $(document).ready(function () {

            $.ajax({
                type: "GET",
                url: " /Estudiantes.svc/ObtenerEstudiantes", // Location of the service
                //data: '{"dni": "' + 7 + '"}',
                data: {},
                crossDomain: true,
                contentType: "application/json",
                dataType: "json",
                processdata: true,
                success: function (data) {
                    //$('#notamaxmin').append(msg[0].Nombre)
                    var event_data = '';
                    $.each(data, function (index, value) {
                        /*console.log(value);*/
                        event_data += '<tr>';
                        event_data += '<td>' + value.Id + '</td>';
                        event_data += '<td>' + value.Nombre + '</td>';
                        event_data += '<td>' + value.Nota + '</td>';
                        event_data += '<tr>';
                    });
                    $("#stds").append(event_data);
                    //console.log(msg)

                },
                error: function () {

                    alert("error");

                }
            });

            $("#insertar").click(function () {
                var id = document.getElementById("inputId").value
                //var nombre = $(this).attr('auction');
                var nota = document.getElementById("inputNota").value
                console.log(nota)
                console.log(id)
                $.ajax({
                    type: "POST",
                    url: " /Estudiantes.svc/InsertarNota", // Location of the service
                    //data: '{"dni": "' + 7 + '"}',
                    data: JSON.stringify({Id:id, Nota:nota}),
                    crossDomain: true,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    processdata: true,
                    success: function (data) {
                    alert('Nota Actualizada')

                    },
                    error: function () {

                        alert("error");

                    }
                });
                $('#stds').empty();
                $.ajax({
                    type: "GET",
                    url: " /Estudiantes.svc/ObtenerEstudiantes", // Location of the service
                    //data: '{"dni": "' + 7 + '"}',
                    data: {},
                    crossDomain: true,
                    contentType: "application/json",
                    dataType: "json",
                    processdata: true,
                    success: function (data) {
                        //$('#notamaxmin').append(msg[0].Nombre)
                        var event_data = '';
                        $.each(data, function (index, value) {
                            /*console.log(value);*/
                            event_data += '<tr>';
                            event_data += '<td>' + value.Id + '</td>';
                            event_data += '<td>' + value.Nombre + '</td>';
                            event_data += '<td>' + value.Nota + '</td>';
                            event_data += '<tr>';
                        });
                        $("#stds").append(event_data);
                        //console.log(msg)

                    },
                    error: function () {

                        alert("error");

                    }
                });

            });
            $("#notas").click(function () {

                $.ajax({
                    type: "GET",
                    url: " /Estudiantes.svc/Notas", // Location of the service
                    //data: '{"dni": "' + 7 + '"}',
                    data: {},
                    crossDomain: true,
                    contentType: "application/json",
                    dataType: "json",
                    processdata: true,
                    success: function (data) {
                        //$('#notamaxmin').append(msg[0].Nombre)
                        var event_data = '';
                        $.each(data, function (index, value) {
                            /*console.log(value);*/
                            event_data += '<tr>';
                            event_data += '<td>' + value.Id + '</td>';
                            event_data += '<td>' + value.Nombre + '</td>';
                            event_data += '<td>' + value.Nota + '</td>';
                            event_data += '<tr>';
                        });
                        $("#list_table_json").append(event_data);
                       //console.log(msg)

                    },
                    error: function () {

                        alert("error");

                    }
                });

            });
            $("#promedio").click(function () {

                $.ajax({
                    type: "GET",
                    url: " /Estudiantes.svc/Promedios", // Location of the service
                    //data: '{"dni": "' + 7 + '"}',
                    data: {},
                    crossDomain: true,
                    contentType: "application/json",
                    dataType: "json",
                    processdata: true,
                    success: function (msg) {
                        $('#notaPromedio').append(msg);
                        console.log(msg)

                    },
                    error: function () {

                        alert("error");

                    }
                });

            });
            console.log("ready!");
        });
 
    </script>
</body>
</html>
