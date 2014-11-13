<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="WebForm.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .text {
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="well well-sm"><strong style="line-height:25px;">Đăng Ký</strong></div>
     
    <div class="container" style="margin-left:auto;margin-right:auto; margin-left:auto;width:100%;padding:10px">

    <div class="row" style="margin-left:auto;margin-right:auto; margin-top:10px;width:70%">
   
            <div class="col-lg-6" style="margin-left:auto;margin-right:auto; margin-top:10px;width:100%">

               
                <div class="form-group">
                       Tên Đăng Nhập
                   
                    <div class="input-group">
                         <asp:TextBox ID="TenDangNhap" class = "form-control" runat="server"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                         
                    </div>
                </div>
                <div class="form-group">
                      Họ và Tên:
                    <div class="input-group">
                        <asp:TextBox ID="Ten" class = "form-control" runat="server"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                </div>
                <div class="form-group">
                     Mật Khẩu: 
                    <div class="input-group">
                       <asp:TextBox ID="MatKhau" class = "form-control" runat="server" TextMode="Password"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                </div>
                  <div class="form-group">
                    Nhập Lại Mật Khẩu: 
                    <div class="input-group">
                       <asp:TextBox ID="MatKhau2" class = "form-control" runat="server" TextMode="Password"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                      </div>
                  <div class="form-group">
                    Email:
                    <div class="input-group">
                        <asp:TextBox ID="Email" class = "form-control" runat="server" TextMode="Email"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                </div>
                
               <div class="form-group">   
                   Số điện thoại: 
                    <div class='input-group date' id='datetimepicker_1'>
                       <asp:TextBox ID="SoDienThoai" class = "form-control"  runat="server" TextMode="Number"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk">
                            </span></span>
                        </div>
                    </div>
             
             
                <div class="form-group">
                       Địa Chỉ: 
                   
                    <div class="input-group">
                         <asp:TextBox ID="DiaChi" class = "form-control" runat="server"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                         
                    </div>
                </div>
        
           <asp:Button class="btn btn-info pull-right" ID="btnDangky" runat="server" Text="Đăng Ký" OnClick="btnDangky_Click" />
               <asp:Label ID="lblLoi" CssClass = "text" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblLoiisEmail" CssClass = "text" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblLoiisTenDangNhap" CssClass = "text" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblLoiMatKhau" CssClass = "text" runat="server" Text=""></asp:Label>

        
        </div>
    
</div>
<!-- Registration form - END -->
       
       
    </div>   
   
</asp:Content>
