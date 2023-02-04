Imports System.Xml.Schema

Public Class Form1
    Dim tot As Double
    Dim op As String

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyData
            Case 190
                BtnPonto.PerformClick()
            Case 48
                Btn0.PerformClick()
            Case 49
                Btn1.PerformClick()
            Case 50
                Btn2.PerformClick()
            Case 51
                Btn3.PerformClick()
            Case 52
                Btn4.PerformClick()
            Case 53
                Btn5.PerformClick()
            Case 54
                Btn6.PerformClick()
            Case 55
                Btn7.PerformClick()
            Case 56
                Btn8.PerformClick()
            Case 57
                Btn9.PerformClick()
            Case 187
                BtnSoma.PerformClick() 'teclado "+"
            Case 189
                BtnMenos.PerformClick() 'teclado "-"
            Case 65723
                BtnMultiplicação.PerformClick() 'teclado "SHIFT +"
            Case 68
                BtnDivisao.PerformClick() 'teclado "Fn -"
            Case 65589
                BtnMod.PerformClick() 'teclado SHIFT 5"
            Case 192
                BtnIgual.PerformClick() 'teclado "Ç"
            Case 83
                BtnRaizQuadrada.PerformClick() 'teclado "S"
            Case 73
                BtnInverso.PerformClick() 'teclado "I"
            Case 81
                BtnAoQuadrado.PerformClick() 'teclado "Q"
            Case 67
                BtnClear.PerformClick() 'teclado "C"
            Case 8
                BtnBackSpace.PerformClick() 'teclado "BackSpace"
        End Select
        'MsgBox(e.KeyData)
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        LblResultado.Text = LblResultado.Text & 9
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        LblResultado.Text = LblResultado.Text & 8
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        LblResultado.Text = LblResultado.Text & 7
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        LblResultado.Text = LblResultado.Text & 6
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        LblResultado.Text = LblResultado.Text & 5
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        LblResultado.Text = LblResultado.Text & 4
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        LblResultado.Text = LblResultado.Text & 3
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        LblResultado.Text = LblResultado.Text & 2
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        LblResultado.Text = LblResultado.Text & 1
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        LblResultado.Text = LblResultado.Text & 0
    End Sub

    Private Sub BtnPonto_Click(sender As Object, e As EventArgs) Handles BtnPonto.Click
        If LblResultado.Text.Contains(".") Then
        Else
            LblResultado.Text = LblResultado.Text & "."
        End If
    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click, Button8.Click
        Select Case op
            Case "+"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot + Val(LblResultado.Text)
                op = ""
            Case "-"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot - Val(LblResultado.Text)
                op = ""
            Case "x"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot * Val(LblResultado.Text)
                op = ""
            Case "/"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot / Val(LblResultado.Text)
                op = ""
            Case "%"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot Mod Val(LblResultado.Text)
                op = ""
        End Select
    End Sub

    Private Sub BtnMultiplicação_Click(sender As Object, e As EventArgs) Handles BtnMultiplicação.Click, Button5.Click
        Select Case op
            Case "+"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot + Val(LblResultado.Text)
                op = ""
            Case "-"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot - Val(LblResultado.Text)
                op = ""
            Case "x"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot * Val(LblResultado.Text)
                op = ""
            Case "/"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot / Val(LblResultado.Text)
                op = ""
            Case "%"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot Mod Val(LblResultado.Text)
        End Select
        LblHistorico.Text = LblResultado.Text & " * "
        tot = Val(LblResultado.Text)
        op = "x"
        LblResultado.Text = ""
    End Sub

    Private Sub BtnDivisao_Click(sender As Object, e As EventArgs) Handles BtnDivisao.Click, Button4.Click
        Select Case op
            Case "+"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot + Val(LblResultado.Text)
                op = ""
            Case "-"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot - Val(LblResultado.Text)
                op = ""
            Case "x"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot * Val(LblResultado.Text)
                op = ""
            Case "/"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot / Val(LblResultado.Text)
                op = ""
            Case "%"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot Mod Val(LblResultado.Text)
                op = ""
        End Select
        LblHistorico.Text = LblResultado.Text & " / "
        tot = Val(LblResultado.Text)
        op = "/"
        LblResultado.Text = ""
    End Sub

    Private Sub BtnMenos_Click(sender As Object, e As EventArgs) Handles BtnMenos.Click, Button6.Click
        Select Case op
            Case "+"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot + Val(LblResultado.Text)
                op = ""
            Case "-"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot - Val(LblResultado.Text)
                op = ""
            Case "x"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot * Val(LblResultado.Text)
                op = ""
            Case "/"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot / Val(LblResultado.Text)
                op = ""
            Case "%"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot Mod Val(LblResultado.Text)
                op = ""
        End Select
        LblHistorico.Text = LblResultado.Text & " - "
        tot = Val(LblResultado.Text)
        op = "-"
        LblResultado.Text = ""
    End Sub

    Private Sub BtnSoma_Click(sender As Object, e As EventArgs) Handles BtnSoma.Click, Button7.Click
        Select Case op
            Case "+"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot + Val(LblResultado.Text)
                op = ""
            Case "-"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot - Val(LblResultado.Text)
                op = ""
            Case "x"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot * Val(LblResultado.Text)
                op = ""
            Case "/"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot / Val(LblResultado.Text)
                op = ""
            Case "%"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot Mod Val(LblResultado.Text)
                op = ""
        End Select
        LblHistorico.Text = LblResultado.Text & " + "
        tot = Val(LblResultado.Text)
        op = "+"
        LblResultado.Text = ""
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click, Button3.Click
        Select Case op
            Case "+"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot + Val(LblResultado.Text)
                LblResultado.Text = ""
            Case "-"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot - Val(LblResultado.Text)
            Case "x"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot * Val(LblResultado.Text)
            Case "/"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot / Val(LblResultado.Text)
            Case "%"
                LblHistorico.Text += LblResultado.Text & " ="
                LblResultado.Text = tot Mod Val(LblResultado.Text)
        End Select
        LblHistorico.Text = LblResultado.Text & " % "
        tot = Val(LblResultado.Text)
        op = "%"
        LblResultado.Text = ""
    End Sub

    Private Sub BtnMaisMenos_Click(sender As Object, e As EventArgs) Handles BtnMaisMenos.Click, Button2.Click
        'quando o valor for intoduzido e clicamos no botao esse valor fica com "-"
        LblResultado.Text = LblResultado.Text * -1
    End Sub

    Private Sub BtnBackSpace_Click(sender As Object, e As EventArgs) Handles BtnBackSpace.Click, Button9.Click
        'se se o comprimento do resultado for maior que 0, faz que o resultado
        'remova o ultimo algarismo fazendo -1
        If LblResultado.Text.Length > 0 Then
            LblResultado.Text = LblResultado.Text.Remove(LblResultado.Text.Length - 1, 1)
        End If
        If LblResultado.Text = "" Then
            LblResultado.Text = ""
        End If
    End Sub

    Private Sub BtnRaizQuadrada_Click(sender As Object, e As EventArgs) Handles BtnRaizQuadrada.Click, Button11.Click
        'o valor que introduzir faz a raiz quadrada
        Dim raiz As String
        raiz = Math.Sqrt(Val(LblResultado.Text))
        LblResultado.Text = raiz
    End Sub

    Private Sub BtnAoQuadrado_Click(sender As Object, e As EventArgs) Handles BtnAoQuadrado.Click, Button10.Click
        'igualo o tot ao valor que introduzir e depois multiplico esse valor 2x
        tot = Val(LblResultado.Text)
        LblResultado.Text = tot * tot
    End Sub

    Private Sub BtnInverso_Click(sender As Object, e As EventArgs) Handles BtnInverso.Click, Button12.Click
        'se for diferente de nada o tot fica a 0 e a label tambem
        'caso nao o valor sera dividido por 1
        tot = LblResultado.Text
        If LblResultado.Text <> "" Then
            If tot = 0 Then
                LblResultado.Text = 0
            Else
                LblResultado.Text = 1 / tot
            End If
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click, Button1.Click
        LblResultado.Text = ""
        LblHistorico.Text = ""
        tot = 0
    End Sub

End Class