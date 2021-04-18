<%@ Page Title="Главная" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Razrab._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="height:530px;">
        <div class="jumbotron-text">
                 <h1>Портал IT-специалистов Минобрнауки Российской Федерации</h1>
                 <p class="lead">Сделаем Цифровую Россию лучше!</p>
            </div>
        <p><a href="~/" class="btn btn-primary btn-lg">Читать далее &raquo;</a></p>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2 style="color:steelblue; text-shadow: 2px 2px 2px rgb(13, 8, 1);">Методика прогноза востребованных IT-специалистов РФ</h2>
            <p>
                Изучите список технологий, представленных на Портале ITС РФ.
            </p>
            <p>
                <a class="btn btn-default" href="Pages/Metod.aspx" runat="server">Читать далее &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2 style="color:steelblue; text-shadow: 2px 2px 2px rgb(13, 8, 1);">Панель дашборд</h2>
            <p>
                Изучите показатели аналитики дашборд в виде отчетов, таблиц, графиков и диаграмм.
            </p>
            <p>
                <a class="btn btn-default" href="Pages/DashBoard.aspx">Читать далее &raquo;</a>
            </p>
        </div>
                <div class="col-md-4">
            <h2 style="color:steelblue; text-shadow: 2px 2px 2px rgb(13, 8, 1);">Добавление вакансии</h2>
            <p>
                Заполните форму и получите список лучших IT-специалистов РФ для Вашей кампании.
            </p>
            <p>
                <a class="btn btn-default" href="Pages/PagesVacancy/ListVacancy.aspx"  runat="server">Читать далее &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
