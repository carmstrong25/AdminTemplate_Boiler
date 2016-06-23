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
                        <asp:UpdatePanel runat="server" ID="up" ChildrenAsTriggers="true">
                            <ContentTemplate>  
                                <!--User Information Form-->

                                <!--  -->
                                <div class="form-group">
                                    <asp:Label runat="server" ID="lbl_FirstName" Text="First Name:"></asp:Label>
                                    <div class="col-sm-10">
                                        <asp:TextBox runat="server" ID="txt_FirstName" ></asp:TextBox>
                                        <asp:Label runat="server" ID="val_txt_FirstName" Text=""></asp:Label>
                                    </div>
                                </div>
                                <!--  -->
                        

                                <br />
                                <asp:Label runat="server" ID="lbl_LastName" Text="Last Name:"></asp:Label>
                                <asp:TextBox runat="server" ID="txt_LastName" ></asp:TextBox>
                                <asp:Label runat="server" ID="val_txt_LastName" Text=""></asp:Label>
                                <br />
                                <asp:Label runat="server" ID="lbl_Username" Text="Username"></asp:Label>
                                <asp:TextBox runat="server" ID="txt_Username" ></asp:TextBox>
                                <asp:Label runat="server" ID="val_txt_Username" Text=""></asp:Label>
                                <br />
                                <asp:Label runat="server" ID="lbl_Email" Text="Email:"></asp:Label>
                                <asp:TextBox runat="server" ID="txt_Email" ></asp:TextBox>
                                <asp:Label runat="server" ID="val_txt_Email" Text=""></asp:Label>
                                <br />
                                <asp:Label runat="server" ID="lbl_PhoneNumber" Text="Phone Number:"></asp:Label>
                                <asp:TextBox runat="server" ID="txt_phone" ></asp:TextBox>
                                <asp:Label runat="server" ID="val_txt_phone" Text=""></asp:Label>
                                <br />
                                 <asp:Label runat="server" ID="lbl_Password" Text="Password:"></asp:Label>
                                <asp:TextBox runat="server" ID="txt_Password" ></asp:TextBox>
                                <asp:Label runat="server" ID="val_txt_Password" Text=""></asp:Label>
                                <br />
                                <asp:Label runat="server" ID="lbl_ConfirmPassword" Text="Confirm Password:"></asp:Label>
                                <asp:TextBox runat="server" ID="txt_ConfirmPassword" ></asp:TextBox>
                                <asp:Label runat="server" ID="val_txt_ConfirmPassword" Text=""></asp:Label>
                                <br />
                                <asp:Label runat="server" ID="lbl_result" Text=""></asp:Label>
                                <asp:Button runat="server" ID="btn_Submit" Text="Save" OnClick="btn_Submit_Click"></asp:Button>
                                <!--/User Information Form-->
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="btn_Submit" EventName="Click" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>    
        </div>  
         <!-- AELRTS-->  
        <asp:UpdatePanel ID="up_alerts" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div class="row">
                    <div class="hidden">
                        <asp:label ID="hide_alertmsg" runat="server" Text="#" ></asp:label>
                        <asp:label ID="hide_alerttype" runat="server" Text="error"></asp:label> 
                    </div>                      
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn_submit" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <!-- AELRTS-->  
    </div>
    <script>
        function noti() {
            var msg = $('#<%=hide_alertmsg.ClientID%>').text();
            var type = $('#<%=hide_alerttype.ClientID%>').text();
            var position = 'top'
            noty({
                theme: 'app-noty',
                text: msg,
                type: type,
                timeout: 3000,
                layout: 'top',
                closeWith: ['button', 'click'],
                animation: {
                    open: 'in',
                    close: 'out'
                },
            });
        }

        $(document).ready(function () {
            //Input Mask for phone number.
            $("#<%=txt_phone.ClientID%>").mask("(999) 999-9999");
        });


         <%--   $(document).ready(function () {
                $('#<%=txt_username.ClientID%>').focusout(function () {
                var uname = $('#<%=txt_username.ClientID%>').val()

                var result = checkAvail(uname)

                function checkAvail(uname) {
                    PageMethods.CheckUsernameAvail(uname, OnSucceeded);
                }

                function OnSucceeded(result) {
                    if (result == 1) {
                        $('#<%=username_availability_result.ClientID%>').html("Username available :)").removeClass("text-danger").addClass("text-success");
                    }
                    else if (result == 2) {
                        $('#<%=username_availability_result.ClientID%>').html("Username already in use :(").removeClass("text-success").addClass("text-danger");
                    }
            }
            })
        });--%>
    </script>
</asp:Content>

