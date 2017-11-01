<%@ Page Title="Update" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Updates.aspx.cs" Inherits="Comp229_Assign03.Updates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-group">
                <label class="control-label" for="LastNameTextBox">Last Name</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="LastNameTextBox"
                     required="true"></asp:TextBox>
            </div>

            <div class="form-group">
                <label class="control-label" for="FirstNameTextBox">First Name</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="FirstNameTextBox"
                     required="true"></asp:TextBox>
            </div>

            <div class="form-group">
                <label class="control-label" for="EnrollmentDateTextBox">Enrollment Date</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="EnrollmentDateTextBox"
                      required="true"></asp:TextBox>
            </div>

            <div class="text-right">
                <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                    UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click"/>
                <asp:Button Text="Update" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" 
                   OnClick="SaveButton_Click" />
            </div>

    </div>

</asp:Content>
