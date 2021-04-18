<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="AddVacancy.aspx.cs" Inherits="Razrab.Pages.PagesVacancy.AddVacancy" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <h1><%: Title %></h1>
 <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    <table>
        <tr>
            <td>Регион</td>
            <td><asp:DropDownList ID="DropDownListRegion" runat="server" /></td>
        </tr>
        <tr>
            <td>Наименование организации:</td>
            <td><asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox></td>
        </tr>   
        <tr>
            <td>Адрес организации</td>
            <td><asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Номер телефона</td>
            <td><asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Контактные данные</td>
            <td><asp:TextBox ID="TextBoxContactName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Кол-во вакансий</td>
            <td><asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Зарплата</td>
            <td><asp:TextBox ID="TextBoxSallary" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Технологии</td>
            <td><asp:CheckBoxList ID="techCheckBoxList" runat="server" DataTextField="Title" DataValueField="Id"
              RepeatColumns="3" 
              RepeatDirection="Vertical" 
              RepeatLayout="Table" 
              TextAlign="Right" 
              CssClass="techCheckBoxList">
             </asp:CheckBoxList></td>
        </tr>
        </table>
        <table>
            <tr>
            <td><asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/ListVacancy.aspx">Cancel</asp:HyperLink> 
            &nbsp; 
            <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" /></td>
        </tr>
    </table>
    <br />
</asp:Content>
