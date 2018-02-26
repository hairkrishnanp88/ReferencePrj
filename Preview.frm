VERSION 5.00
Begin VB.Form Preview 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Preview"
   ClientHeight    =   9375
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   15090
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   9375
   ScaleWidth      =   15090
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.Frame Frame4 
      Height          =   825
      Left            =   0
      TabIndex        =   22
      Top             =   8640
      Width           =   16575
      Begin VB.CommandButton btnSubmit 
         Caption         =   "SUBMIT"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Left            =   4110
         TabIndex        =   23
         Top             =   270
         Width           =   1215
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Personal Details"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3165
      Index           =   0
      Left            =   -60
      TabIndex        =   12
      Top             =   1350
      Width           =   16575
      Begin VB.Label lblPanNo 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   7600
         TabIndex        =   34
         Top             =   2280
         Width           =   2715
      End
      Begin VB.Label lblMaritalStatus 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   7600
         TabIndex        =   33
         Top             =   1710
         Width           =   3285
      End
      Begin VB.Label lblCountyofBirth 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   7600
         TabIndex        =   32
         Top             =   1110
         Width           =   2925
      End
      Begin VB.Label lblLastName 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   7600
         TabIndex        =   31
         Top             =   540
         Width           =   3105
      End
      Begin VB.Label lblAadharNo 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   1800
         TabIndex        =   30
         Top             =   2700
         Width           =   3015
      End
      Begin VB.Label lblNationality 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   1800
         TabIndex        =   29
         Top             =   2160
         Width           =   3165
      End
      Begin VB.Label lblGender 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1800
         TabIndex        =   28
         Top             =   1560
         Width           =   2865
      End
      Begin VB.Label lblDateOfBirth 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   1800
         TabIndex        =   27
         Top             =   990
         Width           =   2745
      End
      Begin VB.Label lblFirstName 
         Caption         =   "Label7"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1800
         TabIndex        =   26
         Top             =   480
         Width           =   2715
      End
      Begin VB.Label Label8 
         Caption         =   "PAN No"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   1
         Left            =   6000
         TabIndex        =   21
         Top             =   2190
         Width           =   1605
      End
      Begin VB.Label Label13 
         Caption         =   "Sex"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   90
         TabIndex        =   20
         Top             =   1530
         Width           =   1605
      End
      Begin VB.Label Label16 
         Caption         =   "Nationality"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Index           =   0
         Left            =   105
         TabIndex        =   19
         Top             =   2100
         Width           =   1365
      End
      Begin VB.Label Label14 
         Caption         =   "Marital Status"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   6000
         TabIndex        =   18
         Top             =   1650
         Width           =   1605
      End
      Begin VB.Label Label11 
         Caption         =   "Country of Birth"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Index           =   0
         Left            =   6000
         TabIndex        =   17
         Top             =   1080
         Width           =   1605
      End
      Begin VB.Label Label8 
         Caption         =   "Aadhar No"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   105
         TabIndex        =   16
         Top             =   2640
         Width           =   1605
      End
      Begin VB.Label Label4 
         Caption         =   "DOB"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   90
         TabIndex        =   15
         Top             =   1020
         Width           =   1485
      End
      Begin VB.Label Label3 
         Caption         =   "Last Name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   0
         Left            =   6000
         TabIndex        =   14
         Top             =   510
         Width           =   1605
      End
      Begin VB.Label Label2 
         Caption         =   "First Name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   200
         Index           =   0
         Left            =   100
         TabIndex        =   13
         Top             =   510
         Width           =   1600
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Financial Details"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Index           =   1
      Left            =   0
      TabIndex        =   7
      Top             =   4500
      Width           =   16575
      Begin VB.Label lblOtherIncome 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   7600
         TabIndex        =   38
         Top             =   1110
         Width           =   3000
      End
      Begin VB.Label lblIncome 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   7600
         TabIndex        =   37
         Top             =   540
         Width           =   3000
      End
      Begin VB.Label lblRole 
         Caption         =   "Label5"
         Height          =   285
         Left            =   1740
         TabIndex        =   36
         Top             =   1080
         Width           =   3500
      End
      Begin VB.Label lblEmployerName 
         Caption         =   "Label5"
         Height          =   375
         Left            =   1770
         TabIndex        =   35
         Top             =   540
         Width           =   3500
      End
      Begin VB.Label lblEmpName 
         Caption         =   "Employer Name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   225
         Index           =   1
         Left            =   105
         TabIndex        =   11
         Top             =   510
         Width           =   1605
      End
      Begin VB.Label Label3 
         Caption         =   "Income"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   1
         Left            =   6000
         TabIndex        =   10
         Top             =   600
         Width           =   1605
      End
      Begin VB.Label labelRole 
         Caption         =   "Role"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Index           =   1
         Left            =   105
         TabIndex        =   9
         Top             =   1050
         Width           =   1605
      End
      Begin VB.Label Label13 
         Caption         =   "Other Income"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   1
         Left            =   6000
         TabIndex        =   8
         Top             =   1050
         Width           =   1605
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Contact Details"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   15.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2055
      Index           =   2
      Left            =   0
      TabIndex        =   0
      Top             =   6330
      Width           =   16575
      Begin VB.Label lblPostCode 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   345
         Left            =   7600
         TabIndex        =   44
         Top             =   1560
         Width           =   3600
      End
      Begin VB.Label lblCity 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Left            =   7600
         TabIndex        =   43
         Top             =   960
         Width           =   3600
      End
      Begin VB.Label lblAddL2 
         Caption         =   "Label5"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   7600
         TabIndex        =   42
         Top             =   450
         Width           =   3600
      End
      Begin VB.Label lblCountry 
         Caption         =   "Label5"
         Height          =   375
         Left            =   1800
         TabIndex        =   41
         Top             =   1590
         Width           =   3650
      End
      Begin VB.Label lblAddL3 
         Caption         =   "Label5"
         Height          =   340
         Left            =   1800
         TabIndex        =   40
         Top             =   990
         Width           =   3650
      End
      Begin VB.Label lblAddL1 
         Caption         =   "Label5"
         Height          =   340
         Left            =   1800
         TabIndex        =   39
         Top             =   480
         Width           =   3650
      End
      Begin VB.Label Label2 
         Caption         =   "Address Line 1"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   200
         Index           =   1
         Left            =   100
         TabIndex        =   6
         Top             =   510
         Width           =   1600
      End
      Begin VB.Label Label3 
         Caption         =   "Address Line 2"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   2
         Left            =   6000
         TabIndex        =   5
         Top             =   510
         Width           =   1605
      End
      Begin VB.Label Label8 
         Caption         =   "Address Line 3"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   195
         Index           =   2
         Left            =   105
         TabIndex        =   4
         Top             =   990
         Width           =   1605
      End
      Begin VB.Label Label16 
         Caption         =   "Country"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Index           =   1
         Left            =   105
         TabIndex        =   3
         Top             =   1530
         Width           =   1605
      End
      Begin VB.Label Label8 
         Caption         =   "City"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Index           =   3
         Left            =   6000
         TabIndex        =   2
         Top             =   1050
         Width           =   1605
      End
      Begin VB.Label Label8 
         Caption         =   "Post Code"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Index           =   4
         Left            =   6000
         TabIndex        =   1
         Top             =   1530
         Width           =   1605
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Label1"
      Height          =   525
      Left            =   7530
      TabIndex        =   25
      Top             =   4470
      Width           =   1245
   End
   Begin VB.Label Label9 
      BackColor       =   &H80000004&
      Caption         =   "Demat Account Application"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   20.25
         Charset         =   178
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   600
      Left            =   4020
      TabIndex        =   24
      Top             =   390
      Width           =   7305
   End
   Begin VB.Image Image1 
      Height          =   1290
      Left            =   0
      Picture         =   "Preview.frx":0000
      Top             =   0
      Width           =   3855
   End
End
Attribute VB_Name = "Preview"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub btnSubmit_Click()
    Dim objMsg As String
    Dim objfrm3 As New Result
    Dim objfrm1 As New InputSub
    
    objMsg = MsgBox("Are you sure to submit the application? ", vbYesNo, "Question")
    
    If objMsg = vbYes Then
    Me.Hide
    objfrm3.Show
    Else
    objfrm1.Show
    End If
    
End Sub



