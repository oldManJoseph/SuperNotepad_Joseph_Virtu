Imports System.Drawing.Printing
Public Class FrmNotepad

    'Define variables used for printing
    Dim strPrintRecord As String
    Dim WithEvents DialogsPrintDocument As PrintDocument

    'variable that will either hold "Untitled.txt" if new file or
    ' the name of the opened text file.
    Dim strFileName As String = "Untitled.txt"

    'Holds opened text documents path
    Dim strFilePath As String

    'Tracks if there are unsaved changes to the textBox
    Public boolUnsavedChanges As Boolean = False

    '******************************** FILE PANEL EVENTS********************************************************
    Private Sub btnNewFile_Click(sender As Object, e As EventArgs) Handles btnNewFile.Click
        'Creates New file for user(Not saved to hardisk).
        'TODO Change to Default Font Settings

        'If there are unsaved changes in text field, prompt user if they would like to save.
        If boolUnsavedChanges = True Then
            'Prompt User to save text
            Dim Answer As DialogResult = MessageBox.Show("Unsaved changes, would you like to save?",
            "SuperNotepad", MessageBoxButtons.YesNoCancel)

            Select Case Answer
            'Saves text
                Case Windows.Forms.DialogResult.Yes
                    Save(strFileName, strFilePath)
            'Doesn't save file
                Case Windows.Forms.DialogResult.No
                    Exit Select
            'Cancels Event
                Case Windows.Forms.DialogResult.Cancel
                    Exit Sub
                    'Cancels Event
                Case Else
                    Exit Sub
            End Select
        End If

        'Clear Textbox
        txtNotepad.Text = String.Empty

        'Reset File name and path
        strFilePath = String.Empty
        strFileName = "Untitled.txt"

        'Update notepad Title
        Rename_frmNotepad(strFileName)

        'Reset unsavedChanges.
        boolUnsavedChanges = False

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        'This event allows a user to open a txt file in superNotepad

        'Set default directory as my documents
        OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)


        'If there are unsaved changes in text field, prompt user if they would like to save.
        If boolUnsavedChanges = True Then
            'Prompt User to save text
            Dim Answer As DialogResult = MessageBox.Show("Unsaved changes, would you like to save?",
            "SuperNotepad", MessageBoxButtons.YesNoCancel)

            Select Case Answer
            'Saves text
                Case Windows.Forms.DialogResult.Yes
                    Save(strFileName, strFilePath)
            'Doesn't save file
                Case Windows.Forms.DialogResult.No
                    Exit Select
            'Cancels Event
                Case Windows.Forms.DialogResult.Cancel
                    Exit Sub
                    'Cancels Event
                Case Else
                    Exit Sub
            End Select
        End If

        'If dialog end successfully open file, else end subroutine
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the file path 
                strFilePath = OpenFileDialog.FileName

                'Load file contents into memory
                Dim strFileContents As String
                strFileContents = My.Computer.FileSystem.ReadAllText(strFilePath)

                'Display the file contents in the text box
                txtNotepad.Text = strFileContents

            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title,
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Exit Sub
        End If

        'Retrieve file name then add it to frmNotepad title
        strFileName = Find_FileName(strFilePath)
        Rename_frmNotepad(strFileName)

        'No changes possible so far
        boolUnsavedChanges = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save file
        Save(strFileName, strFilePath)

    End Sub

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        'Run Save_as Function
        Save_As(strFileName, strFilePath)

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'This event gets info needed for printing from dialog then calls DialogsPrintDocument_PrintPage event.

        'Intialize instance of a printDocuement
        DialogsPrintDocument = New PrintDocument

        'Set print dialog properties
        With PrintDialog
            .Document = DialogsPrintDocument
            .PrinterSettings.DefaultPageSettings.Margins.Top = 25
            .PrinterSettings.DefaultPageSettings.Margins.Bottom = 25
            .PrinterSettings.DefaultPageSettings.Margins.Left = 25
            .PrinterSettings.DefaultPageSettings.Margins.Right = 25
        End With

        If PrintDialog.ShowDialog = DialogResult.OK Then

            'Set the selected printer settings in the PrintDocument
            DialogsPrintDocument.PrinterSettings = PrintDialog.PrinterSettings

            'Get the print data
            strPrintRecord = txtNotepad.Text

            'Invoke the Print method on the PrintDocument
            DialogsPrintDocument.Print()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DialogsPrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles DialogsPrintDocument.PrintPage
        'This Event does the actual Printing

        'Declare Variables
        Dim intCharactersToPrint As Integer
        Dim intLinesPerPage As Integer
        Dim strPrintData As String
        Dim objStringFormat As New StringFormat
        Dim objPrintFont As New Font(txtNotepad.Font.Name, txtNotepad.Font.Size)
        Dim objPageBoundaries As RectangleF
        Dim objPrintArea As SizeF

        'Get the page boundaries
        objPageBoundaries = New RectangleF(e.MarginBounds.Left,
            e.MarginBounds.Top, e.MarginBounds.Width,
            e.MarginBounds.Height)

        'Get the print area based on page margins and font used
        objPrintArea = New SizeF(e.MarginBounds.Width,
            e.MarginBounds.Height - objPrintFont.GetHeight(e.Graphics))

        'Break in between words on a line
        objStringFormat.Trimming = StringTrimming.Word

        'Get the number of characters to print
        e.Graphics.MeasureString(strPrintRecord, objPrintFont, objPrintArea,
            objStringFormat, intCharactersToPrint, intLinesPerPage)

        'If this isn't the last page to print, push the last line to the next page
        'to avoid cutting the last line in half while printing.
        If intCharactersToPrint < strPrintRecord.Length Then
            Remove_Last_Line(intCharactersToPrint, strPrintRecord)
        End If


        'Get the print data from the print record
        strPrintData = strPrintRecord.Substring(0, intCharactersToPrint)

        'set font color
        Dim fontColour As New SolidBrush(txtNotepad.ForeColor)

        'Print the page
        e.Graphics.DrawString(strPrintData, objPrintFont, fontColour,
            objPageBoundaries, objStringFormat)

        'If more lines exist, print another page
        If intCharactersToPrint < strPrintRecord.Length Then
            'Remove printed text from print record
            strPrintRecord = strPrintRecord.Remove(0, intCharactersToPrint)
            e.HasMorePages = True
        Else
            'There are no more pages to print
            e.HasMorePages = False
        End If

    End Sub
    '******************************** CLIPBOARD PANEL EVENTS********************************************************
    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        'Cuts selected text to clipboard when clicked

        'If there is selected text cut  to clip board, else do nothing
        If txtNotepad.SelectedText <> String.Empty Then
            Clipboard.Clear()
            Clipboard.SetText(txtNotepad.SelectedText)
            txtNotepad.SelectedText = ""
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        'Copys selected text to clipboard when clicked

        'If there is selected text, copy it to clip board, else do nothing
        If txtNotepad.SelectedText <> String.Empty Then
            Clipboard.Clear()
            Clipboard.SetText(txtNotepad.SelectedText)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        'Pastes Clipboard to current selected text

        txtNotepad.SelectedText = Clipboard.GetText()
    End Sub

    '******************************** TEXT PANEL EVENTS********************************************************
    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        'Opens the font panel for users to change the font of thier text

        'Open file dialog and apply user choices if user clicks ok, else exit sub
        If FontDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtNotepad.Font = FontDialog.Font
            txtNotepad.ForeColor = FontDialog.Color
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        My.Forms.frmFind.Show()
    End Sub

    '******************************** SUPPORT PANEL EVENTS********************************************************
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click

    End Sub

    '******************************** OTHER EVENTS********************************************************
    Private Sub txtNotepad_TextChanged(sender As Object, e As EventArgs) Handles txtNotepad.TextChanged
        'This event declares if their are unsaved changes in boolUnsavedChanges.
        'Used for prompting users if they would like to save unsaved changes.

        'If notepad is empty and there is no file opened, don't declare unsaved changes.
        If txtNotepad.Text = String.Empty And strFilePath = String.Empty Then
            Exit Sub
        End If

        'Declare unsaved changes.
        boolUnsavedChanges = True
    End Sub

    Private Sub FrmNotepad_Closing(sender As Object, e As _
        System.ComponentModel.CancelEventArgs) Handles Me.Closing
        'Checks if their are unsaved changes when program closes. Prompts user to save if there is.

        'If there are unsaved changes prompt user to save
        If boolUnsavedChanges = True Then
            'Prompt User to save text
            Dim Answer As DialogResult = MessageBox.Show("Unsaved changes, would you like to save?",
                "SuperNotepad", MessageBoxButtons.YesNoCancel)

            Select Case Answer
            'Saves text
                Case Windows.Forms.DialogResult.Yes
                    Save(strFileName, strFilePath)
            'Exits Prompt
                Case Windows.Forms.DialogResult.No
                    Exit Sub
            'Cancels Closing event
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
                Case Else
                    Exit Sub
            End Select
        End If
    End Sub


End Class