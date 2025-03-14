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

        Dim tugas As Double = Double.Parse(Txttugas.Text)
        Dim uts As Double = Double.Parse(txtuts.Text)
        Dim uas As Double = Double.Parse(txtuas.Text)

        Dim total As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        Dim grade As String
        Select Case total
            Case Is >= 78
                grade = "A"
            Case Is >= 65
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 40
                grade = "D"
            Case Else
                grade = "E"
        End Select

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
                        "Jurusan : " & jurusan & vbCrLf &
                        "Nilai Akhir: " & total.ToString("F2") & vbCrLf &
                        "GRADE: " & grade,
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub rbp_CheckedChanged(sender As Object, e As EventArgs) Handles rbp.CheckedChanged

    End Sub
    Private Sub rbl_CheckedChanged(sender As Object, e As EventArgs) Handles rbl.CheckedChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class