Public Class Form1

    Private Sub btnprocess_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        Dim nip As Long
        If Not Long.TryParse(txtnip.Text.Trim(), nip) Then
            MessageBox.Show("NIP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim nama As String = txtnama.Text.Trim()
        Dim fakultas As String = cbfakultas.Text.Trim()
        Dim jurusan As String = cbjurusan.Text.Trim()

        Dim jenisKelamin As String = ""
        If rbL.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rbP.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show("Hai : " & nama & vbCrLf &
                        "NIP : " & nip & vbCrLf &
                        "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                        "Fakultas : " & fakultas & vbCrLf &
                        "Jurusan : " & jurusan,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub rbp_CheckedChanged(sender As Object, e As EventArgs) Handles rbp.CheckedChanged

    End Sub
    Private Sub rbl_CheckedChanged(sender As Object, e As EventArgs) Handles rbl.CheckedChanged

    End Sub
End Class