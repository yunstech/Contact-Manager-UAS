<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btn_display = New Button()
        btn_add = New Button()
        btn_remove = New Button()
        ListBox1 = New ListBox()
        txtFilePath = New TextBox()
        btn_selectFile = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SuspendLayout()
        ' 
        ' btn_display
        ' 
        btn_display.Location = New Point(35, 66)
        btn_display.Name = "btn_display"
        btn_display.Size = New Size(150, 46)
        btn_display.TabIndex = 0
        btn_display.Text = "Display"
        btn_display.UseVisualStyleBackColor = True
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(222, 66)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(150, 46)
        btn_add.TabIndex = 1
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' btn_remove
        ' 
        btn_remove.Location = New Point(415, 66)
        btn_remove.Name = "btn_remove"
        btn_remove.Size = New Size(150, 46)
        btn_remove.TabIndex = 2
        btn_remove.Text = "Remove"
        btn_remove.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(35, 244)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(1588, 676)
        ListBox1.TabIndex = 3
        ' 
        ' txtFilePath
        ' 
        txtFilePath.Location = New Point(998, 73)
        txtFilePath.Name = "txtFilePath"
        txtFilePath.Size = New Size(439, 39)
        txtFilePath.TabIndex = 5
        ' 
        ' btn_selectFile
        ' 
        btn_selectFile.Location = New Point(1462, 66)
        btn_selectFile.Name = "btn_selectFile"
        btn_selectFile.Size = New Size(150, 46)
        btn_selectFile.TabIndex = 4
        btn_selectFile.Text = "Select File"
        btn_selectFile.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "openFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1655, 1057)
        Controls.Add(txtFilePath)
        Controls.Add(btn_selectFile)
        Controls.Add(ListBox1)
        Controls.Add(btn_remove)
        Controls.Add(btn_add)
        Controls.Add(btn_display)
        Name = "Form1"
        Text = "Contact Manager"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_display As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btn_selectFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
