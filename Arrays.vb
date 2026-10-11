    {75, 80, 90, 85},
    {80, 85, 95, 90},
    {90, 95, 81, 80},
    {85, 90, 80, 75}
}

Console.WriteLine("Student Marks:")
For i As Integer = 0 To studentMarks.GetLength(0) - 1
    For j As Integer = 0 To studentMarks.GetLength(1) - 1
        Console.Write(studentMarks(i, j) & vbTab)
    Next
    Console.WriteLine()
Next

' Assigning values to a multidimensional array:
' Assignment 1
' Write a An Array Code that returns the 81 marks from the studentMarks array.

' Solution: Search for 81 in the studentMarks array
For i As Integer = 0 To studentMarks.GetLength(0) - 1
    For j As Integer = 0 To studentMarks.GetLength(1) - 1
        If studentMarks(i, j) = 81 Then
            Console.WriteLine("81 found at Row: " & i & " Column: " & j)
            Console.WriteLine("Value: " & studentMarks(i, j))
        End If
    Next
Next

