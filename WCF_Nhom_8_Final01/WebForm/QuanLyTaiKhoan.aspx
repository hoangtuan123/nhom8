<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="QuanLyTaiKhoan.aspx.cs" Inherits="WebForm.QuanLyTaiKhoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   


     <div class="well well-sm"><strong style="line-height:25px;">Quản Lý Tài Khoản</strong></div>
    <div class="container" style="margin-left:auto;margin-right:auto; margin-left:auto;width:100%;padding:10px">

    <div class="row" style="margin-left:auto;margin-right:auto; margin-top:10px;width:70%">
   
            <div class="col-lg-6" style="margin-left:auto;margin-right:auto; margin-top:10px;width:100%">

               
                <div class="form-group">
                       Tên Đăng Nhập
                   
                    <div class="input-group">
                          <asp:Label ID="lblTenDangNhap" runat="server" Text=""></asp:Label>
                        
                         
                    </div>
                </div>
                <div class="form-group">
                      Mật Khậu:
                    <div class="input-group">
                      ******(<a href="/DoiMatKhau.aspx">Đổi Mật Khẩu</a>)
                    </div>
                </div>
                <div class="form-group">
                Thông Tin Cá Nhân
                </div>
                  <div class="form-group">
                   Họ Và Tên:
                    <div class="input-group">
                       <asp:TextBox ID="txtHoTen" class = "form-control"  runat="server"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                      </div>
                  <div class="form-group">
                    Email:
                    <div class="input-group">
                        <asp:TextBox ID="txtEmail" class = "form-control"  runat="server" TextMode="Email"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                </div>
                
               <div class="form-group">   
                   Số điện thoại: 
                    <div class='input-group date' id='datetimepicker_1'>
                        <asp:TextBox ID="txtSoDienThoai" class = "form-control"  runat="server" TextMode="Number"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk">
                            </span></span>
                        </div>
                    </div>
         
           

             
                <div class="form-group">
                       Địa Chỉ: 
                   
                    <div class="input-group">
                         <asp:TextBox ID="txtDiaChi" class = "form-control"  runat="server"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                         
                    </div>
                </div>
        
       <asp:Button ID="btnCapNhat" class="btn btn-info pull-right" runat="server" Text="Cập Nhật" OnClick="btnCapNhat_Click" />
          <asp:Label ID="lblLoi" runat="server" Text=""></asp:Label>
        </div>
    
</div>
<!-- Registration form - END -->
       
       
    </div>   
   

</asp:Content>
