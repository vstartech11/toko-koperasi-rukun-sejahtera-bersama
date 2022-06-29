Imports System.Data.SqlClient
Public Class formBMasuk
    Sub awal()
        Call getData()
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
End Class