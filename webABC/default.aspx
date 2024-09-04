<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="webABC._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>chương trình tính tổng hoá đơn</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <h1>CHƯƠNG TRÌNH TÍNH TỔNG HOÁ ĐƠN</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="nhan_nhap_so">Số tiền mặt hàng 1: 
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="nhan_nhap_so">Số nợ của năm ngoái chưa trả: 
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="nhan_nhap_so">Thuế VAT(%): 
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" value="10" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Tính ngay và luôn" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div id="ketqua" runat="server"></div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
