<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAjoutPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNom = New TextBox()
        txtPrenom = New TextBox()
        txtAge = New NumericUpDown()
        btnAjouter = New Button()
        btnannuler = New Button()
        dgv = New DataGridView()
        code = New DataGridViewTextBoxColumn()
        nom = New DataGridViewTextBoxColumn()
        prenom = New DataGridViewTextBoxColumn()
        age = New DataGridViewTextBoxColumn()
        lblDate = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(txtAge, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(103, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 28)
        Label1.TabIndex = 0
        Label1.Text = "ajouter un nouveau patient"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(90, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 28)
        Label2.TabIndex = 1
        Label2.Text = "nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(90, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 28)
        Label3.TabIndex = 2
        Label3.Text = "prénom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.Location = New Point(90, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 28)
        Label4.TabIndex = 3
        Label4.Text = "age"
        ' 
        ' txtNom
        ' 
        txtNom.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtNom.Location = New Point(201, 121)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(125, 34)
        txtNom.TabIndex = 4
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPrenom.Location = New Point(201, 186)
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(125, 34)
        txtPrenom.TabIndex = 5
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtAge.Location = New Point(201, 251)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(150, 34)
        txtAge.TabIndex = 6
        ' 
        ' btnAjouter
        ' 
        btnAjouter.BackColor = Color.MistyRose
        btnAjouter.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAjouter.Location = New Point(117, 313)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(134, 37)
        btnAjouter.TabIndex = 7
        btnAjouter.Text = "ajouter"
        btnAjouter.UseVisualStyleBackColor = False
        ' 
        ' btnannuler
        ' 
        btnannuler.BackColor = Color.MistyRose
        btnannuler.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnannuler.Location = New Point(257, 313)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(121, 37)
        btnannuler.TabIndex = 8
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = False
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Columns.AddRange(New DataGridViewColumn() {code, nom, prenom, age})
        dgv.Location = New Point(443, 121)
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(602, 257)
        dgv.TabIndex = 9
        ' 
        ' code
        ' 
        code.HeaderText = "code"
        code.MinimumWidth = 6
        code.Name = "code"
        code.Width = 125
        ' 
        ' nom
        ' 
        nom.HeaderText = "nom"
        nom.MinimumWidth = 6
        nom.Name = "nom"
        nom.Width = 125
        ' 
        ' prenom
        ' 
        prenom.HeaderText = "prenom"
        prenom.MinimumWidth = 6
        prenom.Name = "prenom"
        prenom.Width = 125
        ' 
        ' age
        ' 
        age.HeaderText = "age"
        age.MinimumWidth = 6
        age.Name = "age"
        age.Width = 125
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblDate.Location = New Point(325, 38)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(0, 28)
        lblDate.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmAjoutPatient
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 450)
        Controls.Add(lblDate)
        Controls.Add(dgv)
        Controls.Add(btnannuler)
        Controls.Add(btnAjouter)
        Controls.Add(txtAge)
        Controls.Add(txtPrenom)
        Controls.Add(txtNom)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmAjoutPatient"
        Text = "frmAjoutPatient"
        CType(txtAge, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtAge As NumericUpDown
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnannuler As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents prenom As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents lblDate As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
