Imports eShop.Application.Commands
Imports eShop.Application.Enumerations
Imports eShop.Application.Handlers

Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnPagarCielo_Click(sender As Object, e As EventArgs) Handles btnPagarCielo.Click

        Dim comando As New RealizarPagamentoVendaCommand
        comando.IdVenda = 1
        comando.TipoPlayerPagamento = TipoPlayerPagamento.GooglePay

        Dim commandHandler As New PagamentoVendaCommandHandler(Nothing, Nothing)
        Dim retorno = commandHandler.Handle(comando).Result

    End Sub

End Class