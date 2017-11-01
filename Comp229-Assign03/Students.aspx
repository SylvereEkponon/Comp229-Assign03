<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Comp229_Assign03.Students" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        
        <h2>STUDENT</h2>
        <hr />
        <asp:GridView ID="StudentGridView" runat="server" AutoGenerateColumns="false"
            CssClass="table  table-bordered table-striped table-hover" >
            <Columns>
                <asp:BoundField DataField="StudentID" HeaderText="Student ID" Visible="true" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />
                <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" Visible="true"
                    DataFormatString="{0:MMM dd, yyyy}" />
                     <asp:HyperLinkField Text="Edit" ControlStyle-CssClass="btn btn-primary btn-sm"
                            runat="server" DataNavigateUrlFields="StudentID" DataNavigateUrlFormatString="Updates.aspx?StudentID={0}" />
                


            </Columns>
        </asp:GridView>

                <asp:GridView ID="CourseTitleAndGradeGridView" runat="server" AutoGenerateColumns="false"
            CssClass="table  table-bordered table-striped table-hover">
            <Columns>
                <asp:HyperLinkField DatatextField="Title" HeaderText="Course Title" Visible="true" 
                    DataNavigateUrlFields="CourseID" DataNavigateUrlFormatString="Courses.aspx?CourseID={0}"/>
                
                <asp:BoundField DataField="Credit" HeaderText="Credits" Visible="true" />
                <asp:BoundField DataField="Grade" HeaderText="Grade" Visible="true" />


            </Columns>
        </asp:GridView>

        <a href="Default.aspx">Back to Home</a>
    </div>
</asp:Content>
