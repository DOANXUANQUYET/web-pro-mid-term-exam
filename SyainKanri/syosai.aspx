<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="syosai.aspx.cs" Inherits="SyainKanri.syosai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ◆ 社員情報
            <table>
                <tr >
                    <td rowspan="7">
                        <asp:Image ID="imgPhoto" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="135px" ImageAlign="Middle" Width="164px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        社員番号 : <asp:Label ID="lblSyainNo" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSyainName" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSeibetsu" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNyusyaDate" runat="server"></asp:Label> 入社
                    </td>
                </tr>
                <tr>
                    <td>
                        基本給 : <asp:Label ID="lblKihonkyu" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTaisyoku" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnModoru" runat="server" Text="戻る" OnClick="btnModoru_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
