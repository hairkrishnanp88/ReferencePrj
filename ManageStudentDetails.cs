using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for ManageStudentDetails
/// </summary>
public class ManageStudentDetails
{
	public ManageStudentDetails()
	{
		//
		// TODO: Add constructor logic here
		//
    }

    #region properties

    string _AdmissionNo = string.Empty;
    string _StudentName = string.Empty;
    string _Gender = string.Empty;
    string _DOB = string.Empty;
    string _ClassName = string.Empty;
    string _SectionName = string.Empty;
    string _AcademicYear = string.Empty;


    public string AdmissionNo
    {
        get { return _AdmissionNo; }
        set { _AdmissionNo = value; }
    }

    public string StudentName
    {
        get { return _StudentName; }
        set { _StudentName = value; }
    }

    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }

    public string DOB
    {
        get { return _DOB; }
        set { _DOB = value; }
    }

    public string ClassName
    {
        get { return _ClassName; }
        set { _ClassName = value; }
    }

    public string SectionName
    {
        get { return _SectionName; }
        set { _SectionName = value; }
    }

    public string AcademicYear
    {
        get { return _AcademicYear; }
        set { _AcademicYear = value; }
    }

    #endregion
}
