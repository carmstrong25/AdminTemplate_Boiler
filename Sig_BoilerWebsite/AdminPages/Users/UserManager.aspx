<%@ Page Title="User Manager" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="UserManager.aspx.cs" Inherits="AdminPages_Users_UserManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <div class="main-content">

        <!-- Breadcrum -->
        <div class="page-title">
            <div class="title">User Manager</div>


            <div class="sub-title">Admin / Users</div>
        </div>
        <!-- /Breadcrum -->

        <!-- This is how to make panels in this theme -->
        <div class="card bg-white">
            <div class="card-header">
                <p>User Managment</p>
            </div>
            <div class="card-block">
                <div class="row m-a-0">
                    <div class="col-lg-12">
                        <!--User Information Form-->
                        <asp:Label runat="server" ID="lbl_FirstName" Text="First Name:"></asp:Label>
                        <asp:TextBox runat="server" ID="txt_FirstName" ></asp:TextBox>
                        <br />
                        <asp:Label runat="server" ID="lbl_LastName" Text="Last Name:"></asp:Label>
                        <asp:TextBox runat="server" ID="txt_LastName" ></asp:TextBox>
                        <br />
                        <asp:Label runat="server" ID="lbl_Username" Text="Username"></asp:Label>
                        <asp:TextBox runat="server" ID="txt_Username" ></asp:TextBox>
                        <br />
                        <asp:Label runat="server" ID="lbl_Email" Text="Email:"></asp:Label>
                        <asp:TextBox runat="server" ID="txt_Email" ></asp:TextBox>
                        <br />
                        <asp:Label runat="server" ID="lbl_PhoneNumber" Text="Phone Number:"></asp:Label>
                        <asp:TextBox runat="server" ID="txt_PhoneNumber" ></asp:TextBox>
                        <br />
                         <asp:Label runat="server" ID="lbl_Password" Text="Password:"></asp:Label>
                        <asp:TextBox runat="server" ID="txt_Password" ></asp:TextBox>
                        <br />
                        <asp:Label runat="server" ID="lbl_ConfirmPassword" Text="Confirm Password:"></asp:Label>
                        <asp:TextBox runat="server" ID="txt_ConfirmPassword" ></asp:TextBox>
                        <br />
                       
                        <asp:Label runat="server" ID="lbl_result" Text="Test"></asp:Label>


                        <asp:Button runat="server" ID="btn_Submit" Text="Submit" OnClick="btn_Submit_Click"></asp:Button>
                        <!--/User Information Form-->
                    </div>
                </div>
            </div>    
        </div>  

    </div>
</asp:Content>

