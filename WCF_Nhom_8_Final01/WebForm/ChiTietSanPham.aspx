<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="WebForm.ChiTietSanPham" %>
<%@ Register assembly="CollectionPager" namespace="SiteUtils" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
        <div class="well well-sm"><strong style="line-height:25px;margin-top:-1px;">Chi Tiết Sản phẩm</strong></div>
        <asp:DataList  ID="dlChiTietSP" runat="server" BackColor="#e3e3e3" CellPadding="4" CellSpacing="2" ForeColor="Black" GridLines="Both" Width="100%" OnItemCommand="dlChiTietSP_ItemCommand" BorderColor="#E3E3E3">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="White" />
            <ItemTemplate>
                <table cellpadding="4"  cellspacing="4" style="width:100%;border: white;">
                    <tr>
                        <td rowspan="6" style="text-align: center">
                            <asp:Image ID="Image5" runat="server" Height="160px" ImageUrl='<%# Eval("Hinh","Hinh/Laptop/{0}") %>' Width="212px" BorderColor="#990000" BorderStyle="Solid" style="text-align: center" />
                        </td>
                        <td><strong>Mã sản phẩm:</strong>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("SP_ID") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td><strong>Tên sản phẩm: </strong><asp:Label ID="Label2" runat="server" style="font-weight: 700; font-size: large; color: #FF0000" Text='<%# Eval("TenSP") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td><strong>Còn lại:</strong>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("SoLuongTon") %>' style="font-weight: 700"></asp:Label>
                            sản phẩm</td>
                    </tr>
                    <tr>
                        <td><strong>Đơn giá:</strong>
                            <asp:Label ID="Label4" runat="server" style="font-size: large; font-weight: 700; color: #0000FF;" Text='<%# Eval("DonGia","{0:#,###,###}") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="ImageButton2" runat="server" CommandArgument='<%# Eval("SP_ID")+";"+Eval("TenSP")+";"+Eval("DonGia")+";"+Eval("SoLuongTon") %>' CommandName="ThemGioHang" Height="27px" ImageUrl="~/Hinh/Icon/dathang.gif" Width="134px" />
                            <asp:Label ID="lbThongBao" runat="server" style="font-weight: 700; font-style: italic"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:ImageButton ID="ImageButton3" runat="server" CommandName="TiepTucMuaHang" Height="22px" ImageUrl="~/Hinh/Icon/tieptucmuahang.gif" Width="134px" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="font-size: large"><strong>Chi tiết sản phẩm</strong></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table align="left" cellpadding="3" cellspacing="3" style="float: left">
                                <tr>
                                    <td><b>Tên sản phẩm</b></td>
                                    <td>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("TenSP") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><b>Nhà sản xuất</b></td>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("TenNhaSX") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><b>CPU</b></td>
                                    <td>
                                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("CPU") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><b>RAM</b></td>
                                    <td>
                                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("RAM") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><b>HDD</b></td>
                                    <td>
                                        <asp:Label ID="Label9" runat="server" Text='<%# Eval("HDD") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><b>Bảo hành</b></td>
                                    <td>
                                        <asp:Label ID="Label10" runat="server" Text='<%# Eval("BaoHanh") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td><b>Mô tả sản phẩm</b></td>
                                    <td>
                                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    </p>
    <p style="font-weight: 700; font-size: large">
        Sản phẩm cùng loại</p>
    <p>
    <asp:DataList ID="dlSanPhamCungLoai" runat="server" GridLines="Both" RepeatColumns="5" RepeatDirection="Horizontal" OnItemCommand="dlSanPhamCungLoai_ItemCommand">
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
    </p>
<cc1:CollectionPager ID="CollectionPager1" runat="server" BackText="« Trước" FirstText="Đầu" LabelText="Trang:" LastText="Cuối" NextText="Sau »" ResultsFormat="Sản phẩm hiển thị {0}-{1} (Tổng {2})" ShowFirstLast="True">
</cc1:CollectionPager>
    </p>
    </asp:Content>
