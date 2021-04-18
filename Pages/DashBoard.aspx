<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="Razrab.Pages.DashBoard" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
         .row{
                display:flex;
                margin-left: -.75em;
                margin-right: -.75em;
            }

            .column{
                flex:1;
                margin-left: 0.75em;
                margin-right: 0.75em;
            }

            .column-center{
                flex:1;
                margin-left: 0.75em;
                margin-right: 0.75em;
                text-align:center;
            }

            .cent{
        text-align: center;
    }
    </style>
    <main id="main">
        <div class="row">
            <section class="column">
               <div class="cent">
                <h2 class="subtitle"><asp:Label runat="server">Распределение вакансий IT-специалистов по регионам</asp:Label></h2>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" >
        <Series>
            <asp:Series Name="Series1" ChartType="Pie" XValueMember="Description" YValueMembers="total" Label="#VALY\n#VALX"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="Server=localhost;Port=5432;Database=razrab;User ID=postgres;Password=1;" ProviderName="Npgsql" SelectCommand='SELECT r."Description", Count(r."Id") AS total FROM dbo."Regions" r INNER JOIN dbo."Vacancies" v ON r."Id" = v."Region_Id" GROUP BY r."Description"'></asp:SqlDataSource>

    <asp:Chart ID="Chart4" runat="server" DataSourceID="SqlDataSource1" >
        <Series>
            <asp:Series Name="Series1" XValueMember="Description" YValueMembers="total" Label="#VALY\n#VALX"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString="Server=localhost;Port=5432;Database=razrab;User ID=postgres;Password=1;" ProviderName="Npgsql" SelectCommand='SELECT r."Description", Count(r."Id") AS total FROM dbo."Regions" r INNER JOIN dbo."Vacancies" v ON r."Id" = v."Region_Id" GROUP BY r."Description"'></asp:SqlDataSource>
    </div>
    </section>
            <section class="column">
           <div class="cent">
                <h2 class="subtitle"><asp:Label runat="server" >Распределение вакансий IT-специалистов по технологиям</asp:Label></h2>
                  <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource2">
              <Series>
                  <asp:Series Name="Series2" XValueMember="Title" YValueMembers="total" ChartType="Pie"  Label="#VALY\n#VALX"></asp:Series>
              </Series>
              <ChartAreas>
                  <asp:ChartArea Name="ChartArea2"></asp:ChartArea>
              </ChartAreas>
          </asp:Chart>
          <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString="Server=localhost;Port=5432;Database=razrab;User ID=postgres;Password=1;" ProviderName="Npgsql" SelectCommand='SELECT te."Title", Sum(v."Quantity") AS total FROM dbo."Vacancies" v INNER JOIN (dbo."Technologies" te INNER JOIN dbo."TechnologyVacancies" tv 		 ON te."Id" = tv."Technology_Id") ON v."Id" = tv."Vacancy_Id" GROUP BY te."Title"'></asp:SqlDataSource>
            <asp:Chart ID="Chart5" runat="server" DataSourceID="SqlDataSource2">
              <Series>
                  <asp:Series Name="Series2" XValueMember="Title" YValueMembers="total" ChartType="Spline"  Label="#VALY\n#VALX"></asp:Series>
              </Series>
              <ChartAreas>
                  <asp:ChartArea Name="ChartArea2"></asp:ChartArea>
              </ChartAreas>
          </asp:Chart>
          <asp:SqlDataSource runat="server" ID="SqlDataSource5" ConnectionString="Server=localhost;Port=5432;Database=razrab;User ID=postgres;Password=1;" ProviderName="Npgsql" SelectCommand='SELECT te."Title", Sum(v."Quantity") AS total FROM dbo."Vacancies" v INNER JOIN (dbo."Technologies" te INNER JOIN dbo."TechnologyVacancies" tv 		 ON te."Id" = tv."Technology_Id") ON v."Id" = tv."Vacancy_Id" GROUP BY te."Title"'></asp:SqlDataSource>
              </div>
    </section>
    </div>
     <%--   <asp:GridView ID="GridViewUniver" runat="server">
           <Columns>
            <asp:BoundField DataField="Id" FooterText="Id" />
            <asp:BoundField DataField="RegionTitle" HeaderText="Регион" />
            <asp:BoundField DataField="Title" HeaderText="Наименование организации" />
            <asp:BoundField DataField="Address" HeaderText="Адрес организации" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="Номер телефона организации" />
            <asp:BoundField DataField="ContactName" HeaderText="Контактное лицо организации" />
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
        </asp:GridView>--%>

            <div>
      <section class="column">
                   <div class="cent">
                <h2 class="subtitle">
                    <asp:Label runat="server" >Заказ IT-специалистов в университеты</asp:Label></h2>
     
                  <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource2">
              <Series>
                  <asp:Series Name="Series2" XValueMember="Title" YValueMembers="total"  Label="#VALY\n#VALX"></asp:Series>
              </Series>
              <ChartAreas>
                  <asp:ChartArea Name="ChartArea2"></asp:ChartArea>
              </ChartAreas>
          </asp:Chart>
          <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString="Server=localhost;Port=5432;Database=razrab;User ID=postgres;Password=1;" ProviderName="Npgsql" SelectCommand='SELECT  u."Title", Count(te."Title") AS total  FROM dbo."Technologies" te INNER JOIN ((dbo."Orientations" o INNER JOIN dbo."OrientationTechnologies" ot ON o."Id" = ot."Orientation_Id") INNER JOIN (dbo."DirectionTrainings" dt INNER JOIN dbo."Univercities" u ON dt."Id" = u."DirectionTraining_Id") ON o."Id" = dt."Orientation_Id") ON te."Id" = ot."Technology_Id"  WHERE u."Title" GROUP BY u."Title", te."Title" '></asp:SqlDataSource>
              </div>
    </section>
    </div>
    </main>

</asp:Content>
