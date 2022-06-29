Imports System.Data.SqlClient
Public Class formBMasuk
    Private mRow As Integer = 0
    Private newpage As Boolean = True
    Sub awal()
        txtbxBarcode.Text = vbNullString
        txtbxHarga.Text = vbNullString
        txtbxJumlah.Text = vbNullString
        txtbxNama.Text = vbNullString
        lblKode.Text = vbNullString
        lblTotal.Text = vbNullString
        lblId.Text = vbNullString
        lblJumlah.Text = vbNullString
        txtbxBarcode.Enabled = False
        txtbxHarga.Enabled = False
        txtbxJumlah.Enabled = False
        txtbxNama.Enabled = False
        btnSimpan.Text = "TAMBAH"
        Call getData()
    End Sub
    Sub getKode()
        Call koneksi()
        Cmd = New SqlCommand("select top 1 right(kodeTransaksi,5)+1 as kodeTransaksi from tblBIn order by kodeTransaksi desc", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            Select Case Rd!kodeTransaksi
                Case Is <= 9
                    lblKode.Text = "BIN0000" & Rd!kodeTransaksi
                Case Is <= 99
                    lblKode.Text = "BIN000" & Rd!kodeTransaksi
                Case Is <= 999
                    lblKode.Text = "BIN00" & Rd!kodeTransaksi
                Case Is <= 9999
                    lblKode.Text = "BIN" & Rd!kodeTransaksi
            End Select
        End If
        Conn.Close()
    End Sub
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("select tblBIn.kodeTransaksi,tblBIn.tanggal, tblSupplier.namaSupplier, tblBarang.namaBarang, tblBIn.hargaBeli, tblBIn.jumlah, tblBIn.total from tblBIn join tblBarang on tblBarang.barcode=tblBIn.barcode join tblSupplier on tblSupplier.id=tblBIn.idSupplier", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblBIn")
        dgvBMasuk.DataSource = (Ds.Tables("tblBIn"))
        Conn.Close()
    End Sub
    Private Sub formBMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "TAMBAH" Then
            Call getKode()
            txtbxBarcode.Enabled = True
            txtbxHarga.Enabled = True
            txtbxJumlah.Enabled = True
            txtbxNama.Enabled = True
            MsgBox("Perhatikan dengan teliti pada saat memasukkan informasi, karena data tidak dapat dirubah lagi !!!", MsgBoxStyle.Information)
            btnSimpan.Text = "CEK"
        ElseIf btnSimpan.Text = "CEK" Then
            If txtbxNama.Text = vbNullString Or txtbxJumlah.Text = vbNullString Or txtbxHarga.Text = vbNullString Or txtbxBarcode.Text = vbNullString Or lblKode.Text = vbNullString Then
                MsgBox("Semua kolom wajib di isi dengan baik dan benar")
            Else
                lblTotal.Text = Val(txtbxHarga.Text) * Val(txtbxJumlah.Text)
                Call koneksi()
                Cmd = New SqlCommand("Select id from tblSupplier where namaSupplier like '%" & txtbxNama.Text & "%'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.Read Then
                    lblId.Text = Rd.Item(0).ToString
                    Conn.Close()
                    Call koneksi()
                    Cmd = New SqlCommand("select stockBarang from tblBarang where barcode='" & txtbxBarcode.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    If Rd.Read Then
                        lblJumlah.Text = Rd.Item(0).ToString
                        Conn.Close()
                        MsgBox("Supplier dan Barang ditemukan ! Silahkan klik SIMPAN")
                        btnSimpan.Text = "SIMPAN"
                    Else
                        MsgBox("Kode Barcode tidak cocok dengan data yang tersimpan !")
                        txtbxBarcode.Text = vbNullString
                        txtbxBarcode.Focus()
                    End If
                Else
                    MsgBox("Nama supplier tidak cocok dengan data yang tersimpan !")
                    txtbxNama.Text = vbNullString
                    txtbxNama.Focus()
                End If
            End If
        ElseIf btnSimpan.Text = "SIMPAN" Then
            Call koneksi()
            Cmd = New SqlCommand("Insert into tblBIn values('" & lblKode.Text & "','" & lblId.Text & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "','" & txtbxBarcode.Text & "','" & txtbxHarga.Text & "','" & txtbxJumlah.Text & "','" & lblTotal.Text & "')", Conn)
            Cmd.ExecuteNonQuery()
            lblJumlah.Text = Val(lblJumlah.Text) + Val(txtbxJumlah.Text)
            Conn.Close()
            Call koneksi()
            Cmd = New SqlCommand("update tblBarang set stockBarang='" & lblJumlah.Text & "' where barcode='" & txtbxBarcode.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
            Conn.Close()
            MsgBox("Sukses menambahkan data barang masuk")
            Call awal()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = dgvBMasuk.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case dgvBMasuk.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(dgvBMasuk.Columns(cell.ColumnIndex).HeaderText, dgvBMasuk.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False


        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To dgvBMasuk.RowCount - 1
            ' no need to try to print the new row
            If dgvBMasuk.Rows(thisNDX).IsNewRow Then Exit For

            row = dgvBMasuk.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgvBMasuk.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                            DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(), dgvBMasuk.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        mRow = 0
        newpage = True
        PrintPreviewDialog1.PrintPreviewControl.StartPage = 0
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        PrintPreviewDialog1.MaximizeBox = True
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class