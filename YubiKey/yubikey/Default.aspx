<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="yubikey._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <br />
    <br />
    If you've not done so yet, you'll want to follow the instructions by clicking "Initialise the storage system!" above,<br />
    and then reading the instructions it gives.<br />
    Don't worry, the system defaults to file storage, so you really only need to add the "newSystem.createRecord" commands for each new YubiKey.<br />
    <h2>
        Please press the button on your YubiKey now.</h2>
    <br />
    <span style="background: #e0e0e0; padding: 5px; box-shadow: 5px 5px 10px #a0a0a0;">
        <img src="images/yubi.ico" style="vertical-align: middle; width: 20px;" />
        <asp:TextBox Style="" runat="server" autocomplete="off" type="text" ID="OTPField" placeholder="YubiKey" autofocus="autofocus" />
    </span>
    <br />
    <br />
    <br />
    <br />
    Information about the One Time Password:<br />
    <br />
    <asp:Literal ID="output" runat="server"></asp:Literal>
    <br />
</asp:Content>
