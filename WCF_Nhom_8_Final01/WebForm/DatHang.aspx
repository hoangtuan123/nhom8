<%@ Page Title="" Language="C#" MasterPageFile="~/New_Master.Master" AutoEventWireup="true" CodeBehind="DatHang.aspx.cs" Inherits="WebForm.DatHang" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <br />
    <div style="text-align: center">
                <h2><strong style="text-align: center">THÔNG TIN ĐẶT HÀNG</strong></h2>
            </div>
    <br />
    <strong>Danh sách sản phẩm đã đặt mua&nbsp;&nbsp;&nbsp; </strong>
    <asp:Label ID="lbThongBaoTon" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gvGioHang" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="SP_ID" ShowFooter="True" Width="100%" OnRowCancelingEdit="gvGioHang_RowCancelingEdit" OnRowDeleting="gvGioHang_RowDeleting" OnRowEditing="gvGioHang_RowEditing" OnRowUpdating="gvGioHang_RowUpdating">
        <Columns>
            <asp:BoundField DataField="SP_ID" HeaderText="Sản phẩm ID" ReadOnly="True" />
            <asp:BoundField DataField="TenSP" HeaderText="Tên sản phẩm" ReadOnly="True" />
            <asp:BoundField DataField="DonGia" DataFormatString="{0:#,###,###}" HeaderText="Đơn giá" ReadOnly="True" />
            <asp:TemplateField HeaderText="Số lượng">
                <EditItemTemplate>
                    <asp:TextBox ID="txtSoLuong" runat="server" Text='<%# Bind("SoLuong") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtSoLuong" Display="Dynamic" ErrorMessage="Số lượng không được trống" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="txtSoLuong" ErrorMessage="Phải nhập số" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SoLuong") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ThanhTien" DataFormatString="{0:#,###,###}" HeaderText="Thành tiền" ReadOnly="True" />
            <asp:CommandField CancelText="Hủy" EditText="Sửa" ShowEditButton="True" UpdateText="Cập nhật" />
            <asp:CommandField DeleteText="Xóa" ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <br />
    <span style="font-size: large"><strong>Xác nhận thông tin đơn hàng</strong></span><br />
    <br />
    <table align="left" cellpadding="3" cellspacing="3" style="float: left">
        <tr>
            <td>Mã đơn đặt hàng</td>
            <td>
                <asp:Label ID="lbMaDonDH" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Ngày đặt hàng</td>
            <td>
                <asp:TextBox ID="txtNgayDat" runat="server" Enabled="False" ReadOnly="True" Width="200px"></asp:TextBox>
&nbsp;
                <br />
                (tháng/ngày/năm)</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Ngày giao hàng</td>
            <td>
                <asp:TextBox ID="txtNgayGiao" runat="server" Width="200px"></asp:TextBox>
                <asp:CalendarExtender ID="txtNgayGiao_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtNgayGiao">
                </asp:CalendarExtender>
            &nbsp;
                <br />
                (tháng/ngày/năm)</td>
            <td>
                *</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNgayGiao" Display="Dynamic" ErrorMessage="Vui lòng chọn ngày giao hàng" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNgayGiao" ControlToValidate="txtNgayDat" ErrorMessage="Ngày giao hàng phải sau ngày đặt hàng" ForeColor="Red" Operator="LessThanEqual" Type="Date"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>Tình trạng đơn hàng</td>
            <td>
                <asp:Label ID="lbTinhTrang" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Ghi chú</td>
            <td>
                <asp:TextBox ID="txtGhiChu" runat="server" Height="45px" TextMode="MultiLine" Width="198px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Mã xác nhận</td>
            <td>
                <asp:TextBox ID="txtMaXacNhan" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
                <asp:TextBox ID="txtMa" runat="server" Enabled="False" ForeColor="Blue" ReadOnly="True" style="text-align: center" Width="68px"></asp:TextBox>
            </td>
            <td>
                *</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtMaXacNhan" Display="Dynamic" ErrorMessage="Vui lòng nhập mã xác nhận" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtMaXacNhan" ControlToValidate="txtMa" ErrorMessage="Mã xác nhận không đúng" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <span style="font-size: large"><strong>
    <br />
    <br />
    Xác nhận thông tin khách hàng</strong></span><br />
    <br />
    <table align="left" cellpadding="3" cellspacing="3" style="float: left">
        <tr>
            <td>Họ tên khách hàng</td>
            <td>
                <asp:TextBox ID="txtHoTen" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>*</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtHoTen" ErrorMessage="Vui lòng nhập họ tên" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Địa chỉ</td>
            <td>
                <asp:TextBox ID="txtDiaChi" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>*</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDiaChi" ErrorMessage="Vui lòng nhập địa chỉ" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Điện thoại</td>
            <td>
                <asp:TextBox ID="txtDienThoai" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>*</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDienThoai" Display="Dynamic" ErrorMessage="Vui lòng nhập số điện thoại" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDienThoai" ErrorMessage="Số điện thoại từ 8 đến 12 chữ số" ForeColor="Red" ValidationExpression="\w{8,12}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td>*</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Vui lòng nhập email" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    Quý khách vui lòng kiểm tra toàn bộ thông tin trên trang này trước khi đặt hàng.<br />
    Những thông tin có dấu (*) quý khách vui lòng nhập đầy đủ
    <br />
    <br />
    <asp:Button ID="btnDatHang" runat="server" BorderColor="#993333" Height="30px" OnClick="btnDatHang_Click" Text="Xác nhận đặt hàng" />
&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbThongBaoLoi" runat="server" ForeColor="Red"></asp:Label>
    <br />
</asp:Content>
