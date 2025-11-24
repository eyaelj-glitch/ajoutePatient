Module patients
    Public Structure Patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
        Dim age As Integer


    End Structure
    Public listePatient As New List(Of Patient)
    Public Sub ajouterpatient(p As Patient)
        p.code = listePatient.Count
        listePatient.Add(p)

    End Sub





End Module
