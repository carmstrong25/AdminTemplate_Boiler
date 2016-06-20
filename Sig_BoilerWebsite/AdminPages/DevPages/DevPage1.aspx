﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DevPage1.aspx.cs" Inherits="AdminPages_DevPages_DevPage1" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <div class="main-content">

        <!-- Breadcrum -->
        <div class="page-title">
            <div class="title">Colby - Dev Page</div>
            <div class="sub-title"><p class="text-red">DEVELOPMENT</p></div>
        </div>
        <!-- /Breadcrum -->

        <div class="row">

            <div class="col-sm-6">
                <div class="card bg-white">
                    <div class="card-header">
                        <p>Validator Testing Block</p>
                    </div>
                    <div class="card-block">
                        <div class="row">
                            <div class="col-lg-12">
                                <asp:UpdatePanel runat="server" ID="up" ChildrenAsTriggers="true">
                                    <ContentTemplate>   

                                        <!-- int -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Int: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_int" placeholder="Must be INT." />
                                                <asp:label runat="server" id="val_txt_int" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- int -->

                                        <!-- BOOL -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Bool: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_bool" placeholder="Must be True / False." />
                                                <asp:label runat="server" id="val_txt_bool" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- BOOL -->

                                        <!-- Decimal -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Decimal: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_decimal" placeholder="Must be DECIMAL." />
                                                <asp:label runat="server" id="val_txt_decimal" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Decimal -->

                                        <!-- DateTime -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">DateTime: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" class="form-control" data-provide="datepicker" id="txt_datetime" placeholder="Must be DATETIME."/>
                                                <asp:label runat="server" id="val_txt_datetime" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- DateTime -->

                                        <!-- Range -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Range: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_range"  placeholder="Must be between 5 - 10."/>
                                                <asp:label runat="server" id="val_txt_range" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Range -->

                                        <!-- Lenght -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Lenght: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_lenght"  placeholder="Must be between less than 5 characters."/>
                                                <asp:label runat="server" id="val_txt_lenght" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Lenght -->

                                        <!-- Password -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Password: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_password"  placeholder="Must match the password confirmation."/>
                                                <asp:label runat="server" id="val_txt_password" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Password -->

                                        <!-- PasswordConfirmation -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Password Confirmation: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_password_confrimation"  placeholder="Must match the password."/>
                                                <asp:label runat="server" id="val_txt_password_confrimation" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- PasswordConfirmation -->

                                        <!-- Letters -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Only Letters: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_letters"  placeholder="Must be only letters.."/>
                                                <asp:label runat="server" id="val_txt_letters" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Letters -->

                                        <asp:Button runat="server" CssClass="btn btn-dark pull-right show-mess" ID="btn_submit" OnClick="btn_submit_Click" Text="GO GO GO!"/>
                                       
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btn_submit" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </div>
                        </div>    
                    </div>   
                </div>
            </div>

            <div class="col-sm-6">
                <div class="card bg-white">
                    <div class="card-header">
                        <p>Values</p>
                    </div>
                    <div class="card-block">
                        <div class="row">
                            <div class="col-lg-12">
                                <asp:UpdatePanel runat="server" ID="up2" ChildrenAsTriggers="true">
                                    <ContentTemplate>   
                                        <br />
                                        <!-- int -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Int: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_int" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- int -->
                                        <br />
                                        <!-- BOOL -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Bool: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_bool" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- BOOL -->
                                        <br />
                                        <!-- Decimal -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Decimal: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_decimal" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Decimal -->
                                        <br />
                                        <!-- DateTime -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">DateTime: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_datetime" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- DateTime -->
                                        <br />
                                        <!-- Range -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Range: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_range" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Range -->
                                        <br />
                                        <!-- Lenght -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Lenght: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_lenght" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Lenght -->
                                        <br />
                                        <!-- Password -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Password: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_password" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Password -->
                                        <br />
                                        <!-- Letters -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Only Letters: </label>
                                            <div class="col-sm-10">
                                                <asp:label runat="server" id="lbl_letters" class="text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Letters -->    
                                        <br />
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="btn_submit" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </div>
                        </div>    
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
    </script>
</asp:Content>

