VERSION 5.00
Begin VB.Form Result 
   Caption         =   "Result"
   ClientHeight    =   3195
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9555
   LinkTopic       =   "Form3"
   ScaleHeight     =   3195
   ScaleWidth      =   9555
   StartUpPosition =   3  'Windows Default
   Begin VB.Label lblAppNo 
      Alignment       =   2  'Center
      Height          =   705
      Left            =   270
      TabIndex        =   1
      Top             =   510
      Width           =   5595
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "The Application Number is :"
      Height          =   285
      Left            =   270
      TabIndex        =   0
      Top             =   180
      Width           =   5565
   End
End
Attribute VB_Name = "Result"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
lblAppNo.Caption = Int((Rnd * 99999) + 1)
End Sub




