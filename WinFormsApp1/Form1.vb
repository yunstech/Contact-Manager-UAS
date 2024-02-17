Imports System.IO

Public Class Form1

    Private contacts As New List(Of String)
    Private filePath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No need to load contacts here
    End Sub

    Private Sub LoadContactsFromFile(filePath As String)
        If File.Exists(filePath) Then
            contacts.Clear() ' Clear existing contacts before loading from file
            Using reader As New StreamReader(filePath)
                Dim line As String
                Do
                    line = reader.ReadLine()
                    If line IsNot Nothing Then
                        contacts.Add(line)
                    End If
                Loop Until line Is Nothing
            End Using
            DisplayContacts() ' Automatically display contacts after loading from file
        End If
    End Sub

    Private Sub DisplayContacts()
        ListBox1.Items.Clear() ' Clear ListBox before displaying contacts
        If contacts.Count > 0 Then
            For Each contact As String In contacts
                ListBox1.Items.Add(contact)
            Next
        Else
            ListBox1.Items.Add("No contacts available.")
        End If
    End Sub

    Private Sub SaveContactsToFile(filePath As String)
        Using writer As New StreamWriter(filePath)
            For Each contact As String In contacts
                writer.WriteLine(contact)
            Next
        End Using
    End Sub

    Private Sub AddContact(contactName As String, phoneNumber As String)
        contacts.Add($"{contactName} - {phoneNumber}")
        DisplayContacts() ' Automatically display contacts after adding a contact
    End Sub

    Private Sub RemoveContact(contactName As String)
        ' Search for the contact with the given name
        For Each contact As String In contacts
            If contact.StartsWith(contactName & " - ") Then
                contacts.Remove(contact)
                Exit For ' Exit loop after removing the contact
            End If
        Next
        DisplayContacts() ' Automatically display contacts after removing a contact
    End Sub

    Private Sub btn_display_Click(sender As Object, e As EventArgs) Handles btn_display.Click
        DisplayContacts()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim newContactName As String = InputBox("Enter the name of the new contact:")
        Dim newContactNumber As String = InputBox("Enter the phone number of the new contact:")

        If Not String.IsNullOrEmpty(newContactName) AndAlso Not String.IsNullOrEmpty(newContactNumber) Then
            AddContact(newContactName, newContactNumber)
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim contactToRemove As String = InputBox("Enter the name of the contact to remove:")
        If Not String.IsNullOrEmpty(contactToRemove) Then
            RemoveContact(contactToRemove)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not String.IsNullOrEmpty(filePath) Then
            SaveContactsToFile(filePath)
        End If
    End Sub

    Private Sub btn_selectFile_Click(sender As Object, e As EventArgs) Handles btn_selectFile.Click
        Dim openFileDialog1 As New OpenFileDialog

        openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog = DialogResult.OK Then
            ' Display the selected file path
            filePath = openFileDialog1.FileName
            txtFilePath.Text = filePath
            ' Load contacts from the selected file
            LoadContactsFromFile(filePath)
        End If
    End Sub
End Class
