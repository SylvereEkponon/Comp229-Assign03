<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnrollStudent.aspx.cs" Inherits="Comp229_Assign03.EnrollStudent" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-md-offset-3 col-md-6">
            <h1>Student enrollment form</h1>

            <div class="form-group">
                <label class="control-label" for="CourseIDTextBox">Course ID</label>
                <asp:textbox runat="server" cssclass="form-control" id="CourseIDTextBox" placeholder="Course ID"
                    required="true"></asp:textbox>
            </div>

            <div class="form-group">
                <label class="control-label" for="StudentIDTextBox">Student ID</label>
                <asp:textbox runat="server" cssclass="form-control" id="StudentIDTextBox"
                    placeholder="StudentID" required="true"></asp:textbox>
            </div>

            <div class="form-group">
                <label class="control-label" for="GradeTextBox">Grade</label>
                <asp:textbox runat="server" cssclass="form-control" id="GradeTextBox"
                    placeholder="Grade" required="true"></asp:textbox>
                <asp:rangevalidator runat="server" errormessage="Grade should be greater than 49 and lower than 100" controltovalidate="GradeTextBox" type="Integer"
                    minimumvalue="48" maximumvalue="100"></asp:rangevalidator>

            </div>

            <div class="text-right">
                <asp:button text="Cancel" id="CancelButton" cssclass="btn btn-warning btn-lg" runat="server"
                    usesubmitbehavior="false" causesvalidation="false" onclick="CancelButton_Click" />
                <asp:button text="Save" id="SaveButton" cssclass="btn btn-primary btn-lg" runat="server"
                    onclick="SaveButton_Click" />

            </div>

        </div>
    </div>
</asp:Content>
