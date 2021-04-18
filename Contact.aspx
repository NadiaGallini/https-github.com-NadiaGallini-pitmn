<%@ Page Title="Контакты" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Razrab.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Наши контакты.</h3>
    <address>
        Адресс Минобрнауки<br />
        Тверская ул., 11, Москва, Россия, 125009<br />
        <abbr title="Phone">P:</abbr>
        +7 495 547-13-16
    </address>

    <address>
        <strong>Администратор:</strong>   <a href="mailto:support@pitmn.ru">Support@pitmn.ru</a><br />
        <strong>Дополнительные вопросы:</strong> <a href="mailto:questions@example.com">Questions@pitmn.ru</a>
    </address>
</asp:Content>
