''' <summary>
''' Contains all non event functions
''' </summary>
Public Module Functions
    'Declare public variables
    Public Property boolUnsavedChanges As Boolean
    Public Property strSearchResults As List(Of String)

    Sub Rename_frmNotepad(ByVal strFileName As String)
        'changes text property of frmNotepad to strFileName + "- SuperNotepad"
        FrmNotepad.Text = strFileName + " - SuperNotepad"
    End Sub

    Function Find_FileName(ByVal strPath As String) As String
        'Retrieves the name of a file from a file path, then returns it

        'get length of path
        Dim intPathSize As Integer = Len(strPath) - 1

        'Counts the size of the string, thats going to be removed from path
        'Counter is set to -1 to account for loop counting the "\" char.
        Dim intCounter As Integer = -1

        'holds a char from strPath to be compared to "\"
        Dim chrLetter As Char = ""

        'Iterates through strPath starting from the end entil it finds "\" character
        Do While chrLetter <> "\"
            chrLetter = strPath.Chars(intPathSize)
            intPathSize -= 1
            intCounter += 1
        Loop


        'Retrieve Name of file using counter to take the name off the end of the Path
        Dim strResult As String = Right(strPath, intCounter)

        'Return Name of File
        Return strResult
    End Function

    Sub Save_As(ByRef strFileName As String, ByRef strFilePath As String)
        'Opens the Save dialog so the user can Save current document how they want to.

        'Set default directory as my documents
        FrmNotepad.SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        If strFilePath <> String.Empty Then
            FrmNotepad.SaveFileDialog.InitialDirectory = strFilePath
        End If
        'sets the dialog FileName text as currrent files name
        FrmNotepad.SaveFileDialog.FileName = strFileName

        If FrmNotepad.SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the file path and name
                strFilePath = FrmNotepad.SaveFileDialog.FileName
                strFileName = Find_FileName(strFilePath)

                'Save file to computer
                My.Computer.FileSystem.WriteAllText(strFilePath,
                                 FrmNotepad.txtNotepad.Text, False)
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title,
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else Exit Sub
        End If

        'Set Notepad title to current file
        Rename_frmNotepad(strFileName)

        'All changes are saved
        boolUnsavedChanges = False
    End Sub

    Sub Save(ByRef strFileName As String, ByRef strFilePath As String)
        'Saves current file, if that file isn't saved to Harddisk, opens Save as dialog

        'When Save button is clicked save opened document or open Save File dialog if doc is new
        If strFilePath = String.Empty Then
            'Open Save File Dialog
            Save_As(strFileName, strFilePath)
        Else
            'Save file to computer
            My.Computer.FileSystem.WriteAllText(strFilePath,
                             FrmNotepad.txtNotepad.Text, False)
        End If

        'All changes are saved
        boolUnsavedChanges = False
    End Sub

    Sub Reset_Font()
        'Resets Font settings to default.

        'Resets Font and color in txtNotepad.
        With FrmNotepad.txtNotepad
            .Font = New Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            .ForeColor = Color.Black
        End With

        'Resets Font and color in fontdialog
        With FrmNotepad.FontDialog
            .Font = New Drawing.Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            .Color = Color.Black
        End With
    End Sub

    Sub Remove_Last_Line(ByRef intCharactersToPrint As Integer, ByVal strPrintRecord As String)
        'Used only for printing, removes the last line from a printed page, and pushes it to the next
        'This is accomplished by removing the amount of characters in the last line from intCharacterToPrint
        'Only to be used on full pages, so the last line of the page doesn't get cut in half.

        'Skips over first newline character
        intCharactersToPrint -= 2

        'Variable used in below while condition
        Dim chrLetter As Char = strPrintRecord.Chars(intCharactersToPrint)

        'While chrLetter does not equal a newline char, minus -1 off of intCharacters
        'to remove the that char from the currrent page.
        Do While chrLetter <> Chr(10)
            intCharactersToPrint -= 1
            chrLetter = strPrintRecord.Chars(intCharactersToPrint)
        Loop

        'Accounts for loop minusing an extra char off of intCharactersToPrint
        intCharactersToPrint += 1
    End Sub


End Module
