<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculadoraWeb.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Calculadora Web</title>

<style>
  html, body {
    height:100%;
    margin:0;
    background-color:lightcyan;
    font-family:Arial;
}

  #form1 {
    display:flex;
    justify-content:center;
    align-items:center;
    height:100%;
}

  .contenedor {
    text-align:center;
}

table {
    margin:auto;
}

td {
    padding:2px;
}

input[type="submit"] {
    width:50px;
    height:35px;
    font-size:16px;
}

.resultado {
    width:220px;
    height:30px;
    font-size:18px;
    text-align:right;
}

.fibonacci {
    width:210px !important;
}
</style>
    </head>

<body>

   <form id="form1" runat="server">

    <div class="contenedor">

<h1>Calculadora Web</h1>

   <asp:TextBox ID="lresultado" runat="server" CssClass="resultado" ReadOnly="true"></asp:TextBox>

<br /><br />

<table>

<tr>
   <td><asp:Button ID="b7" runat="server" Text="7" OnClick="b7_Click"/></td>
   <td><asp:Button ID="b8" runat="server" Text="8" OnClick="b8_Click"/></td>
   <td><asp:Button ID="b9" runat="server" Text="9" OnClick="b9_Click"/></td>
   <td><asp:Button ID="bsuma" runat="server" Text="+" OnClick="bsuma_Click"/></td>
</tr>

<tr>
   <td><asp:Button ID="b4" runat="server" Text="4" OnClick="b4_Click"/></td>
   <td><asp:Button ID="b5" runat="server" Text="5" OnClick="b5_Click"/></td>
   <td><asp:Button ID="b6" runat="server" Text="6" OnClick="b6_Click"/></td>
   <td><asp:Button ID="bresta" runat="server" Text="-" OnClick="bresta_Click"/></td>
</tr>

<tr>
   <td><asp:Button ID="b1" runat="server" Text="1" OnClick="b1_Click"/></td>
   <td><asp:Button ID="b2" runat="server" Text="2" OnClick="b2_Click"/></td>
   <td><asp:Button ID="b3" runat="server" Text="3" OnClick="b3_Click"/></td>
   <td><asp:Button ID="bmulti" runat="server" Text="*" OnClick="bmulti_Click"/></td>
  </tr>

<tr>
   <td><asp:Button ID="b0" runat="server" Text="0" OnClick="b0_Click"/></td>
   <td><asp:Button ID="bigual" runat="server" Text="=" OnClick="bigual_Click"/></td>
   <td><asp:Button ID="blimpiar" runat="server" Text="C" OnClick="blimpiar_Click"/></td>
   <td><asp:Button ID="bdivision" runat="server" Text="/" OnClick="bdivision_Click"/></td>
  </tr>

<tr>
   <td><asp:Button ID="bcuadrado" runat="server" Text="x²" OnClick="bcuadrado_Click"/></td>
   <td><asp:Button ID="bcubo" runat="server" Text="x³" OnClick="bcubo_Click"/></td>
   <td><asp:Button ID="braiz" runat="server" Text="√" OnClick="braiz_Click"/></td>
   <td><asp:Button ID="bfactorial" runat="server" Text="!" OnClick="bfactorial_Click"/></td>
</tr>

<tr>
   <td colspan="4">
    <asp:Button ID="bfibonacci" runat="server" Text="Fibonacci" CssClass="fibonacci" OnClick="bfibonacci_Click"/>
   </td>
</tr>

</table>

</div>

</form>

</body>
</html>