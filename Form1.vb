Public Class frmAjoutPatient

    Private Sub frmAjoutPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Today.ToLongDateString() ' Affiche la date actuelle dans le label lblDate'


    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim p As Patient
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
        If String.IsNullOrWhiteSpace(txtNom.Text) Then ' Vérifie si le champ Nom est vide ou contient uniquement des espaces
            ErrorProvider1.SetError(txtNom, "Le nom ne peut pas être vide.")

            Return

        End If
        If String.IsNullOrWhiteSpace(txtPrenom.Text) Then ' Vérifie si le champ Nom est vide ou contient uniquement des espaces
            ErrorProvider1.SetError(txtPrenom, "Le prenom ne peut pas être vide.")

            Return

        End If
        age = CInt(txtAge.Text) 'recupere l'age'
        p.nom = txtNom.Text
        p.prenom = txtPrenom.Text
        p.age = age
        ajouterpatient(p)
        init()
        MAJ_DGV()



    End Sub
    Private Sub init()
        txtAge.ResetText()
        txtNom.Clear()
        txtPrenom.Clear()


    End Sub
    Public Sub MAJ_DGV()
        dgv.Rows.Clear()
        For Each p As Patient In listePatient
            dgv.Rows.Add(p.code, p.nom, p.prenom, p.age)
        Next

    End Sub
End Class
