<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="initialiseSystem.aspx.vb" Inherits="yubikey.initialiseSystem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Literal ID="message" runat="server"></asp:Literal>
    This page will explain to you how to create your database/XML records if you have not done so already.<br />
    <br />
    <b>Before you start!</b><br />
    Open the folder App_Files, then the folder YubikeyAuth, and finally open the file CONFIG.vb<br />
    This file contains the path to the database (if it is used), as well as the setting which tells the software which storage system you want to use: storageSource.database or storageSource.file<br />
    There's two groups of settings, one is commented out, and the other is live... just swap between them.<br />
    Right now it's set up to use a file store, and it's already been made! All you need to do is add new YubiKeys to it by following the steps below:
    <br />
    Once you have edited the connection details, then it's time to edit the sub called "newUsers", and add new lines for each new Key you want to use.:<br />
    <br />
    &nbsp;&nbsp;&nbsp;newSystem.createRecord(Public ID in ModHex, Private ID in Hex , Private AES key in Hex )<br />
    <b>&nbsp;&nbsp;&nbsp;newSystem.createRecord("vvnilflchcnn","084f2877ab88", "742ca121d2662dd6f6b32119b1f7d6c9")</b>
    <br />
    <br />
    The session, use, and time values are all set to 0 - so that the key will always authorise on its first use.<br />
    <br />
    The AES code, and private ID that come on your YubiKey can't be read out of it for security reasons, so we can't use them. In order to enter the above datails into the system, you will need to create a NEW AES password and ID's for your YubiKey.<br />
    Visit the <a href="http://www.yubico.com/products/services-software/personalization-tools/use/">Personalisation Tools</a> page to download the "Cross-Platform Personalization Tool", and use it to generate a new set of OTP settings. (Serial number, Private ID, Public ID, and AES password)<br />
    Make a note of them somewhere private and safe!!! You will use the public ID, private ID, and AES key in the calls to "newSystem.createRecord".<br />
    <br />
    <br />
    If you want to use the YubiKey servers to authenticate the key after this, visit the <a href="http://www.yubico.com/products/services-software/personalization-tools/aes-key-upload/">AES upload</a> page, and enter the Serial number, Private ID, Public ID, and AES password of the key.<br />
    Note on the AES upload page:<br />
    YubiKey prefix = Public ID in ModHex<br />
    Internal identity = Private ID in Hex<br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Make the database / XML system." />
    <br />
</asp:Content>
