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
using System.Data.SqlClient;

/// <summary>
/// Summary description for ManageStudentMarksDAL
/// </summary>
public class ManageStudentMarksDAL
{
    DbFunction dbobj = new DbFunction();
    public ManageStudentMarksDAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable GetStudentExamMarksByAdmissionNo(int ClassId, int SectionId, int ExamId, string AdmissionNo, int AcademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GetStudentExamMarksByAdmissionNo");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@ExamId", ExamId);
            cmd.Parameters.AddWithValue("@AdmissionNo", AdmissionNo);
            cmd.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public DataTable GetExamMarksDetailsByStudentId(int ClassId, int SectionId, int ExamId, string StudentID, int AcademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GetExamMarksDetailsByStudentId");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@ExamId", ExamId);
            cmd.Parameters.AddWithValue("@StudentId", StudentID);
            cmd.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public DataTable SelectClassSectionwiseExamMarks(int ClassId, int SectionId, int ExamId, int AcademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("spSelectClassSectionwiseExamMarks");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@ExamId", ExamId);
            cmd.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public DataTable SelectClassSectionwiseStudentExamMarks(int ClassId, int SectionId, int ExamId, string StudentID, int AcademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("spSelectClassSectionwiseStudentExamMarks");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@ExamId", ExamId);
            cmd.Parameters.AddWithValue("@StudentId", StudentID);
            cmd.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public DataTable GetExamMarksDetailsByClassAndSectionId(int ClassId, int SectionId, int ExamId, int AcademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GetExamMarksDetailsByClassAndSectionId");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@ExamId", ExamId);
            cmd.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public DataTable GetSubjectMarks(int Marksid, int SubjectId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GetSubjectMarksByMSId");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Marksid", Marksid);
            cmd.Parameters.AddWithValue("@SubjectId", SubjectId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public DataTable GetStudentsSubjectMarks(int ClassId, int SectionId, int ExamId, string StudentId, int SubjectId, int AcademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GetStudentSubjectMarks");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@ExamId", ExamId);
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@SubjectId", SubjectId);
            cmd.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {  }
    }

    public bool InsertStudentMarks(string MarksID, string StudentId, int ClassId, int SectionId, int ExamId, int AcademicYearId, string LoginUserID)
    {
        SqlCommand cmdInsert = new SqlCommand("InsertStudentMarks");
        cmdInsert.CommandType = CommandType.StoredProcedure;
        cmdInsert.Parameters.AddWithValue("@Marks_Id", MarksID);
        cmdInsert.Parameters.AddWithValue("@StudentId", StudentId);
        cmdInsert.Parameters.AddWithValue("@ClassId", ClassId);
        cmdInsert.Parameters.AddWithValue("@SectionId", SectionId);
        cmdInsert.Parameters.AddWithValue("@ExamId", ExamId);
        cmdInsert.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
        cmdInsert.Parameters.AddWithValue("@LogUserID", LoginUserID);

        if (dbobj.ExecuteNonQuery(cmdInsert))
        {
            cmdInsert.Dispose();
            return true;
        }
        else
        {
            cmdInsert.Dispose();
            return false;
        }
    }

    public bool UpdateStudentMarks(string MarksID, string StudentId, int ClassId, int SectionId, int ExamId, int AcademicYearId, string LoginUserID)
    {
        SqlCommand cmdUpdate = new SqlCommand("UpdateStudentMarks");
        cmdUpdate.CommandType = CommandType.StoredProcedure;
        cmdUpdate.Parameters.AddWithValue("@Marks_Id", MarksID);
        cmdUpdate.Parameters.AddWithValue("@StudentId", StudentId);
        cmdUpdate.Parameters.AddWithValue("@ClassId", ClassId);
        cmdUpdate.Parameters.AddWithValue("@SectionId", SectionId);
        cmdUpdate.Parameters.AddWithValue("@ExamId", ExamId);
        cmdUpdate.Parameters.AddWithValue("@AcademicYear_Id", AcademicYearId);
        cmdUpdate.Parameters.AddWithValue("@LogUserID", LoginUserID);

        if (dbobj.ExecuteNonQuery(cmdUpdate))
        {
            cmdUpdate.Dispose();
            return true;
        }
        else
        {
            cmdUpdate.Dispose();
            return false;
        }
    }

    public bool InsertStudentMarksDetails(string MarksID, int SubjectId, decimal MarksScored)
    {
        SqlCommand cmdInsert = new SqlCommand("InsertStudentMarksDetails");
        cmdInsert.CommandType = CommandType.StoredProcedure;
        cmdInsert.Parameters.AddWithValue("@Marks_Id", MarksID);
        cmdInsert.Parameters.AddWithValue("@Subject_id", SubjectId);
        cmdInsert.Parameters.AddWithValue("@Marks_Scored", MarksScored);

        if (dbobj.ExecuteNonQuery(cmdInsert))
        {
            cmdInsert.Dispose();
            return true;
        }
        else
        {
            cmdInsert.Dispose();
            return false;
        }
    }

    public bool UpdateStudentMarksDetails(string MarksID, int SubjectId, decimal MarksScored)
    {
        SqlCommand cmdUpdate = new SqlCommand("UpdateStudentMarksDetails");
        cmdUpdate.CommandType = CommandType.StoredProcedure;
        cmdUpdate.Parameters.AddWithValue("@Marks_Id", MarksID);
        cmdUpdate.Parameters.AddWithValue("@Subject_id", SubjectId);
        cmdUpdate.Parameters.AddWithValue("@Marks_Scored", MarksScored);

        if (dbobj.ExecuteNonQuery(cmdUpdate))
        {
            cmdUpdate.Dispose();
            return true;
        }
        else
        {
            cmdUpdate.Dispose();
            return false;
        }
    }

    public DataTable GetExamSubjectsForStudentsMarks(int ClassId, int SectionId, int ExamId, int AccademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GetExamSubjectsForStudentsMarks");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@ExamId", ExamId);
            cmd.Parameters.AddWithValue("@AccademicYearId", AccademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public DataTable SearchExaminationMarks(int AccademicYearId, int ClassId, int SectionId, string studentName, string AdmissionNo, int ExamId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("spSearchExaminationMarks");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AcademicYearId", AccademicYearId);
            cmd.Parameters.AddWithValue("@Class_Id", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@StudentName", studentName);
            cmd.Parameters.AddWithValue("@AdmissionNo", AdmissionNo);
            cmd.Parameters.AddWithValue("@Exam_Id", ExamId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { dbobj = null; }
    }

    public bool DeleteStudentmarks(int Academicyearid, string MarksId, string UserId)
    {
        try
        {
            SqlCommand cmdDelete = new SqlCommand("spDeleteStudentMarksByMarksID");
            cmdDelete.CommandType = CommandType.StoredProcedure;
            cmdDelete.Parameters.AddWithValue("@AcademicYearId", Academicyearid);
            cmdDelete.Parameters.AddWithValue("@Marks_Id", MarksId);
            cmdDelete.Parameters.AddWithValue("@LoginUserID", UserId);

            if (dbobj.ExecuteNonQuery(cmdDelete))
            {
                cmdDelete.Dispose();
                return true;
            }
            else
            {
                cmdDelete.Dispose();
                return false;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { }
    }

    public bool UpdatePublishExamResultsToWeb(int Academicyearid, string Marksid, string userid)
    {
        SqlCommand cmdUpdate = new SqlCommand("spUpdatePublishExamResultsToWeb");
        cmdUpdate.CommandType = CommandType.StoredProcedure;
        cmdUpdate.Parameters.AddWithValue("@AcademicYearId", Academicyearid);
        cmdUpdate.Parameters.AddWithValue("@Marks_Id", Marksid);
        cmdUpdate.Parameters.AddWithValue("@LoginUserID", userid);

        if (dbobj.ExecuteNonQuery(cmdUpdate))
        {
            cmdUpdate.Dispose();
            return true;
        }
        else
        {
            cmdUpdate.Dispose();
            return false;
        }
    }

    public DataTable ListPublishedExamDetailsForStudent(string StudentID, int ClassId, int SectionId, int AcademicYearId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("spListPublisedExamDetailsForStudent");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentId", StudentID);
            cmd.Parameters.AddWithValue("@ClassId", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@AcademicYearId", AcademicYearId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { }
    }

    public DataTable GetStudentExamsMarksSummaryReport(int AcademicYearId, int ClassId, int SectionId, string StudentId)
    {
        try
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("spStudentExamsMarksSummaryReport");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AcademicYearId", AcademicYearId);
            cmd.Parameters.AddWithValue("@Class_Id", ClassId);
            cmd.Parameters.AddWithValue("@SectionId", SectionId);
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            dt = dbobj.ExecuteDTQuery(cmd);
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        { }
    }
}
