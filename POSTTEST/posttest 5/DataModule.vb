Imports MySqlConnector
Imports System.IO
Imports System.Drawing

Module DataModule
    Public ReadOnly ConnectionString As String = "Server=localhost; Port=3306; Database=db_nba; User ID=root; Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    Public Function ImageToByte(img As Image) As Object
        If img Is Nothing Then Return DBNull.Value
        Using ms As New MemoryStream()
            img.Save(ms, img.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    Public Function GetAllTim() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT id_tim, nama_tim, wilayah, foto FROM tb_tim", conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function GetAllPemain() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT p.id_pemain, p.nama_pemain, p.posisi, p.foto, t.nama_tim, p.id_tim FROM tb_pemain p JOIN tb_tim t ON p.id_tim = t.id_tim", conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function GetAllCoach() As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT c.id_coach, c.nama_coach, c.jabatan, c.foto, t.nama_tim, c.id_tim FROM tb_coach c JOIN tb_tim t ON c.id_tim = t.id_tim", conn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function CariTim(keyword As String) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter("SELECT id_tim, nama_tim, wilayah, foto FROM tb_tim WHERE id_tim LIKE @key OR nama_tim LIKE @key", conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function CariPemain(keyword As String) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT p.id_pemain, p.nama_pemain, p.posisi, p.foto, t.nama_tim, p.id_tim FROM tb_pemain p JOIN tb_tim t ON p.id_tim = t.id_tim WHERE p.nama_pemain LIKE @key OR p.id_pemain LIKE @key OR t.nama_tim LIKE @key"
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function CariCoach(keyword As String) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "SELECT c.id_coach, c.nama_coach, c.jabatan, c.foto, t.nama_tim, c.id_tim FROM tb_coach c JOIN tb_tim t ON c.id_tim = t.id_tim WHERE c.nama_coach LIKE @key OR c.id_coach LIKE @key OR t.nama_tim LIKE @key"
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function SimpanTim(id As String, nama As String, wil As String, img As Image) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO tb_tim VALUES (@id, @nama, @wil, @foto)", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@wil", wil)
                cmd.Parameters.AddWithValue("@foto", ImageToByte(img))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SimpanPemain(id As String, nama As String, pos As String, idTim As String, img As Image) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO tb_pemain VALUES (@id, @nama, @pos, @idTim, @foto)", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@pos", pos)
                cmd.Parameters.AddWithValue("@idTim", idTim)
                cmd.Parameters.AddWithValue("@foto", ImageToByte(img))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SimpanCoach(id As String, nama As String, jab As String, idTim As String, img As Image) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO tb_coach VALUES (@id, @nama, @jab, @idTim, @foto)", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@jab", jab)
                cmd.Parameters.AddWithValue("@idTim", idTim)
                cmd.Parameters.AddWithValue("@foto", ImageToByte(img))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahTim(id As String, nama As String, wil As String, img As Image) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE tb_tim SET nama_tim=@nama, wilayah=@wil, foto=@foto WHERE id_tim=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@wil", wil)
                cmd.Parameters.AddWithValue("@foto", ImageToByte(img))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPemain(id As String, nama As String, pos As String, idTim As String, img As Image) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE tb_pemain SET nama_pemain=@nama, posisi=@pos, id_tim=@idTim, foto=@foto WHERE id_pemain=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@pos", pos)
                cmd.Parameters.AddWithValue("@idTim", idTim)
                cmd.Parameters.AddWithValue("@foto", ImageToByte(img))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahCoach(id As String, nama As String, jab As String, idTim As String, img As Image) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE tb_coach SET nama_coach=@nama, jabatan=@jab, id_tim=@idTim, foto=@foto WHERE id_coach=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@jab", jab)
                cmd.Parameters.AddWithValue("@idTim", idTim)
                cmd.Parameters.AddWithValue("@foto", ImageToByte(img))
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusData(tabel As String, kolomId As String, id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand($"DELETE FROM {tabel} WHERE {kolomId}=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module