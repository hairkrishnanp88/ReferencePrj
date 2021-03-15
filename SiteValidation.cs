using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for SiteValidation
/// </summary>
public class SiteValidation
{
    public SiteValidation()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void ValidateAdminSession()
    {
        //Cache Handing
        HttpContext.Current.Response.Expires = -1;
        HttpContext.Current.Response.AddHeader("pragma", "no-cache");
        HttpContext.Current.Response.CacheControl = "no-cache";

        if (HttpContext.Current.Session["UserType"] == null || HttpContext.Current.Session["UserType"].ToString() == string.Empty)
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("../Admin/SessionExpired.aspx");
        }

        if (HttpContext.Current.Session["UserID"] == null || HttpContext.Current.Session["UserID"].ToString() == string.Empty)
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("../Admin/SessionExpired.aspx");
        }

        if (HttpContext.Current.Session["UserID"] != null && HttpContext.Current.Session["UserType"].ToString().Trim() != "3")
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("../Admin/SessionExpired.aspx");
        }
    }

    public static void ValidateTeachersSession()
    {
        //Cache Handing
        HttpContext.Current.Response.Expires = -1;
        HttpContext.Current.Response.AddHeader("pragma", "no-cache");
        HttpContext.Current.Response.CacheControl = "no-cache";

        if (HttpContext.Current.Session["UserType"] == null || HttpContext.Current.Session["UserType"].ToString() == string.Empty)
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("SessionExpired.aspx");
        }

        if (HttpContext.Current.Session["UserID"] == null || HttpContext.Current.Session["UserID"].ToString() == string.Empty)
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("SessionExpired.aspx");
        }

        if (HttpContext.Current.Session["UserID"] != null && HttpContext.Current.Session["UserType"].ToString().Trim() != "2")
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("SessionExpired.aspx");
        }
    }

    public static void ValidateStudentsSession()
    {
        //Cache Handing
        HttpContext.Current.Response.Expires = -1;
        HttpContext.Current.Response.AddHeader("pragma", "no-cache");
        HttpContext.Current.Response.CacheControl = "no-cache";

        if (HttpContext.Current.Session["UserType"] == null || HttpContext.Current.Session["UserType"].ToString() == string.Empty)
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("SessionExpired.aspx");
        }

        if (HttpContext.Current.Session["UserID"] == null || HttpContext.Current.Session["UserID"].ToString() == string.Empty)
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("SessionExpired.aspx");
        }

        if (HttpContext.Current.Session["UserID"] != null && HttpContext.Current.Session["UserType"].ToString().Trim() != "1")
        {
            ClearAllSessionVariables();
            HttpContext.Current.Response.Redirect("SessionExpired.aspx");
        }
    }

    public static void ClearAllSessionVariables()
    {
        HttpContext.Current.Session.Clear();
        HttpContext.Current.Session.Abandon();
    }

    public static void ClearAllCacheValues()
    {
        //Cache Handing
        HttpContext.Current.Response.Expires = -1;
        HttpContext.Current.Response.AddHeader("pragma", "no-cache");
        HttpContext.Current.Response.CacheControl = "no-cache";
    }
}
