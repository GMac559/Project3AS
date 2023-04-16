Public Class Game
    Inherits System.Web.UI.Page
    Public Class Card
        Public Property Suit As String
        Public Property Rank As Integer
    End Class

    Shared deck1(51) As Card
    Shared deck2(51) As Card
    Shared index As Integer = 0
    Shared player1Score, player2Score As Integer
    Shared cardsRemaining As Integer = 52

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IsPostBack Then
            createDeck()
            Shuffle(deck1)
        End If

    End Sub

    Private Sub createDeck()
        Dim suits() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}
        Dim ranks() As Integer = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14} ' Ace is represented by the value 14
        'how to convert jack,queen,king,ace?dsd

        Dim index As Integer = 0
        For Each suit As String In suits
            For Each rank As Integer In ranks
                Dim card As New Card()
                card.Suit = suit
                card.Rank = rank
                deck1(index) = card
                deck2(index) = card
                index += 1
            Next
        Next

    End Sub

    Private Sub Shuffle(ByRef deck() As Card)
        Dim rand As New Random()
        Dim n As Integer = deck.Length
        While n > 1
            n -= 1
            Dim k As Integer = rand.Next(n + 1)
            Dim temp As Card = deck(k)
            deck(k) = deck(n)
            deck(n) = temp
        End While
    End Sub

    Private Function CompareCards(ByVal card1 As Card, ByVal card2 As Card) As Integer
        If card1.Rank > card2.Rank Then
            Return 1
        ElseIf card1.Rank < card2.Rank Then
            Return 2
        Else
            Return 0
        End If
    End Function

    Public Sub drawButton_Click(sender As Object, e As EventArgs) Handles drawButton.Click

        Dim card1 As Card = deck1(index)
        Dim card2 As Card = deck2(index)
        Dim winner As Integer = CompareCards(card1, card2)


        If index < 51 Then
            deck1SuitLabel.Text = deck1(index).Suit
            deck1RankLabel.Text = deck1(index).Rank
            deck2SuitLabel.Text = deck2(index).Suit
            deck2RankLabel.Text = deck2(index).Rank

            If winner = 1 Then
                ' Player 1 wins
                player1Score += 1
                player1ScoreLabel.Text = player1Score
                feedbackLabel.Text = deck1(index).Rank & " of " & deck1(index).Suit & " VS " &
                    deck2(index).Rank & " of " & deck2(index).Suit & " Player 1 Wins!"
            ElseIf winner = 2 Then
                ' Player 2 wins
                player2Score += 1
                player2ScoreLabel.Text = player2Score
                feedbackLabel.Text = deck1(index).Rank & " of " & deck1(index).Suit & " VS " &
                    deck2(index).Rank & " of " & deck2(index).Suit & " Player 2 Wins!"
            ElseIf winner = 0 Then
                'tie
            End If
            index += 1
        Else
            'gameOver()
        End If

        cardsRemaining -= 1
        remainingCardsLabel.Text = cardsRemaining

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles shuffleButton.Click
        Shuffle(deck2)
    End Sub
End Class