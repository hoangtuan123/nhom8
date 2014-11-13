<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="TimKiemNangCao.aspx.cs" Inherits="WebForm.TimKiemNangCao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center">
            <tr>
                <td colspan="2" style="font-weight: 700; text-align: center">TÌM KIẾM NÂNG CAO</td>
            </tr>
            <tr>
                <td colspan="2">Quý khách vui lòng nhập thông tin sản phẩm để tìm kiếm có kết quả chính xác</td>
            </tr>
            <tr>
                <td>Chọn nhà sản xuất</td>
                <td>
                    <asp:DropDownList ID="ddlNhaSX" runat="server" AppendDataBoundItems="True" AutoPostBack="True" Height="20px" Width="167px">
                        <asp:ListItem Value="-1">Chọn nhà sản xuất</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Chọn mức giá</td>
                <td>
                    <asp:DropDownList ID="ddlMucGia" runat="server" AppendDataBoundItems="True" AutoPostBack="True" Height="19px" Width="168px">
                        <asp:ListItem Value="-1">Chọn mức giá</asp:ListItem>
                        <asp:ListItem Value="10000000-12000000">10.000.000 - 12.000.000</asp:ListItem>
                        <asp:ListItem Value="12000000-14000000">12.000.000 - 14.000.000</asp:ListItem>
                        <asp:ListItem Value="14000000-16000000">14.000.000 - 16.000.000</asp:ListItem>
                        <asp:ListItem Value="16000000-18000000">16.000.000 - 18.000.000</asp:ListItem>
                        <asp:ListItem Value="18000000-25000000">18.000.000 - 25.000.000</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnTimKiem" runat="server"  style="text-align: center" Text="Tìm kiếm" OnClick="btnTimKiem_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Label ID="lbThongBaoLoi" runat="server" Text="" />
                </td>
            </tr>
        </table>
</asp:Content>
