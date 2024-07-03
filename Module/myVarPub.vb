Module myVarPub
    Public VarUserID As Integer = 1
    Public VarUserName As String = "المدير"
    Public VarFirstName As String = "المدير"
    Public VarBGW_Status As Boolean
    Public VarInsertTime As DateTime = DateTime.Now
    Public VarUpdateTime As DateTime = DateTime.Now
    Public VarDeleteTime As DateTime = DateTime.Now
    Public VarDateTimeNow As DateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Public MyPubVar_Filter As String




    Public VarAdjective As New List(Of String)({" ", "طبي", "مدني"})
    Public VarGenderList As New List(Of String)({" ", "ذكر", "انثي"})
    Public VarMaritalStatus As New List(Of String)({" ", "اعزب", "متزوج", "متزوجة", "مطلقة", "ارملة"})
    Public VarSQLCountries As String = "SELECT CountriesID,arName FROM tbCountries"
End Module
