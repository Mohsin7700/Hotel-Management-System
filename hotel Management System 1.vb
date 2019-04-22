'My functions'

Dim op, fn As Integer


Private Sub Command1_Click()
'Decelartions of Variable'
'Variables for foods'
Dim karhai As Integer
Dim biryani As Integer
Dim sabzi As Integer
Dim qorma As Integer

'Variables for fast food drinks'
Dim broast As Integer
Dim zinger As Integer
Dim sandvich As Integer

'Variable for Cold'
Dim Cold_drink As Integer
Dim juice As Integer

'Variable for Hot Drink'
Dim cofee As Integer
Dim tea As Integer

'variable for sub total and total'
Dim tax As Integer
Dim total As Double

'variable for customer name'
Dim customer_name As String
customer_name = text19.Text

'current date'
Dim time As Date
time = Now()

'============================'
Cold_drink = Text2.Text
juice = Text4.Text

'------------------'

cofee = Text6.Text
tea = Text7.Text

'---------------------'

karhai = text9.Text
biryani = text10.Text
sabzi = text11.Text
qorma = Text12.Text

'--------------------'

broast = Text13.Text
zinger = Text14.Text
sandvich = text15.Text

total = (Cold_drink + juice + cofee + tea + karhai + biryani + sabzi + qorma + broast + zinger + sandvich)
Text17.Text = total

'Decalartion of tax'
tax = (1 / 100) * total
Text16.Text = tax

'list box'
List1.AddItem ("------------------*------------------------")
List1.AddItem ("----------Customer Reciept------------")
List1.AddItem ("Date  : " & time)
List1.AddItem ("Customer name  :  " & customer_name)
List1.AddItem ("Total tax:  " & tax)
List1.AddItem ("Total cost of items: " & total)
List1.AddItem ("--------Thank You------------")
List1.AddItem ("-------------------------------------")

End Sub

Private Sub Command10_Click()
Text18.Text = Text18.Text & 5
End Sub

Private Sub Command11_Click()
Text18.Text = Text18.Text & 6
End Sub

Private Sub Command12_Click()
op = 2
fn = Text18.Text
Text18.Text = ""

End Sub

Private Sub Command13_Click()
Text18.Text = Text18.Text & 1
End Sub

Private Sub Command14_Click()
Text18.Text = Text18.Text & 2
End Sub

Private Sub Command15_Click()
Text18.Text = Text18.Text & 3
End Sub

Private Sub Command16_Click()
op = 3
fn = Text18.Text
Text18.Text = ""

End Sub

Private Sub Command17_Click()
Text18.Text = Text18.Text & 0
End Sub

Private Sub Command18_Click()
Text18.Text = Text18.Text & (".")

End Sub

Private Sub Command19_Click()
Text18.Text = ""

End Sub

Private Sub Command20_Click()
op = 4
fn = Text18.Text
Text18.Text = ""

End Sub

Private Sub Command21_Click()
If op = 1 Then
Text18.Text = Val(fn) + Val(Text18.Text)
ElseIf op = 2 Then
Text18.Text = Val(fn) - Val(Text18.Text)
ElseIf op = 3 Then
Text18.Text = Val(fn) * Val(Text18.Text)
ElseIf op = 4 Then
Text18.Text = Val(fn) / Val(Text18.Text)
End If


End Sub

Private Sub Command3_Click()
Unload Form1
Form1.Show
End Sub

Private Sub Command4_Click()
Unload Form1
End Sub

Private Sub Command5_Click()
Text18.Text = Text18.Text & 7
End Sub

Private Sub Command6_Click()
Text18.Text = Text18.Text & 8
End Sub

Private Sub Command7_Click()
Text18.Text = Text18.Text & 9
End Sub

Private Sub Command8_Click()
op = 1
fn = Text18.Text
Text18.Text = ""

End Sub

Private Sub Command9_Click()
Text18.Text = Text18.Text & 4
End Sub

