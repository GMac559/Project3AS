<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Game.aspx.vb" Inherits="Project3AS.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: white;
        }
    </style>
    <link rel="stylesheet" href="StyleSheet2.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <br />
                <asp:Label ID="titleLabel" runat="server" CssClass="titleLabel" Text="Card Game for Two!"></asp:Label>
                <br />
                <br />
            </div>
            <div class="auto-style1">
                <asp:Label ID="deck1RankLabel" runat="server" BackColor="#CC0000" CssClass="deck1RankLabel" Font-Size="32px" Height="100px" style="border-left: 1px solid black; border-right: 1px solid black; border-top: 1px solid black;" Text="Label" Width="165px"></asp:Label>
                <asp:Label ID="deck2RankLabel" runat="server" BackColor="#0033CC" CssClass="deck2RankLabel" Font-Size="32px" Height="100px" Text="Label" Width="165px"></asp:Label>
                <br />
                <asp:Label ID="deck1SuitLabel" runat="server" BackColor="#CC0000" BorderStyle="None" CssClass="deck1SuitLabel" Font-Size="32px" Height="109px" style="border-bottom: 1px solid black; border-left: 1px solid black; border-right: 1px solid black; text-anchor:end;" Text="Label" Width="165px"></asp:Label>
                <asp:Label ID="deck2SuitLabel" runat="server" BackColor="#0033CC" CssClass="deck2SuitLabel" Font-Size="32px" Height="109px" Text="Label" Width="165px"></asp:Label>
                <br />
            </div>
            <asp:Label ID="Label1" runat="server" Text="Cards Remaining:"></asp:Label>
            <asp:Label ID="remainingCardsLabel" runat="server" CssClass="remainingCardsLabel" Text=" 51"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Player 1 Score:"></asp:Label>
            <asp:Label ID="player1ScoreLabel" runat="server" CssClass="player1ScoreLabel" Text="0"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Player 2 Score:"></asp:Label>
            <asp:Label ID="player2ScoreLabel" runat="server" CssClass="player2ScoreLabel" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Button ID="drawButton" runat="server" Font-Names="Ebrima" Height="58px" Text="Draw" Width="199px" />
            <br />
            <br />
            <asp:Button ID="shuffleButton" runat="server" Font-Names="Ebrima" Height="59px" Text="Shuffle" Width="220px" />
            <br />
            <br />
            <asp:Label ID="feedbackLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
