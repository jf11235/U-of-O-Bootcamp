Sub stockprice()

Dim ws As Worksheet
For Each ws In ThisWorkbook.Worksheets

Dim firstprice As Double
Dim lastprice As Double
Dim perchange As Double
Dim change As Double

Dim volume As LongLong

Dim ticker As String

Dim summary_table_row As Integer
summary_table_row = 2

            ws.Range("J1") = "ticker"
            ws.Range("k1") = "change"
            ws.Range("L1") = "percent change"
            ws.Range("M1") = "volume"
            

For i = 2 To 1000000
        If ws.Cells(i + 1, 1).Value <> ws.Cells(i, 1).Value Then
            ticker = ws.Cells(i, 1).Value
            volume = volume + ws.Cells(i, 7).Value
            lastprice = ws.Cells(i, 6).Value
            
            change = lastprice - firstprice
          
            perchange = (lastprice - firstprice) / firstprice * 100
        
            
            ws.Range("J" & summary_table_row) = ticker
            ws.Range("k" & summary_table_row) = change
            ws.Range("L" & summary_table_row) = perchange
            ws.Range("M" & summary_table_row) = volume
            
            
                If ws.Range("L" & summary_table_row).Value > 0 Then
                ws.Range("L" & summary_table_row).Interior.ColorIndex = 4
                Else
                ws.Range("L" & summary_table_row).Interior.ColorIndex = 3
                
                End If
                
            
            
            'reset all data
            volume = 0
            'not sure if i have to reset firstprice here
            'firstprice = 0
            lastprice = 0
            summary_table_row = summary_table_row + 1
            
    
        Else
            Dim rng As Range
            'Dim min As Double
            Set rng = ws.Range("B:B")
        If ws.Cells(i, 2).Value = WorksheetFunction.min(rng) Then
        
            firstprice = ws.Cells(i, 3).Value
            End If
        
        
                 
            
        volume = volume + ws.Cells(i, 7).Value
    
    
        End If
        
    
    Next i
    
    Dim rng2 As Range
    Set rng2 = ws.Range("L:L")
    Set rng1 = ws.Range("M:M")
    Dim maxV As Double
    Dim max As Double
    Dim min As Double
    Dim ticker1 As String
    Dim tickermin As String
    Dim tickermax As String
    Dim tickerV As String
    
    ws.Range("O2") = "Greatest  % increase"
    ws.Range("o3") = "Greatest % decrese"
    ws.Range("o4") = "Greatest total volume"
    
    ws.Range("p1") = "Ticker"
    ws.Range("q1") = "Value"
    
    For i = 2 To 100000
    
    
    max = WorksheetFunction.max(rng2)
    min = WorksheetFunction.min(rng2)
    maxV = WorksheetFunction.max(rng1)
    
    If ws.Cells(i, 12).Value = WorksheetFunction.min(rng2) Then
        
            tickermin = ws.Cells(i, 10).Value
    End If
            
    If ws.Cells(i, 12).Value = WorksheetFunction.max(rng2) Then
        
            tickermax = ws.Cells(i, 10).Value
    End If
            
    If ws.Cells(i, 13).Value = WorksheetFunction.max(rng1) Then
        
            tickerV = ws.Cells(i, 10).Value
    End If
    
    
    Next i
    
    ws.Range("p2") = tickermax
    ws.Range("p3") = tickermin
    ws.Range("p4") = tickerV
    
    ws.Range("Q2") = max
    ws.Range("Q3") = min
    ws.Range("Q4") = maxV
    
    Next ws

End Sub

-------------------
Sub stockprice()

Dim firstprice As Double
Dim lastprice As Double
Dim perchange As Double
Dim change As Double

Dim volume As LongLong

Dim ticker As String

Dim summary_table_row As Integer
summary_table_row = 2

            ws.range("J1") = "ticker"
            ws.range("k1") = "change"
            ws.range("L1") = "percent change"
            ws.range("M1") = "volume"
            

For i = 2 To 30000
        If ws.cells(i + 1, 1).Value <> ws.cells(i, 1).Value Then
            ticker = ws.cells(i, 1).Value
            volume = volume + ws.cells(i, 7).Value
            lastprice = ws.cells(i, 6).Value
            
            change = lastprice - firstprice
          
            perchange = (lastprice - firstprice) / firstprice * 100
        
            
            ws.range("J" & summary_table_row) = ticker
            ws.range("k" & summary_table_row) = change
            ws.range("L" & summary_table_row) = perchange
            ws.range("M" & summary_table_row) = volume
            
            
                If ws.range("L" & summary_table_row).Value > 0 Then
                ws.range("L" & summary_table_row).Interior.ColorIndex = 4
                Else
                ws.range("L" & summary_table_row).Interior.ColorIndex = 3
                
                End If
                
            
            
            'reset all data
            volume = 0
            'not sure if i have to reset firstprice here
            'firstprice = 0
            lastprice = 0
            summary_table_row = summary_table_row + 1
            
    
        Else
            Dim rng As ws.range
            'Dim min As Double
            Set rng = ws.range("B:B")
        If ws.cells(i, 2).Value = WorksheetFunction.min(rng) Then
        
            firstprice = ws.cells(i, 3).Value
            End If
        
        
            'i think this is the way to go but its not working
             'min = Application.WorksheetFunction.min(rng)
             'If ws.range("B:B") = min Then
             'firstprice = ws.range("ci").Value
             'End If
                 'this if statement is incorrectly comparing column b value to the next one all the way down the column
                 'If ws.cells(i, 2).Value < ws.cells(i + 1, 2).Value Then
                 'firstprice = ws.cells(i, 3).Value
                 'End If
                 
            
        volume = volume + ws.cells(i, 7).Value
    
    
        End If
        
    
    Next i
    
    Dim rng2 As ws.range
    Set rng2 = ws.range("L:L")
    Set rng1 = ws.range("M:M")
    Dim maxV As Double
    Dim max As Double
    Dim min As Double
    Dim ticker1 As String
    Dim tickermin As String
    Dim tickermax As String
    Dim tickerV As String
    
    ws.range("O2") = "Greatest  % increase"
    ws.range("o3") = "Greatest % decrese"
    ws.range("o4") = "Greatest total volume"
    
    ws.range("p1") = "Ticker"
    ws.range("q1") = "Value"
    
    For i = 2 To 200
    
    
    max = WorksheetFunction.max(rng2)
    min = WorksheetFunction.min(rng2)
    maxV = WorksheetFunction.max(rng1)
    
    If ws.cells(i, 12).Value = WorksheetFunction.min(rng2) Then
        
            tickermin = ws.cells(i, 10).Value
    End If
            
    If ws.cells(i, 12).Value = WorksheetFunction.max(rng2) Then
        
            tickermax = ws.cells(i, 10).Value
    End If
            
    If ws.cells(i, 13).Value = WorksheetFunction.max(rng1) Then
        
            tickerV = ws.cells(i, 10).Value
    End If
    
    
    Next i
    
    ws.range("p2") = tickermax
    ws.range("p3") = tickermin
    ws.range("p4") = tickerV
    
    ws.range("Q2") = max
    ws.range("Q3") = min
    ws.range("Q4") = maxV
    

End Sub
---------------------
Sub stockprice()

Dim firstprice As Double
Dim lastprice As Double
Dim perchange As Double
Dim change As Double

Dim volume As LongLong

Dim ticker As String

Dim summary_table_row As Integer
summary_table_row = 2

            ws.range("J1") = "ticker"
            ws.range("k1") = "change"
            ws.range("L1") = "percent change"
            ws.range("M1") = "volume"
            

For i = 2 To 30000
        If ws.cells(i + 1, 1).Value <> ws.cells(i, 1).Value Then
            ticker = ws.cells(i, 1).Value
            volume = volume + ws.cells(i, 7).Value
            lastprice = ws.cells(i, 6).Value
            
            change = lastprice - firstprice
          
            perchange = (lastprice - firstprice) / firstprice * 100
        
            
            ws.range("J" & summary_table_row) = ticker
            ws.range("k" & summary_table_row) = change
            ws.range("L" & summary_table_row) = perchange
            ws.range("M" & summary_table_row) = volume
            
            
                If ws.range("L" & summary_table_row).Value > 0 Then
                ws.range("L" & summary_table_row).Interior.ColorIndex = 4
                Else
                ws.range("L" & summary_table_row).Interior.ColorIndex = 3
                
                End If
                
            
            
            'reset all data
            volume = 0
            'not sure if i have to reset firstprice here
            'firstprice = 0
            lastprice = 0
            summary_table_row = summary_table_row + 1
            
    
        Else
            Dim rng As ws.range
            'Dim min As Double
            Set rng = ws.range("B:B")
        If ws.cells(i, 2).Value = WorksheetFunction.min(rng) Then
        
            firstprice = ws.cells(i, 3).Value
            End If
        
        
            'i think this is the way to go but its not working
             'min = Application.WorksheetFunction.min(rng)
             'If ws.range("B:B") = min Then
             'firstprice = ws.range("ci").Value
             'End If
                 'this if statement is incorrectly comparing column b value to the next one all the way down the column
                 'If ws.cells(i, 2).Value < ws.cells(i + 1, 2).Value Then
                 'firstprice = ws.cells(i, 3).Value
                 'End If
                 
            
        volume = volume + ws.cells(i, 7).Value
    
    
        End If
        
    
    Next i
    
    Dim rng2 As ws.range
    Set rng2 = ws.range("L:L")
    Set rng1 = ws.range("M:M")
    Dim maxV As Double
    Dim max As Double
    Dim min As Double
    Dim ticker1 As String
    Dim tickermin As String
    Dim tickermax As String
    Dim tickerV As String
    
    ws.range("O2") = "Greatest  % increase"
    ws.range("o3") = "Greatest % decrese"
    ws.range("o4") = "Greatest total volume"
    
    ws.range("p1") = "Ticker"
    ws.range("q1") = "Value"
    
    For i = 2 To 200
    
    
    max = WorksheetFunction.max(rng2)
    min = WorksheetFunction.min(rng2)
    maxV = WorksheetFunction.max(rng1)
    
    If ws.cells(i, 12).Value = WorksheetFunction.min(rng2) Then
        
            tickermin = ws.cells(i, 10).Value
    End If
            
    If ws.cells(i, 12).Value = WorksheetFunction.max(rng2) Then
        
            tickermax = ws.cells(i, 10).Value
    End If
            
    If ws.cells(i, 13).Value = WorksheetFunction.max(rng1) Then
        
            tickerV = ws.cells(i, 10).Value
    End If
    
    
    Next i
    
    ws.range("p2") = tickermax
    ws.range("p3") = tickermin
    ws.range("p4") = tickerV
    
    ws.range("Q2") = max
    ws.range("Q3") = min
    ws.range("Q4") = maxV
    

End Sub

