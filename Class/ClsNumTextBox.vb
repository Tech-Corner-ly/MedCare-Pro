Public Class ClsNumTextBox
    Inherits TextBox
    Public Sub New()
        Me.Text = 0
        Me.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ClsNumTextBox
        '
        Me.ResumeLayout(False)

    End Sub

    Private Sub ClsNumTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Me.Text.Contains(".") Then GoTo LineOk
        If e.KeyChar = ChrW(Keys.Delete) Then Exit Sub
LineOk:
        If e.KeyChar = ChrW(Keys.Back) Then Exit Sub
        If (Char.IsNumber(e.KeyChar) = False) Then e.Handled = True
    End Sub

    Private Sub ClsNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        Dim xStrin As String = CStr(Me.Text)
        If xStrin = String.Empty Then
            Me.Text = 0
            Exit Sub
        End If
        If xStrin.Contains(".") Then
            Dim xDec As Integer = Len(Split(xStrin, ".")(1))
            If xDec = 0 Then
                Me.Text = xStrin
            ElseIf xDec > 6 Then
                Me.Text = FormatNumber(xStrin, 6)
            Else
                Me.Text = FormatNumber(xStrin, xDec)
            End If
            Me.SelectionStart = Me.Text.Length
            Me.SelectionLength = 0
        End If
    End Sub
End Class
