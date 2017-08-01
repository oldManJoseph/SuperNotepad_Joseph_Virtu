Public Class frmFind
    'Holds current selected text position (starts of from one, because instr requires it
    ' -1 off of it for real text location in text field
    Private intPosition As Integer = 1

    'Holds current and previous search key, used to compare the current and previous search keys to see if they have changed.
    Private strOldKey, strKey As String

    'Holds strKey search result positions
    Private intSearchResults As New List(Of Integer)

    'Holds if the chkMatchCase state has changed
    Private boolCaseStateChanged As Boolean = False

    'Holds current index position in list, (needs to start off at -1 for the indexing of list to work as intended)
    Private intIndexPosition As Integer = -1

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'When the Cancel button is clicked, close form
        Me.Close()
    End Sub


    Private Sub chkMatchCase_CheckStateChanged(sender As Object, e As EventArgs) Handles chkMatchCase.CheckStateChanged
        'If chkmatchCase's state has change, then flag boolCaseStateChanged
        boolCaseStateChanged = True

    End Sub

    Private Sub btnFindNext_Click(sender As Object, e As EventArgs) Handles btnFindNext.Click
        'Selects text based on text inputed in the search field. Has case sensitivity based on if chkMatchCase is checked.
        'User selects rad buttons up or down to choose which result is selected next

        'Update current search key
        strKey = txtFind.Text

        'If search feild is emtpy prompt user and end sub
        If txtFind.Text = String.Empty Then
            MsgBox("Search field is empty, unable to search")
            Exit Sub
        End If

        'if its first time search or key has changed, reset list and find new positions
        If strOldKey = String.Empty Or strOldKey <> strKey Or boolCaseStateChanged Then

            'Reset index position 
            intIndexPosition = -1

            'Reset Flag
            boolCaseStateChanged = False

            'Reset list
            intSearchResults.Clear()

            'Unselect past text
            FrmNotepad.txtNotepad.Select()


            'Set current key as old key for next search attempt
            strOldKey = strKey
            'Declaring variables to hold current search result and current position in text
            Dim intSearchResult, intPosition As Integer

            'Assign 1 intPosition because intstr is starts from 1 not 0
            intPosition = 1

            'Get first search 
            If chkMatchCase.Checked Then
                'If they chkMatchCase is checked, search with case sensitivity
                intSearchResult = InStr(intPosition, FrmNotepad.txtNotepad.Text, strKey, 0)
            Else
                'Else search with out case sensitivity
                intSearchResult = InStr(intPosition, FrmNotepad.txtNotepad.Text, LCase(strKey), 1)

            End If

            'If search found find the rest of search results and store in intSearchResults, 
            'Else prompt user with failure to find key
            If intSearchResult > 0 Then
                'loop until no more search results have been found
                While True
                    If intSearchResult > 0 Then

                        'add search result to list
                        intSearchResults.Add(intSearchResult)

                        If (intSearchResult + 1) <= Len(FrmNotepad.txtNotepad.Text) Then
                            'If SearchResults +1 is still in bounds of txtNotepads index, add one to intPosition
                            intPosition = intSearchResult + 1
                        Else
                            'Else all possible results have been found
                            Exit While
                        End If

                    Else
                        'All possible results have been found
                        Exit While
                    End If
                    'Get new search result for next loop
                    If chkMatchCase.Checked Then
                        'If they chkMatchCase is checked, search with case sensitivity
                        intSearchResult = InStr(intPosition, FrmNotepad.txtNotepad.Text, strKey, 0)
                    Else
                        'Else search with out case sensitivity
                        intSearchResult = InStr(intPosition, FrmNotepad.txtNotepad.Text, LCase(strKey), 1)

                    End If
                End While
            Else
                MsgBox("Cannot find """ + strKey + """")
                Exit Sub
            End If
            'MsgBox("I have reached the with " + (intSearchResults.Count).ToString + " results")
        End If

        'Another failed prompts, if user is searching for the same thing in the same text feild
        If intSearchResults.FirstOrDefault = 0 Then
            MsgBox("Cannot find """ + strKey + """")
            Exit Sub
        End If

        'Selects text according to intSearchResults.Index(intIndexPosition) and what direction a user has selected
        If radDown.Checked Then

            'If there is another result at intIndexPosition + 1, add one to index and select that text
            If intIndexPosition + 1 < intSearchResults.Count() Then
                'Add one to index
                intIndexPosition += 1
                'Select text from result
                FrmNotepad.txtNotepad.Select(intSearchResults.ElementAt(intIndexPosition) - 1, Len(strKey))

            Else
                'ran out of search results, prompt user that supernotepad is unable to find more
                MsgBox("Cannot find """ + strKey + """")
                Exit Sub
            End If

        ElseIf radUp.Checked Then
            'If there is another result at intIndexPosition - 1, minus one off the index and select that text
            If intIndexPosition - 1 >= 0 Then

                'Minus one off the index
                intIndexPosition -= 1

                'Select text from result
                FrmNotepad.txtNotepad.Select(intSearchResults.ElementAt(intIndexPosition) - 1, Len(strKey))
                'Me.BringToFront()
            Else
                'ran out of search results, prompt user that supernotepad is unable to find more
                MsgBox("Cannot find """ + strKey + """")
                Exit Sub
            End If
        Else
            MsgBox("ERROR: Neither up or down seemed to be selected, try selecting one or restarting the program")
        End If
    End Sub

End Class