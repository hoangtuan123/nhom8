<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="WebForm.TrangChu" %>
<%@ Register assembly="CollectionPager" namespace="SiteUtils" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <a class="sp">Sản phẩm mới</a>

    <div class="dssp">
    <asp:DataList ID="dlSanPhamMoi" runat="server" GridLines="Both" OnItemCommand="dlSanPhamMoi_ItemCommand" RepeatColumns="5" RepeatDirection="Horizontal">
        <ItemTemplate>
            <table cellpadding="2" style="width: 100%">
                <tr>
                    <td style="text-align: center">
                        <asp:Image ID="Image5" runat="server" Height="110px" ImageUrl='<%# Eval("Hinh","~/Hinh/Laptop/{0}") %>' Width="138px" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label1" runat="server" style="font-weight: 700; color: #FF0000; font-size: large" Text='<%# Eval("TenSP") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text='<%# Eval("DonGia","{0:#,###,###}") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton2" runat="server" CommandArgument='<%# Eval("SP_ID")+";"+Eval("NhaSX_ID") %>' CommandName="XemChiTiet" Height="20px" ImageUrl="~/Hinh/Icon/chitiet.jpg" Width="80px" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
        </div>


    <a class="sp" >Tất cả sản phẩm</a>

    <div class="dssp">
    <asp:DataList ID="dlSanPhamFull" runat="server" GridLines="Both" OnItemCommand="dlSanPhamFull_ItemCommand" RepeatColumns="5" RepeatDirection="Horizontal">
        <ItemTemplate>
            <table cellpadding="2" style="width: 100%">
                <tr>
                    <td style="text-align: center">
                        <asp:Image ID="Image5" runat="server" Height="110px" ImageUrl='<%# Eval("Hinh","~/Hinh/Laptop/{0}") %>' Width="138px" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: large; color: #FF0000" Text='<%# Eval("TenSP") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text='<%# Eval("DonGia","{0:#,###,###}") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton2" runat="server" CommandArgument='<%# Eval("SP_ID")+";"+Eval("NhaSX_ID") %>' CommandName="XemChiTiet" Height="20px" ImageUrl="~/Hinh/Icon/chitiet.jpg" Width="80px" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
        <cc1:CollectionPager ID="CollectionPager1" runat="server" BackText="« Trước" FirstText="Đầu" LabelText="Trang:" LastText="Cuối" NextText="Sau »" ResultsFormat="Sản phẩm hiển thị {0}-{1} (Tổng {2})" ShowFirstLast="True">
</cc1:CollectionPager>
        </div>


<br />
</asp:Content>
