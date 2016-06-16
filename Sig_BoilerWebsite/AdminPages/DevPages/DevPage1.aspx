<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DevPage1.aspx.cs" Inherits="AdminPages_DevPages_DevPage1" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <div class="main-content">

        <!-- Breadcrum -->
        <div class="page-title">
            <div class="title">Colby - Dev Page</div>
            <div class="sub-title"><p class="text-red">DEVELOPMENT</p></div>
        </div>
        <!-- /Breadcrum -->

        <div class="row">
            <div class="col-lg-6">
                <div class="card bg-white">
                    <div class="card-header">
                        <p>Validator Testing Block</p>
                    </div>
                    <div class="card-block">
                        <div class="row m-a-0">
                            <div class="col-lg-12">
                                <asp:UpdatePanel runat="server" ID="up" ChildrenAsTriggers="true">
                                    <ContentTemplate>   

                                        <!-- int -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label" >Int: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_int" />
                                                <asp:label runat="server" id="val_txt_int" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- int -->

                                        <br /><br /><br />

                                        <!-- BOOL -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Bool: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_bool" />
                                                <asp:label runat="server" id="val_txt_bool" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- BOOL -->

                                        <br /><br /><br />

                                        <!-- Decimal -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Decimal: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" CssClass="form-control" id="txt_decimal" />
                                                <asp:label runat="server" id="val_txt_decimal" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- Decimal -->

                                        <br /><br /><br />

                                        <!-- DateTime -->
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">DateTime: </label>
                                            <div class="col-sm-10">
                                                <asp:TextBox runat="server" class="form-control" data-provide="datepicker" id="txt_datetime" />
                                                <asp:label runat="server" id="val_txt_datetime" class="help-block text-danger"></asp:label>
                                            </div>
                                        </div>
                                        <!-- DateTime -->
                                        <br />
                                        <hr />
                                        <br />
                                        <asp:Button runat="server" CssClass="btn btn-dark pull-right" ID="btn_submit" OnClick="btn_submit_Click" Text="GO GO GO!"/>
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
    </div>
</asp:Content>

