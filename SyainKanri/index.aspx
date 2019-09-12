<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SyainKanri.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>index</title>
    <link rel="stylesheet" href="index.css" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ◆　資格一覧<br />

        </div>
        <div class="content">
        <asp:DataList ID="dltShikaku" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
            <ItemTemplate>
                <asp:LinkButton ID="lbtShikakuName" runat="server" OnClick="lbtShikakuName_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" CommandArgument='<%# Eval("ShikakuName") %>' Text='<%# Eval("ShikakuName") %>' CssClass="linkbutton"></asp:LinkButton>
            </ItemTemplate>
        </asp:DataList>
        </div>
        <br />
        <div>
            ◆　<asp:Label ID="lblShikakuName" runat="server"></asp:Label> 取得社員の一覧<br />
            <asp:DataList ID="dltSyain" runat="server" RepeatColumns="5">
                <ItemTemplate>
                    <div class="contentSmall">
                       <asp:LinkButton ID="lbtSyainName" runat="server" OnClick="lbtSyainName_Click" CommandArgument='<%# Eval("SyainName") %>' Text='<%# Eval("SyainName") %>'></asp:LinkButton>
                        <br />
                       <asp:LinkButton ID="lbtSyutokuYM" runat="server" OnClick="lbtSyutokuYM_Click" CommandArgument='<%# Eval("SyainName") %>' Text='<%# Eval("SyutokuYM") %>'></asp:LinkButton>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
