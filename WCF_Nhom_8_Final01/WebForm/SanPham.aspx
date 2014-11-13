<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="WebForm.SanPham" %>
<%@ Register assembly="CollectionPager" namespace="SiteUtils" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dlSanPham" runat="server" GridLines="Both" OnItemCommand="dlSanPham_ItemCommand" RepeatColumns="5" RepeatDirection="Horizontal">
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
</asp:Content>
