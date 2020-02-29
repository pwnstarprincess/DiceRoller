''Jennifer Pezzulo
''D and D dice roller
''FEb 28, 2020

Public Class Form1


    ''Shared ReadOnly Generator As System.Random = New System.Random()
    Private Function RandomNumber(lowerBound As Integer, upperBound As Integer) As Integer

        Static Generator As Random = New Random()
        Return Generator.Next(lowerBound, upperBound + 1)
    End Function

    Private Sub DisplayOutput()

    End Sub

    Private Sub FourSide_Click(sender As Object, e As EventArgs) Handles fourSide.Click

        fourResults.Clear()
        Dim diceRoll As Integer
        diceRoll = RandomNumber(1, 4)
        fourResults.Text = diceRoll
        Picture4.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & diceRoll), Image)

    End Sub

    Private Sub SixSide_Click(sender As Object, e As EventArgs) Handles sixSide.Click


        sixResults.Clear()
        Dim diceRoll As Integer
        diceRoll = RandomNumber(1, 6)
        sixResults.Text = diceRoll
        Picture6.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & diceRoll), Image)

    End Sub

    Private Sub EightSided_Click(sender As Object, e As EventArgs) Handles eightSided.Click


        eightResults.Clear()
        Dim diceRoll As Integer
        diceRoll = RandomNumber(1, 8)
        eightResults.Text = diceRoll
        Picture8.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & diceRoll), Image)

    End Sub

    Private Sub TenSided_Click(sender As Object, e As EventArgs) Handles tenSided.Click


        tenResults.Clear()
        Dim diceRoll As Integer
        diceRoll = RandomNumber(1, 10)
        tenResults.Text = diceRoll
        Picture10.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & diceRoll), Image)

    End Sub

    Private Sub TwelveSided_Click(sender As Object, e As EventArgs) Handles twelveSided.Click


        twelveResults.Clear()
        Dim diceRoll As Integer
        diceRoll = RandomNumber(1, 12)
        twelveResults.Text = diceRoll
        Picture12.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & diceRoll), Image)

    End Sub

    Private Sub TwentySided_Click(sender As Object, e As EventArgs) Handles twentySided.Click


        twentyResults.Clear()
        Dim diceRoll As Integer
        diceRoll = RandomNumber(1, 20)
        twentyResults.Text = diceRoll
        Picture20.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & diceRoll), Image)

    End Sub

    Private Sub RollEverything_Click(sender As Object, e As EventArgs) Handles RollEverything.Click
        fourResults.Text = RandomNumber(1, 4)
        Picture4.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & fourResults.Text), Image)
        sixResults.Text = RandomNumber(1, 6)
        Picture6.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & sixResults.Text), Image)
        eightResults.Text = RandomNumber(1, 8)
        Picture8.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & eightResults.Text), Image)
        tenResults.Text = RandomNumber(1, 10)
        Picture10.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & tenResults.Text), Image)
        twelveResults.Text = RandomNumber(1, 12)
        Picture12.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & twelveResults.Text), Image)
        twentyResults.Text = RandomNumber(1, 20)
        Picture20.Image = DirectCast(My.Resources.ResourceManager.GetObject("Number" & twentyResults.Text), Image)
        hundredResults.Text = RandomNumber(0, 9) * 10

    End Sub

    Private Sub ClearEverything_Click(sender As Object, e As EventArgs) Handles ClearEverything.Click
        fourResults.Clear()
        Picture4.Image = Nothing
        sixResults.Clear()
        Picture6.Image = Nothing
        eightResults.Clear()
        Picture8.Image = Nothing
        tenResults.Clear()
        Picture10.Image = Nothing
        twelveResults.Clear()
        Picture12.Image = Nothing
        twentyResults.Clear()
        Picture20.Image = Nothing
        hundredResults.Clear()
    End Sub

    Private Sub HundredSided_Click(sender As Object, e As EventArgs) Handles HundredSided.Click
        hundredResults.Clear()
        Dim diceRoll As Integer
        diceRoll = RandomNumber(0, 9)
        hundredResults.Text = diceRoll * 10
    End Sub
End Class
