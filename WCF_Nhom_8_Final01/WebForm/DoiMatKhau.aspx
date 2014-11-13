<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="WebForm.DoiMatKhau" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<div class="well well-sm"><strong style="line-height:25px;">Đổi Mật Khẩu</strong></div>
    <div class="container" style="margin-left:auto;margin-right:auto; margin-left:auto;width:100%;padding:10px">

    <div class="row" style="margin-left:auto;margin-right:auto; margin-top:10px;width:70%">
   
            <div class="col-lg-6" style="margin-left:auto;margin-right:auto; margin-top:10px;width:100%">
           
                <div class="form-group">
                      Mật Khậu Cũ:
                    <div class="input-group">
                    <asp:TextBox ID="txtMK_Cu"  class = "form-control" runat="server" TextMode="Password"></asp:TextBox>
                    <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                </div>
              
                  <div class="form-group">
                  Mật Khẩu Mới :
                    <div class="input-group">
                       <asp:TextBox ID="txtMK_Moi"  class = "form-control" runat="server" TextMode="Password"></asp:TextBox>
                        <span class="input-group-addon"><span class="glyphicon glyphicon-asterisk"></span></span>
                    </div>
                      </div>
                  <div class="form-group">
                    Nhập Lại Mật Khẩu Mới:
                    <div class="input-group">
                       <asp:TextBox ID="txtMK_Moi_1"  class = "form-control" runat="server" TextMode="Password"></asp:TextBox>
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
