<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Master_Pages/Main.master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="CineplexSystem.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1><%: Title %></h1>
    <div class="opaqueBlock">
        <br />
        <br />
        <p>
            Please send all enquiries to<br />
            Thomas:
            <asp:HyperLink ID="hlContactUs" runat="server" NavigateUrl="mailto://30028452@cpistudent.vic.edu.au">admin@cineplex.com.au</asp:HyperLink>.
        </p>
        <br />
        <br />
    </div>
</asp:Content>

