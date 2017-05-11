
Public Class Form1
    'Declaration of Constants for skill levels
    Const _constLevel1 As Integer = 15
    Const _constLevel2 As Integer = 20
    Const _constLevel3 As Integer = 25

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboLevel.SelectedIndexChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intHours As Integer
        Dim intTotal As Integer
        'If statement to make sure a Skill level is selected
        If CboLevel.SelectedItem <> "" Then
            'If statement to make sure Hours are Numberical Value
            If IsNumeric(txtHours.Text) = True Then
                intHours = Convert.ToInt64(txtHours.Text)
                'If Statement to make sure hours are positive Numbers
                If intHours > 0 Then
                    'Returns the Value from the function
                    intTotal = Salary(intHours)
                    'Displays the results in labels
                    lblPrint.Visible = True
                    lblDisplay.Visible = True
                    lblPrint.Text = "The Total Salary is $" & intTotal.ToString()
                    lblDisplay.Text = "For " & intHours & " Hours Worked and " & CboLevel.SelectedItem
                Else
                    MsgBox("Invalid Hours")
                End If
            Else
                MsgBox("Invalid Hours")
            End If

        Else
            MsgBox("Select a Skill Level")
        End If

    End Sub
    'The Funciton Procedure is used to calculate the earned salary
    Private Function Salary(ByVal intHours As Integer) As Integer
        Dim intTotal As Double
        'If Function to determine the selected level
        If CboLevel.SelectedIndex = 0 Then
            intTotal = (intHours * (_constLevel1))
        ElseIf CboLevel.SelectedIndex = 1 Then
            intTotal = (intHours * (_constLevel2))
        ElseIf CboLevel.SelectedIndex = 2 Then
            intTotal = (intHours * (_constLevel3))
        End If
        Return intTotal
    End Function


End Class
