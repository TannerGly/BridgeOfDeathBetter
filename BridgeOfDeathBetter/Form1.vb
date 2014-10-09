Public Class Form1

    Private Sub btnApproach_Click(sender As Object, e As EventArgs) Handles btnApproach.Click
        Dim strName As String = InputBox("What is your name?", "Name")
        Dim strQuest As String = InputBox("What is your Quest?", "Quest")
        Dim intRandomQuestionNumber As Integer
        Dim strRandomQuestionAnswer As String

        Dim strRandomQ1 As String = "What is your favourite color?"
        Dim strRandomQ2 As String = "What is the airspeed velocity of an unladen swallow?"
        Dim strRandomQ3 As String = "What is the capital of Assyria?"
        Dim strrandomQ4 As String = "What is the thickness of the Antarctic Ice Cap?"

        Dim strNameA As String = "Glynis"
        Dim strQuestA As String = "To Seek The Holy Grail"

        Dim strRandomA1 As String = "Blue"
        Dim strRandomA2 As String = "Green"
        Dim strRandomA3 As String = "25 MPH"
        Dim strRandomA4 As String = "40 KMPH"
        Dim strRandomA5 As String = "Assur"
        Dim strRandomA6 As String = "Nimrud"
        Dim strRandomA7 As String = "Nineveh"
        Dim strRandomA8 As String = "Dur Sarukin"
        Dim strRandomA9 As String = "13500 Feet"
        Dim strRandomA10 As String = "4500 Meters"

        Randomize()
        intRandomQuestionNumber = Int((4 - 1 + 1) * Rnd() + 1)
        'Typical Random Number Sequence

        If intRandomQuestionNumber = 1 Then
            strRandomQuestionAnswer = InputBox(strRandomQ1, "Random1")
        ElseIf intRandomQuestionNumber = 2 Then
            strRandomQuestionAnswer = InputBox(strRandomQ2, "Random2")
        ElseIf intRandomQuestionNumber = 3 Then
            strRandomQuestionAnswer = InputBox(strRandomQ3, "Random3")
        ElseIf intRandomQuestionNumber = 4 Then
            strRandomQuestionAnswer = InputBox(strrandomQ4, "Random4")
        End If

        If strName = strNameA And strQuest = strQuestA Then
            If intRandomQuestionNumber = 1 And (strRandomQuestionAnswer = strRandomA1 Or strRandomQuestionAnswer = strRandomA2) Then
                Me.lblFate.Text = "You may pass."
            ElseIf intRandomQuestionNumber = 2 And (strRandomQuestionAnswer = strRandomA3 Or strRandomQuestionAnswer = strRandomA4) Then
                Me.lblFate.Text = "You may pass."
            ElseIf intRandomQuestionNumber = 3 And (strRandomQuestionAnswer = strRandomA5 Or strRandomQuestionAnswer = strRandomA6 Or strRandomQuestionAnswer = strRandomA7 Or strRandomQuestionAnswer = strRandomA8) Then
                Me.lblFate.Text = "You may pass."
            ElseIf intRandomQuestionNumber = 4 And (strRandomQuestionAnswer = strRandomA9 Or strRandomQuestionAnswer = strRandomA10) Then
                Me.lblFate.Text = "You may pass."
            End If
        Else
            Me.lblFate.Text = "*Thrown into the pit of eternal peril*"
        End If



    End Sub
End Class
