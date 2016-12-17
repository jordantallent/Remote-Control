Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtABC.Text = My.Settings.ABC
        txtAE.Text = My.Settings.AE
        txtAMC.Text = My.Settings.AMC
        txtAnimalPlanet.Text = My.Settings.AnimalPlanet
        txtCBS.Text = My.Settings.CBS
        txtComedyCentral.Text = My.Settings.ComedyCentral
        txtDiscoveryChannel.Text = My.Settings.DiscoveryChannel
        txtFox.Text = My.Settings.Fox
        txtFX.Text = My.Settings.FX
        txtMTV.Text = My.Settings.MTV
        txtMTV2.Text = My.Settings.MTV2
        txtNatGeo.Text = My.Settings.NatGeo
        txtNatGeoWild.Text = My.Settings.NatGeoWild
        txtScienceChannel.Text = My.Settings.ScienceChannel
        txtSpike.Text = My.Settings.Spike
        txtTBS.Text = My.Settings.TBS
        txtUSA.Text = My.Settings.USA
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    End Sub
End Class