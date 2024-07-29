Module myVarPub
    Public VarUserID As Integer = 1
    Public VarUserName As String = "المدير"
    Public VarFirstName As String = "المدير"
    Public VarCompanyName As String = "المشفي الليبي الالماني"
    Public VarBGW_Status As Boolean
    Public VarInsertTime As DateTime = DateTime.Now
    Public VarUpdateTime As DateTime = DateTime.Now
    Public VarDeleteTime As DateTime = DateTime.Now
    Public VarDateTimeNow As DateTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    Public MyPubVar_Filter As String

    Public MyPubVar_adminID As Integer
    Public MyPubVar_CateLevel As String
    Public Me_MsgCaptionStr As String = VarCompanyName
    Public Me_MsgErrorStr As String = "حصل خطاء غير معروف يرجي المحاولة لاحقا"


    Public Me_MsgInfoStyle As MsgBoxStyle = CType(MsgBoxStyle.Information + MsgBoxStyle.OkOnly + vbMsgBoxRight + vbMsgBoxRtlReading + vbSystemModal, MsgBoxStyle)




    Public VarAdjective As New List(Of String)({" ", "طبي", "مدني"})
    Public VarLevel As New List(Of String)({" ", "طبي", "مدني"})
    Public VarGenderList As New List(Of String)({" ", "ذكر", "انثي"})
    Public VarItemType As New List(Of String)({"خدمة", "مادة", "مادة مركبة"})
    Public VarMaritalStatus As New List(Of String)({" ", "اعزب", "متزوج", "متزوجة", "مطلقة", "ارملة"})
    Public VarSQLCountries As String = "SELECT CountriesID,arName FROM tbCountries"
End Module
