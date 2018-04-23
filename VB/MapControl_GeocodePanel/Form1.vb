Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace MapControl_GeocodePanel
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property GeocodeLayer() As InformationLayer
            Get
                Return CType(mapControl1.Layers("GeocodeLayer"), InformationLayer)
            End Get
        End Property
        Private ReadOnly Property GeocodeProvider() As BingGeocodeDataProvider
            Get
                Return CType(GeocodeLayer.DataProvider, BingGeocodeDataProvider)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub bSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bSearch.Click
            If String.IsNullOrEmpty(teLatitude.Text) Then
                MessageBox.Show("Latitude field should be filled.")
                Return
            End If
            Dim latitude As Double = Double.Parse(teLatitude.Text)
            If (latitude > 90) OrElse (latitude < -90) Then
                MessageBox.Show("Latitude must be less than or equal to 90 and greater than or equal to - 90. Correct the input value.")
                Return
            End If

            If String.IsNullOrEmpty(teLongitude.Text) Then
                MessageBox.Show("Longitude field should be filled.")
                Return
            End If
            Dim longitude As Double = Double.Parse(teLongitude.Text)
            If (longitude > 180) OrElse (longitude < -180) Then
                MessageBox.Show("Longitude must be less than or equal to 180 and greater than or equal to - 180. Correct the input value.")
                Return
            End If

            GeocodeProvider.RequestLocationInformation(New GeoPoint(latitude, longitude), Nothing)
        End Sub
    End Class
End Namespace
