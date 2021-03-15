using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Text;
using System.Configuration;
using System.Linq;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web;
using System.IO;
/// <summary>
/// Summary description for Utilities
/// </summary>
public class Utilities
{
    private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

    public Utilities()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public string GetStandardDateFormat(string DateValue)
    {
        if (DateValue.Trim() == string.Empty || DateValue.Length == 0)
        {
            return "";
        }

        string[] dateValue = new string[3];
        if (DateValue.IndexOf("-") != -1)
            dateValue = DateValue.Split('-');
        else if (DateValue.IndexOf("/") != -1)
            dateValue = DateValue.Split('/');
        else if (DateValue.IndexOf(".") != -1)
            dateValue = DateValue.Split('.');
        else if (DateValue.IndexOf(" ") != -1)
            dateValue = DateValue.Split(' ');

        DateTime df = new DateTime(int.Parse(dateValue[2]), int.Parse(dateValue[1]), int.Parse(dateValue[0]));
        return (df.ToString("yyyy-MM-dd"));
    }

    public string getSQLDateFormat(string strDate)
    {
        if (strDate.Trim() != "")
        {
            string frmDay = "", frmMon = "", frmYear = "";
            frmDay = strDate.Substring(0, strDate.IndexOf("/"));
            frmMon = strDate.Substring(strDate.IndexOf("/") + 1, strDate.LastIndexOf("/") - strDate.IndexOf("/") - 1);
            frmYear = strDate.Substring(strDate.LastIndexOf("/") + 1, 4);
            return (frmYear + "-" + frmMon + "-" + frmDay);
        }
        return "";
    }

    public DateTime getIndiaStandardDatetime()
    {
        string Today = string.Empty;
        DateTime indianDatetime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);
        return indianDatetime;
    }

    public string getPrintedDateFormat(DateTime pDate)
    {
        string dateformat = pDate.ToString("dd/MM/yyyy");
        return dateformat;
    }

    public bool checkIsValidDate(string pDate)
    {
        DateTime d;
        bool IsValidDate = DateTime.TryParseExact(pDate.Trim(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d);
        return IsValidDate;
    }

    public System.Data.DataTable ConvertToDataTable<T>(IList<T> data)
    {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        System.Data.DataTable table = new System.Data.DataTable();
        foreach (PropertyDescriptor prop in properties)
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        foreach (T item in data)
        {
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            table.Rows.Add(row);
        }
        return table;
    }

    public object Number2WordConverter(string Number)
    {
        string Words = null;
        int Length = 0;
        decimal Whole = default(decimal);
        decimal Fraction = default(decimal);
        Whole = Math.Floor(Convert.ToDecimal(Number));
        Number = (Convert.ToDecimal(Number) - Whole).ToString();
        Fraction = Convert.ToDecimal(Number.ToString() + "000");
        Length = Whole.ToString().Length;
        //coz if the fraction part is just 0 it will generate error in substring
        if (Fraction.ToString().Length >= 4)
        {
            Fraction = Convert.ToInt32(Fraction.ToString().Substring(2, 2));
        }
        //For 10 to 99 Crores
        if (Length == 9)
        {
            Words = MakeWord(Convert.ToInt32(Whole.ToString().Substring(0, 2))) + " Crore(s)";
            if (Convert.ToInt32(Whole.ToString().Substring(2, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(2, 2))) + " Lac(s)";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(4, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(4, 2))) + " Thousand";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(6, 1)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(6, 1))) + " Hundred";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(7, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(7, 2)));
            }
            Words += " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else if (Length == 8)
        {
            Words = MakeWord(Convert.ToInt32(Whole.ToString().Substring(0, 1))) + " Crore(s)";
            if (Convert.ToInt32(Whole.ToString().Substring(1, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(1, 2))) + " Lac(s)";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(3, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(3, 2))) + " Thousand";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(5, 1)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(5, 1))) + " Hundred";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(6, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(6, 2)));
            }
            Words += " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else if (Length == 7)
        {
            Words = MakeWord(Convert.ToInt32(Whole.ToString().Substring(0, 2))) + " Lac(s)";
            if (Convert.ToInt32(Whole.ToString().Substring(2, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(2, 2))) + " Thousand";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(4, 1)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(4, 1))) + " Hundred";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(5, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(5, 2)));
            }
            Words += " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else if (Length == 6)
        {
            Words = MakeWord(Convert.ToInt32(Whole.ToString().Substring(0, 1))) + " lac(s)";
            if (Convert.ToInt32(Whole.ToString().Substring(1, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(1, 2))) + " Thousand";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(3, 1)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(3, 1))) + " Hundred";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(4, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(4, 2)));
            }
            Words += " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else if (Length == 5)
        {
            Words = MakeWord(Convert.ToInt32(Whole.ToString().Substring(0, 2))) + " Thousand";
            if (Convert.ToInt32(Whole.ToString().Substring(2, 1)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(2, 1))) + " Hundred";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(3, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(3, 2)));
            }
            Words += " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else if (Length == 4)
        {
            Words = MakeWord(Convert.ToInt32(Whole.ToString().Substring(0, 1))) + " Thousand";
            if (Convert.ToInt32(Whole.ToString().Substring(1, 1)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(1, 1))) + " Hundred";
            }
            if (Convert.ToInt32(Whole.ToString().Substring(2, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(2, 2)));
            }
            Words += " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else if (Length == 3)
        {
            Words = MakeWord(Convert.ToInt32(Whole.ToString().Substring(0, 1))) + " Hundred";
            if (Convert.ToInt32(Whole.ToString().Substring(1, 2)) != 0)
            {
                Words += " " + MakeWord(Convert.ToInt32(Whole.ToString().Substring(1, 2)));
            }
            Words += " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else if (Length <= 2)
        {
            Words = MakeWord(Convert.ToInt32(Whole)) + " Rupee(s) And " + MakeWord(Convert.ToInt32(Fraction)) + " Paise Only.";
        }
        else
        {
            Words = "Range Exceeded.";
        }
        return Words;
    }

    public object MakeWord(int Number)
    {
        switch (Number)
        {
            case 0: return "Zero";
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            case 10: return "Ten";
            case 11: return "Eleven";
            case 12: return "Tweleve";
            case 13: return "Thirteen";
            case 14: return "Fourteen";
            case 15: return "Fifteen";
            case 16: return "Sixteen";
            case 17: return "Seventeen";
            case 18: return "Eighteen";
            case 19: return "Nineteen";
            case 20: return "Twenty";
            case 21: return "Twenty One";
            case 22: return "Twenty Two";
            case 23: return "Twenty Three";
            case 24: return "Twenty Four";
            case 25: return "Twenty Five";
            case 26: return "Twenty Six";
            case 27: return "Twenty Seven";
            case 28: return "Twenty Eight";
            case 29: return "Twenty Nine";
            case 30: return "Thirty";
            case 31: return "Thirty One";
            case 32: return "Thirty Two";
            case 33: return "Thirty Three";
            case 34: return "Thirty Four";
            case 35: return "Thirty Five";
            case 36: return "Thirty Six";
            case 37: return "Thirty Seven";
            case 38: return "Thirty Eight";
            case 39: return "Thirty Nine";
            case 40: return "Forty";
            case 41: return "Forty One";
            case 42: return "Forty Two";
            case 43: return "Forty Three";
            case 44: return "Forty Four";
            case 45: return "Forty Five";
            case 46: return "Forty Six";
            case 47: return "Forty Seven";
            case 48: return "Forty Eight";
            case 49: return "Forty Nine";
            case 50: return "Fifty";
            case 51: return "Fifty One";
            case 52: return "Fifty Two";
            case 53: return "Fifty Three";
            case 54: return "Fifty Four";
            case 55: return "Fifty Five";
            case 56: return "Fifty Six";
            case 57: return "Fifty Seven";
            case 58: return "Fifty Eight";
            case 59: return "Fifty Nine";
            case 60: return "Sixty";
            case 61: return "Sixty One";
            case 62: return "Sixty Two";
            case 63: return "Sixty Three";
            case 64: return "Sixty Four";
            case 65: return "Sixty Five";
            case 66: return "Sixty Six";
            case 67: return "Sixty Seven";
            case 68: return "Sixty Eight";
            case 69: return "Sixty Nine";
            case 70: return "Seventy";
            case 71: return "Seventy One";
            case 72: return "Seventy Two";
            case 73: return "Seventy Three";
            case 74: return "Seventy Four";
            case 75: return "Seventy Five";
            case 76: return "Seventy Six";
            case 77: return "Seventy Seven";
            case 78: return "Seventy Eight";
            case 79: return "Seventy Nine";
            case 80: return "Eighty";
            case 81: return "Eighty One";
            case 82: return "Eighty Two";
            case 83: return "Eighty Three";
            case 84: return "Eighty Four";
            case 85: return "Eighty Five";
            case 86: return "Eighty Six";
            case 87: return "Eighty Seven";
            case 88: return "Eighty Eight";
            case 89: return "Eighty Nine";
            case 90: return "Ninety";
            case 91: return "Ninety One";
            case 92: return "Ninety Two";
            case 93: return "Ninety Three";
            case 94: return "Ninety Four";
            case 95: return "Ninety Five";
            case 96: return "Ninety Six";
            case 97: return "Ninety Seven";
            case 98: return "Ninety Eight";
            case 99: return "Ninety Nine";
            default: return "Error";
        }
    }

    public bool ValidateEmail(string pEmailAddress)
    {
        string email = pEmailAddress;
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        System.Text.RegularExpressions.Match match = regex.Match(email);
        if (match.Success)
            return true;
        else
            return false;
    }

    public bool ValidateMobileNumber(string pMobileNo)
    {
        string email = pMobileNo;
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([7-9]{1})([0-9]{9})$");
        System.Text.RegularExpressions.Match match = regex.Match(email);
        if (match.Success)
            return true;
        else
            return false;
    }

    public bool ValidateIsGuid(string str)
    {
        bool isValid = false;
        Guid output = Guid.Empty;
        if (str != null)
        {
            System.Text.RegularExpressions.Regex isGuid = new System.Text.RegularExpressions.Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", System.Text.RegularExpressions.RegexOptions.Compiled);
            if (isGuid.IsMatch(str))
            {
                output = new Guid(str);
                isValid = true;
            }
        }
        return isValid;
    }

    public bool ValidateIsFileExists(string strpath, string pFileName)
    {
        bool IsAvailable = false;
        DirectoryInfo di = new System.IO.DirectoryInfo(strpath);
        string allFiles = Path.GetFullPath(di + pFileName);
        if (File.Exists(allFiles))
        {
            IsAvailable = true;
        }

        return IsAvailable;
    }

    public void ExportToExcel(System.Data.DataTable dt, string fileName, string worksheetName, string excelHeaderName, int NoOfColumns)
    {
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + fileName + "");
        HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";

        StringWriter stringWriter = new StringWriter();
        HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWriter);
        DataGrid dataExportExcel = new DataGrid();
        dataExportExcel.ItemDataBound += new DataGridItemEventHandler(dataExportExcel_ItemDataBound);
        dataExportExcel.DataSource = dt;
        dataExportExcel.DataBind();

        htmlWrite.WriteLine("<table width='100%' cellspacing='0' cellpadding = '0' border ='0'> <tr> <td width='100%' align='center' colspan='" + NoOfColumns + "'> <b><font size='3' color='#006600'>" + (HttpContext.Current.Session["SchoolName"] != null ? HttpContext.Current.Session["SchoolName"].ToString() : "") + "</font></b> </td> </tr> </table>");
        htmlWrite.WriteLine("<table width='100%' cellspacing='0' cellpadding = '0' border ='0'> <tr> <td width='100%' align='center' colspan='" + NoOfColumns + "'> <b><font size='3' color='#006600'>" + excelHeaderName + "</font></b> </td> </tr> </table>");

        dataExportExcel.RenderControl(htmlWrite);
        StringBuilder sbResponseString = new StringBuilder();
        sbResponseString.Append("<html xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" xmlns=\"http://www.w3.org/TR/REC-html40\"> <head><meta http-equiv=\"Content-Type\" content=\"text/html;charset=windows-1252\"><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>" + worksheetName + "</x:Name><x:WorksheetOptions><x:Panes></x:Panes></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--></head> <body>");
        sbResponseString.Append(stringWriter + "</body></html>");
        HttpContext.Current.Response.Write(sbResponseString.ToString());
        HttpContext.Current.Response.End();
    }

    void dataExportExcel_ItemDataBound(object sender, DataGridItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Header)
        {
            //Header Text Format can be done as follows
            e.Item.Font.Bold = true;

            //Adding Filter/Sorting functionality for the Excel
            int cellIndex = 0;
            while (cellIndex < e.Item.Cells.Count)
            {
                e.Item.Cells[cellIndex].Attributes.Add("x:autofilter", "all");
                e.Item.Cells[cellIndex].Width = 200;
                e.Item.Cells[cellIndex].BackColor = System.Drawing.Color.DarkGreen;
                e.Item.Cells[cellIndex].ForeColor = System.Drawing.Color.White;
                e.Item.Cells[cellIndex].Font.Name = "Arial";
                e.Item.Cells[cellIndex].Font.Size = 10;
                e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Center;
                cellIndex++;
            }
        }

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            //you may not want or require to do this for every row as it is bound in this event

            int cellIndex = 0;
            string strDatatype = string.Empty;
            DateTime outDtime = new DateTime();
            while (cellIndex < e.Item.Cells.Count)
            {
                //Any Cell specific formatting should be done here
                foreach (TableCell cell in e.Item.Cells)
                {
                    strDatatype = cell.AssociatedHeaderCellID.ToString();

                    if (System.DateTime.TryParse(cell.Text, out outDtime) && outDtime.TimeOfDay.Ticks == 0)
                    {
                        cell.Text = outDtime.ToShortDateString();
                    }
                  
                    switch (strDatatype.ToString())
                    {
                        case "System.String[]":
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Left;
                            break;
                        case "System.Int32[]":
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Right;
                            break;
                        case "System.Int16[]":
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Right;
                            break;
                        case "System.Int64[]":
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Right;
                            break;
                        case "System.Double[]":
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Right;
                            break;
                        case "System.Decimal[]":
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Right;
                            break;
                        case "System.Numeric[]":
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Right;
                            break;
                        default:
                            e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Left;
                            break;
                    }
                }

                //e.Item.Cells[cellIndex].HorizontalAlign = HorizontalAlign.Left;
                cellIndex++;
            }
        }
    }
}
