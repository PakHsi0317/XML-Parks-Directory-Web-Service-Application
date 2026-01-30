<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Verification
            <br />
            XML URL: (<span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">http://www.public.asu.edu/~bjiao1/park.xml</span>)
            <asp:TextBox ID="xmlTextBox" runat="server"></asp:TextBox>
            <br />
            XMLS URL: (<span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">http://www.public.asu.edu/~bjiao1/park.xsd</span>)
            <asp:TextBox ID="xmlsTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="verificationButton" runat="server" Text="Submit" OnClick="verificationButton_Click" />
            <br />
            Validation:
            <asp:TextBox ID="resultTextBox" CssClass="noborder" Width="100%" Height="20%" TextMode="MultiLine" runat="server"></asp:TextBox>
            <br />
            <br />
            XPath Search<br />
            XML URL(<span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">http://www.public.asu.edu/~bjiao1/park.xml</span>):
            <asp:TextBox ID="xml2TextBox" runat="server"></asp:TextBox>
            <br />
            XPath Expression(/Parks/Park[1]/Name):
            <asp:TextBox ID="expressionTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="xpathButton" runat="server" Text="Submit" OnClick="xpathButton_Click" />
            <br />
            Path Value:
           <asp:TextBox ID="result2TextBox" CssClass="noborder" Width="100%" Height="20%" TextMode="MultiLine" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" style="margin-bottom: 38px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    </form>
</body>
</html>
