<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ControleAcademia.aspx.cs" Inherits="ControleAcademia.ControleAcademia" %>
<%@   Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  TagPrefix="ajax"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="scriptMng" runat="server"></asp:ScriptManager>
    <link rel="stylesheet" href="Content/gridview.css" />
    <link rel="stylesheet" href="Content/button.css" />

     <script type="text/javascript">  
        function dt(sender,args)  
        {  
                
  
            sender._selectedDate = new Date();  
            var hours = sender._selectedDate.getHours()  
            var minutes = sender._selectedDate.getMinutes()  
    
            // set the date back to the current date  
            sender._textbox.set_Value(sender._selectedDate.format(sender._format)+" "+hours+":"+minutes)  
        }  
     </script>  

    <style type="text/css">
        body
        {
            margin: 20pt !important;
        }
    </style>

    <table>
        <tr>
            <td>
                <label>Apto</label>
            </td>
            <td></td><td></td><td></td>
            <td>
                <label>Data</label>
            </td>
            <td></td><td></td><td></td>
            <td>
                Hor&aacute;rio Inicial
            </td>
            <td></td><td></td><td></td>
            <td>
                Hor&aacute;rio Final
            </td>
            <td></td><td></td><td></td>
            <td style="text-align:center">
                Op&ccedil;&atilde;o
            </td>
        </tr>

        <tr>
            <td>
            <input id="txtApto" runat="server" type="text" oninput="this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*)\./g, '$1');" 
                maxlength="4" style="width:40px" />
            </td>
            <td></td><td><td></td>
            <td>
                <asp:TextBox ID="txtData" runat="server" Width="90px" 
                    AutoPostBack="true"
                    onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" 
                    OnTextChanged="txtData_TextChanged"></asp:TextBox>
                <ajax:MaskedEditExtender 
                    ID="mskData"
                    runat="server"
                    TargetControlID="txtData"
                    Mask="99/99/9999"
                    MaskType="Date"
                    MessageValidatorTip="true"
                    >
                </ajax:MaskedEditExtender>
            </td>            
            <td></td><td></td><td></td>                   
            <td>
                <input type="time" id="txtHorarioInicio" runat="server" style="width:100px" />
            </td>
            <td></td><td></td><td></td>
            <td>
                <input type="time" id="txtHorarioFinal" runat="server" style="width:100px" />
            </td>
            <td></td><td></td><td></td>
            <td>
                <asp:RadioButtonList ID="rbdTipoAlteracao" runat="server" RepeatDirection="Horizontal" >
                    <asp:ListItem Value="1" Selected="True" Text="Novo"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Alterar"></asp:ListItem>
                    <asp:ListItem Value="3">Desmarcar</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td></td><td></td><td></td>
            <td>
                <asp:Button ID="btnProcessar" Text="Processar" runat="server" Class="btn btn-primary" />
            </td>
        </tr>   
    </table>
    <br />
    <table id="tbGrid">
        <asp:GridView ID="grdAgendamentos" runat="server" AutoGenerateColumns="false" 
            CssClass="mydatagrid" PagerStyle-CssClass="pager"
            HeaderStyle-CssClass="header" RowStyle-CssClass="rows"
            >
            <Columns>                
                <asp:boundfield DataField="DataAgendamento" headertext="Dt. Agendamento" dataformatstring="{0:dd/MM/yyyy}" ItemStyle-HorizontalAlign="Center" ItemStyle-Wrap="false"  />
                <asp:BoundField DataField="Apto" HeaderText="Apto" />
                <asp:BoundField DataField="HorarioInicial" HeaderText="Horário Inicial" ItemStyle-HorizontalAlign="Center" />
                <asp:BoundField DataField="HorarioFinal" HeaderText="Horário Final" ItemStyle-HorizontalAlign="Center" />
                <asp:BoundField DataField="Status" HeaderText="Status" ItemStyle-HorizontalAlign="Center" />
            </Columns>
        </asp:GridView>
    </table>
    <div id="pager">
    </div>
</asp:Content>
