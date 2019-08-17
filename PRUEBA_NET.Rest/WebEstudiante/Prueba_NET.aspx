<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba_NET.aspx.cs" Inherits="WebEstudiante.Prueba_NET" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
<%--    <form id="form1" runat="server">
    <div>
           <asp:label ID="Nombre" runat="server" Text="Label"></asp:label>
           <asp:label ID="Nota" runat="server" Text="Label"></asp:label>
           <asp:label ID="Id" runat="server" Text="Label"></asp:label>

    </div>
    </form>--%>
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <h2>PRUEBA_NET</h2>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-body">
                    <h5 class="card-title">Insertar Nota</h5>
                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                    <a href="#" id="insertar" class="btn btn-primary">Go somewhere</a>
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
                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                    <a href="#" id="notas" class="btn btn-primary">Go somewhere</a>
                    </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-body">
                    <h5 class="card-title">Consulta Promedio Notas</h5>
                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                    <a href="#" id="promedio" class="btn btn-primary">Go somewhere</a>
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

            $("#notas").click(function () {

                $.ajax({
                    type: "GET",
                    url: "http://localhost:63118/Estudiantes.svc/Notas", // Location of the service
                    //data: '{"dni": "' + 7 + '"}',
                    data: {},
                    crossDomain: true,
                    contentType: "application/json",
                    dataType: "json",
                    processdata: true,
                    success: function (msg) {

                        $("#label").val(msg.d.Name);

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
