<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Comp229_Assign03.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="jumbotron">
            <h1>Babylone University</h1>
        </div>

        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h2>Welcome to Babylone University</h2>
                <p>
                    Babylone University is a sample application that demonstrates how to use Entity Framework 6 in an ASP.NET web application.
                </p>
            </div>
        </div>

        <div class="row">
            <div class="col-md-offset-4 col-md-4">

                <h1>Student List</h1>
                <a href="StudentDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus"></i> Add Student
                </a>

                <asp:GridView ID="StudentsGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table  table-bordered table-striped table-hover">
                    <Columns>
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                        <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />


                        <asp:HyperLinkField Text="Select" ControlStyle-CssClass="btn btn-primary btn-sm"
                            runat="server" DataNavigateUrlFields="StudentID" DataNavigateUrlFormatString="Students.aspx?StudentID={0}" />

                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>

</asp:Content>
