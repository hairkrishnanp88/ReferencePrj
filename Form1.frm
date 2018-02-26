VERSION 5.00
Begin VB.Form InputSub 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Input"
   ClientHeight    =   9855
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   18060
   LinkTopic       =   "Input"
   Moveable        =   0   'False
   ScaleHeight     =   9855
   ScaleWidth      =   18060
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
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
      Left            =   720
      TabIndex        =   58
      Top             =   6090
      Width           =   16575
      Begin VB.TextBox txtPostal 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   10095
         TabIndex        =   26
         Top             =   1500
         Width           =   3000
      End
      Begin VB.TextBox txtCity 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   10095
         TabIndex        =   24
         Top             =   1020
         Width           =   3000
      End
      Begin VB.ComboBox cmbAddCountry 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         ItemData        =   "Form1.frx":0000
         Left            =   1800
         List            =   "Form1.frx":0019
         TabIndex        =   25
         Top             =   1440
         Width           =   3000
      End
      Begin VB.TextBox txtAddline3 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1800
         TabIndex        =   23
         Top             =   960
         Width           =   3000
      End
      Begin VB.TextBox txtAddline2 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   10095
         TabIndex        =   22
         Top             =   480
         Width           =   3000
      End
      Begin VB.TextBox txtAddline1 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   1800
         TabIndex        =   21
         Top             =   450
         Width           =   3000
      End
      Begin VB.Label lblPostal 
         Caption         =   "Please enter valid Postal Code"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   13200
         TabIndex        =   68
         Top             =   1530
         Visible         =   0   'False
         Width           =   3000
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
         Left            =   8100
         TabIndex        =   67
         Top             =   1530
         Width           =   1605
      End
      Begin VB.Label lbladdline1 
         Caption         =   "Please enter first name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   5000
         TabIndex        =   66
         Top             =   510
         Visible         =   0   'False
         Width           =   3000
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
         Left            =   8100
         TabIndex        =   65
         Top             =   1050
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
         TabIndex        =   64
         Top             =   1530
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
         TabIndex        =   63
         Top             =   990
         Width           =   1605
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
         Left            =   8100
         TabIndex        =   62
         Top             =   510
         Width           =   1605
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
         TabIndex        =   61
         Top             =   510
         Width           =   1600
      End
      Begin VB.Label lblCity 
         Caption         =   "Please enter valid City"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   13200
         TabIndex        =   60
         Top             =   1050
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblAddCountry 
         Caption         =   "Please choose Country"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   4995
         TabIndex        =   59
         Top             =   1500
         Visible         =   0   'False
         Width           =   3000
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
      Left            =   720
      TabIndex        =   49
      Top             =   4260
      Width           =   16575
      Begin VB.ListBox lstRole 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         ItemData        =   "Form1.frx":0052
         Left            =   1800
         List            =   "Form1.frx":0065
         TabIndex        =   17
         Top             =   1050
         Width           =   3000
      End
      Begin VB.CheckBox chkShares 
         Caption         =   "Shares"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   11910
         TabIndex        =   20
         Top             =   1050
         Width           =   1000
      End
      Begin VB.CheckBox chkFD 
         Caption         =   "FD"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   11115
         TabIndex        =   19
         Top             =   1020
         Width           =   800
      End
      Begin VB.CheckBox chkRental 
         Caption         =   "Rental"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   10110
         TabIndex        =   18
         Top             =   1020
         Width           =   900
      End
      Begin VB.TextBox txtIncome 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   10095
         TabIndex        =   16
         Top             =   540
         Width           =   3000
      End
      Begin VB.TextBox txtEmpName 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   1800
         TabIndex        =   15
         Top             =   450
         Width           =   3000
      End
      Begin VB.Label lblEMPN 
         Caption         =   "Please enter Emp name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   5000
         TabIndex        =   57
         Top             =   510
         Visible         =   0   'False
         Width           =   3000
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
         Left            =   8100
         TabIndex        =   56
         Top             =   1050
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
         TabIndex        =   55
         Top             =   1050
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
         Left            =   8100
         TabIndex        =   54
         Top             =   600
         Width           =   1605
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
         TabIndex        =   53
         Top             =   510
         Width           =   1605
      End
      Begin VB.Label lblIncome 
         Caption         =   "Please enter valid Income"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   13200
         TabIndex        =   52
         Top             =   540
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblOthIncome 
         Caption         =   "Please choose Other Income"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   13200
         TabIndex        =   51
         Top             =   1050
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblRole 
         Caption         =   "Please choose Role"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   4995
         TabIndex        =   50
         Top             =   1020
         Visible         =   0   'False
         Width           =   3000
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
      Left            =   720
      TabIndex        =   6
      Top             =   960
      Width           =   16575
      Begin VB.ComboBox cmbSal 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         ItemData        =   "Form1.frx":00AE
         Left            =   1800
         List            =   "Form1.frx":00C1
         TabIndex        =   1
         Top             =   450
         Width           =   750
      End
      Begin VB.TextBox txtFN 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2580
         TabIndex        =   2
         Top             =   450
         Width           =   2235
      End
      Begin VB.TextBox txtLN 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   10095
         TabIndex        =   3
         Top             =   510
         Width           =   3000
      End
      Begin VB.TextBox txtDOBD 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1800
         TabIndex        =   4
         Top             =   990
         Width           =   500
      End
      Begin VB.TextBox txtDOBM 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2460
         TabIndex        =   5
         Top             =   990
         Width           =   500
      End
      Begin VB.TextBox txtDOBY 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   3135
         TabIndex        =   7
         Top             =   990
         Width           =   800
      End
      Begin VB.TextBox txtAadhar 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   1800
         TabIndex        =   14
         Top             =   2580
         Width           =   3000
      End
      Begin VB.ComboBox cmbCOB 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         ItemData        =   "Form1.frx":00DF
         Left            =   10095
         List            =   "Form1.frx":00F8
         TabIndex        =   8
         Top             =   1020
         Width           =   3000
      End
      Begin VB.OptionButton optSexM 
         Caption         =   "Male"
         Height          =   315
         Left            =   1800
         TabIndex        =   9
         Top             =   1500
         Width           =   1000
      End
      Begin VB.OptionButton optSexF 
         Caption         =   "Female"
         Height          =   315
         Left            =   2800
         TabIndex        =   10
         Top             =   1500
         Width           =   1000
      End
      Begin VB.ComboBox cmbMS 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         ItemData        =   "Form1.frx":0131
         Left            =   10095
         List            =   "Form1.frx":0141
         TabIndex        =   11
         Top             =   1560
         Width           =   3000
      End
      Begin VB.ComboBox cmbNat 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         ItemData        =   "Form1.frx":0169
         Left            =   1800
         List            =   "Form1.frx":0182
         TabIndex        =   12
         Top             =   2010
         Width           =   3000
      End
      Begin VB.TextBox txtPAN 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   10095
         TabIndex        =   13
         Top             =   2130
         Width           =   3000
      End
      Begin VB.Label lblNat 
         Caption         =   "Please choose Nationality"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   5000
         TabIndex        =   48
         Top             =   2070
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblPAN 
         Caption         =   "Please enter valid PAN.No"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   13200
         TabIndex        =   47
         Top             =   2160
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblAadhar 
         Caption         =   "Please enter valid Aadhar.No"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   5000
         TabIndex        =   46
         Top             =   2640
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblMS 
         Caption         =   "Please choose Marital Status"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   13200
         TabIndex        =   45
         Top             =   1650
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblSex 
         Caption         =   "Please choose Sex"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   5000
         TabIndex        =   44
         Top             =   1590
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblCOB 
         Caption         =   "Please choose value for COB"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   13200
         TabIndex        =   43
         Top             =   1080
         Visible         =   0   'False
         Width           =   3000
      End
      Begin VB.Label lblDOB 
         Caption         =   "Please enter valid DOB"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   5000
         TabIndex        =   42
         Top             =   1020
         Visible         =   0   'False
         Width           =   3000
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
         TabIndex        =   41
         Top             =   510
         Width           =   1600
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
         Left            =   8100
         TabIndex        =   40
         Top             =   510
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
         Left            =   105
         TabIndex        =   39
         Top             =   1020
         Width           =   1605
      End
      Begin VB.Label Label5 
         Caption         =   "/"
         Height          =   255
         Index           =   0
         Left            =   2340
         TabIndex        =   38
         Top             =   1050
         Width           =   345
      End
      Begin VB.Label Label6 
         Caption         =   "/"
         Height          =   195
         Index           =   0
         Left            =   3000
         TabIndex        =   37
         Top             =   1050
         Width           =   285
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
         TabIndex        =   36
         Top             =   2640
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
         Left            =   8100
         TabIndex        =   35
         Top             =   1080
         Width           =   1605
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
         Left            =   8100
         TabIndex        =   34
         Top             =   1650
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
         TabIndex        =   33
         Top             =   2100
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
         TabIndex        =   32
         Top             =   1530
         Width           =   1605
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
         Left            =   8100
         TabIndex        =   31
         Top             =   2190
         Width           =   1605
      End
      Begin VB.Label lblFN 
         Caption         =   "Please enter first name"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   315
         Left            =   5000
         TabIndex        =   30
         Top             =   510
         Visible         =   0   'False
         Width           =   3000
      End
   End
   Begin VB.Frame Frame4 
      Height          =   825
      Left            =   720
      TabIndex        =   0
      Top             =   8400
      Width           =   16575
      Begin VB.CommandButton Command1 
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
         Left            =   5760
         TabIndex        =   27
         Top             =   300
         Width           =   1215
      End
      Begin VB.CommandButton Command2 
         Caption         =   "RESET"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   7650
         TabIndex        =   28
         Top             =   300
         Width           =   1155
      End
   End
   Begin VB.Image Image1 
      Height          =   1290
      Left            =   720
      Picture         =   "Form1.frx":01BB
      Top             =   -240
      Width           =   3855
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
      Left            =   4740
      TabIndex        =   29
      Top             =   150
      Width           =   7305
   End
End
Attribute VB_Name = "InputSub"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
Dim X As Boolean
X = True
lblFN.Visible = False
lblDOB.Visible = False
lblSex.Visible = False
lblCOB.Visible = False
lblMS.Visible = False
lblNat.Visible = False
lblPAN.Visible = False
lblAadhar.Visible = False
lblEMPN.Visible = False
lblRole.Visible = False
lblIncome.Visible = False
lblOthIncome.Visible = False
lbladdline1.Visible = False
lblCity.Visible = False
lblAddCountry.Visible = False
lblPostal.Visible = False


If txtFN.Text = "" Or cmbSal.Text = "" Then
lblFN.Visible = True
X = False
End If

If (txtDOBD.Text = "" Or txtDOBM.Text = "" Or txtDOBY.Text = "") Or (Not IsNumeric(txtDOBD.Text) Or Not IsNumeric(txtDOBM.Text) Or Not IsNumeric(txtDOBY.Text)) Then
lblDOB.Visible = True
X = False
End If

If optSexM.Value = False And optSexF.Value = False Then
lblSex.Visible = True
X = False
End If

If cmbCOB.Text = "" Then
lblCOB.Visible = True
X = False
End If

If cmbMS.Text = "" Then
lblMS.Visible = True
X = False
End If

If cmbNat.Text = "" Then
lblNat.Visible = True
X = False
End If

If txtPAN.Text = "" Then
lblPAN.Visible = True
X = False
End If

If (txtAadhar.Text = "") Or (Not IsNumeric(txtAadhar.Text)) Then
lblAadhar.Visible = True
X = False
End If

'employment
If txtEmpName.Text = "" Then
lblEMPN.Visible = True
X = False
End If

If lstRole.Text = "" Then
'lblRole.Visible = True
'X = False
End If

If (txtIncome.Text = "") Or (Not IsNumeric(txtIncome.Text)) Then
lblIncome.Visible = True
X = False
End If

If chkRental.Value = 0 And chkFD.Value = 0 And chkShares.Value = 0 Then
lblOthIncome.Visible = True
X = False
End If

'contact
If txtAddline1.Text = "" Then
lbladdline1.Visible = True
X = False
End If

If txtCity.Text = "" Then
lblCity.Visible = True
X = False
End If

If cmbAddCountry.Text = "" Then
lblAddCountry.Visible = True
X = False
End If

If txtPostal.Text = "" Then
lblPostal.Visible = True
X = False
End If

If X = True Then
Dim frm As New Preview
frm.lblFirstName.Caption = cmbSal.Text + " " + txtFN.Text
frm.lblDateOfBirth.Caption = txtDOBD.Text + " / " + txtDOBM.Text + " / " + txtDOBY.Text
If optSexM.Value = True Then
    frm.lblGender.Caption = "Male"
Else
    frm.lblGender.Caption = "Female"
End If
frm.lblNationality.Caption = cmbNat.Text
frm.lblAadharNo.Caption = txtAadhar.Text
frm.lblLastName.Caption = txtLN.Text
frm.lblCountyofBirth.Caption = cmbCOB.Text
frm.lblMaritalStatus.Caption = cmbMS.Text
frm.lblPanNo.Caption = txtPAN.Text
frm.lblEmployerName.Caption = txtEmpName.Text
frm.lblRole.Caption = lstRole.Text
frm.lblIncome.Caption = txtIncome.Text

Dim Str As String
Str = ""
If chkRental.Value = "1" Then
    Str = "Rental"
End If
If chkFD.Value = "1" And Str = "" Then
    Str = "FD"
ElseIf chkFD.Value = "1" Then
    Str = Str + ", " + "FD"
End If
If chkShares.Value = "1" And Str = "" Then
    Str = "Shares"
ElseIf chkShares.Value = "1" Then
    Str = Str + ", " + "Shares"
End If
frm.lblOtherIncome.Caption = Str

frm.lblAddL1.Caption = txtAddline1.Text
frm.lblAddL3.Caption = txtAddline3.Text
frm.lblCountry.Caption = cmbAddCountry.Text
frm.lblAddL2.Caption = txtAddline2.Text
frm.lblCity.Caption = txtCity.Text
frm.lblPostCode.Caption = txtPostal.Text
Me.Hide
frm.Show
End If

End Sub

Private Sub Command2_Click()
txtAadhar.Text = ""
txtAddline1.Text = ""
txtAddline2.Text = ""
txtAddline3.Text = ""
txtCity.Text = ""
txtDOBD.Text = ""
txtDOBM.Text = ""
txtDOBY.Text = ""
txtEmpName.Text = ""
txtFN.Text = ""
txtIncome.Text = ""
txtLN.Text = ""
txtPAN.Text = ""
txtPostal.Text = ""
lstRole.Text = ""
cmbAddCountry.Text = ""
cmbCOB.Text = ""
cmbMS.Text = ""
cmbNat.Text = ""
cmbSal.Text = ""
optSexF.Value = False
optSexM.Value = False
chkFD.Value = 0
chkRental.Value = 0
chkShares.Value = 0

lblFN.Visible = False
lblDOB.Visible = False
lblSex.Visible = False
lblCOB.Visible = False
lblMS.Visible = False
lblNat.Visible = False
lblPAN.Visible = False
lblAadhar.Visible = False
lblEMPN.Visible = False
lblRole.Visible = False
lblIncome.Visible = False
lblOthIncome.Visible = False
lbladdline1.Visible = False
lblCity.Visible = False
lblAddCountry.Visible = False
lblPostal.Visible = False
End Sub


Private Sub Form_Load()
Call Command2_Click
End Sub

