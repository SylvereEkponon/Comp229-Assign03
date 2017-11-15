<%@ Page Title="Courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="Comp229_Assign03.Courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-offset-4 col-md-4">

            <h2>Student List</h2>
            <a href="EnrollStudent.aspx" class="btn btn-success btn-sm">
                <i class="fa fa-plus"></i> Enroll New Student
            </a>
            <asp:UpdatePanel ID="studentUpdatePanel" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="StudentsPerCourseGridView" runat="server" AutoGenerateColumns="false"
                        CssClass="table  table-bordered table-striped table-hover"
                        OnRowDeleting="StudentsPerCourseGridView_RowDeleting"
                        DataKeyNames="EnrollmentID">
                        <Columns>
                            <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />
                            <asp:CommandField DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                                ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />


                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
            <a class="btn btn-primary btn-sm" href="Default.aspx">Back to Home</a>
        </div>

    </div>
</asp:Content>
