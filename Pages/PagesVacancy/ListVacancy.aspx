<%@ Page Title="Вакансии кампаний" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListVacancy.aspx.cs" Inherits="Razrab.Pages.PagesVacancy.ListVacancy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h1><%: Title %></h1>
    <asp:Button ID="ButtonAdd" runat="server" Text="Добавить вакансию" PostBackUrl="~/Pages/PagesVacancy/AddVacancy.aspx" />
    <asp:GridView ID="GridViewVacancy" runat="server" BackColor="White"  BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
        <Columns>
           <asp:BoundField DataField="Id" FooterText="Id" />
       <%--      <asp:CommandField ShowDeleteButton="True" />
            <asp:CommandField ShowEditButton="True" />--%>
            <asp:BoundField DataField="RegionTitle" HeaderText="Регион" />
            <asp:BoundField DataField="Title" HeaderText="Наименование организации" />
            <asp:BoundField DataField="Address" HeaderText="Адрес организации" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="Номер телефона организации" />
            <asp:BoundField DataField="ContactName" HeaderText="Контактное лицо организации" />
            <asp:BoundField DataField="FillDate" HeaderText="Дата обращения организации" />
            <asp:BoundField DataField="Quantity" HeaderText="Колическтво вакансий" />
            <asp:BoundField DataField="Sallary" HeaderText="Заработная плата" />
            <asp:BoundField DataField="Techs" HeaderText="Технологии" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
</asp:Content>
