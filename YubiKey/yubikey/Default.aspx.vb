Imports System.Collections.Generic
Imports System.Text
Imports yubikey.YubikeyAuth
Imports yubikey.YubikeyAuth.storageFactory    

Public Class _Default
    Inherits System.Web.UI.Page

'Example YubiKey data:
'Public ID: vvnilflchcnn
'Private ID: 084f2877ab88
'Secret (AES128) (16 bytes): 742ca121d2662dd6f6b32119b1f7d6c9

'Example keys:
'vvnilflchcnnftcreujuevgcfhdvtdjibltnfucfckhd
'vvnilflchcnnfhhjcdrjticjjlgklbjckcbenbrflhth
'vvnilflchcnnrnivfevhgfnncnjueidtbfjvgbkejilu
'vvnilflchcnnlvflrnhcekdeutlldriddgnnedflhhju
'vvnilflchcnnrdbvruhkuckrejctvvnfglcubccdjuld

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim YKC as YubikeyAuth.checkYubiKey

        If IsPostBack then

            try
                YKC = New checkYubiKey(OTPField.Text)

                Dim report As String
                report="Valid key : " & YKC.validKey & "<br><br>"
                report &="Key error state: " & YKC.errorStatus.ToString & "<br><br>"

                If YKC.errorStatus=YubikeyAuth.checkYubiKey.errorStatusTypes.YubiKeyNoError then
                    report &="<u>OTP Data</u><br>"
                    report &="Use count: " & YKC.OTPContent.aYubiKey.int_useCounter &"<br>"
                    report &="Session count: " & YKC.OTPContent.aYubiKey.int_sessionCounter &"<br>"
                    report &="Time stamp: " & YKC.OTPContent.aYubiKey.int_timeStamp &"<br>"
                    report &="Random value: " & YKC.OTPContent.aYubiKey.int_random &"<br>"
                    report &="Private ID: " & YKC.OTPContent.aYubiKey.hex_privateID &"<br><br>"

                    report &="<u>Database record data.</u><br>"
                    report &="Use count: " & YKC.storage.int_useCounter &"<br>"
                    report &="Session count: " & YKC.storage.int_sessionCounter &"<br>"
                    report &="Time stamp: " & YKC.storage.int_timeStamp &"<br>"
                end if
                output.Text=report
            
            Catch ex As Exception
                output.Text="Something really went wrong!<br>" & Replace(ex.ToString(),vbCrLf,"<br>")
            end try

            OTPField.Text=""
        End If
        OTPField.focus
    End Sub

End Class