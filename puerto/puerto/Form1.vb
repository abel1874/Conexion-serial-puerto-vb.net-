Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscapuerto()
    End Sub

    Private Sub buscapuerto()
        Try
            cmbPort.Items.Clear()
            For Each puerto As String In My.Computer.Ports.SerialPortNames
                cmbPort.Items.Add(puerto)
            Next
            If cmbPort.Items.Count > 0 Then
                cmbPort.SelectedIndex = 0
            Else
                MsgBox("NO HAY PUERTOS DISPONIBLES EN TU SISTEMA")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnconectar_Click(sender As Object, e As EventArgs) Handles btnconectar.Click
        Try
            With sppuerto
                .BaudRate = 19200
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = 1
                .PortName = cmbPort.Text
                .Open()

                If .IsOpen Then
                    lblestado.Text = "CONECTADO"
                Else
                    MsgBox("CONEXION FALLIDA!", MsgBoxStyle.Critical)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btndesconectar_Click(sender As Object, e As EventArgs) Handles btndesconectar.Click
        sppuerto.Close()
        lblestado.Text = "DESCONECTADO"
    End Sub

    Private Sub sppuerto_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles sppuerto.DataReceived
        Dim buffer As String
        buffer = sppuerto.ReadExisting
        txtrecibe.Text = "Recibido>> " & buffer & vbCrLf
    End Sub

    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        If sppuerto.IsOpen Then
            sppuerto.WriteLine(txtenvia.Text)
        Else
            MsgBox("NO ESTAS CONECTADO", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
