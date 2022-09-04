using System;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
 namespace  Emp.Controllers

{
    
public class DBClayers
{
  #region to fetch all emp from db

       public  List<EmpModal>Loadallemp()
            {
              List<EmpModal> listodemp=new List<EmpModal>();
               using (SqlConnection conn = new SqlConnection(@"server=CLAP993;Initial Catalog=DBCompany;User Id=sa;Password=Affru1289@"))                { 
                   DataTable dt = new DataTable(); 
                   conn.Open(); 
                 
                   using (SqlCommand cmd = new SqlCommand(Stored_procedure.feth_all_from_db, conn)) 
                   { 
                      SqlDataAdapter da = new SqlDataAdapter(cmd); 
                       da.Fill(dt); 
                       conn.Close();
                         foreach (DataRow dr in dt.Rows) 
                        { 
                             listodemp.Add
                             ( 
                                 new EmpModal 
                                  {
                                    EMPLOYEE_ID = Convert.ToInt32(dr["EMPLOYEE_ID"]), 
                                    FIRST_NAME = Convert.ToString(dr["FIRST_NAME"]), 
                                    LAST_NAME = Convert.ToString(dr["LAST_NAME"]), 
                                    SALARY = Convert.ToInt32(dr["SALARY"]), 
                                    JOINING_DATE = Convert.ToString(dr["JOINING_DATE"]), 
                                    DEPARTMENT = Convert.ToString(dr["DEPARTMENT"]), 
                                  } 
                                );  
                        } 
                       
                        return listodemp;
                    }
                }
            }
     #endregion
  #region to load one emp from db
    public  List<EmpModal>Load_one_emp(string empid)
            {
              List<EmpModal> listodemp=new List<EmpModal>();
               using (SqlConnection conn = new SqlConnection(@"server=CLAP993;Initial Catalog=DBCompany;User Id=sa;Password=Affru1289@"))                { 
                   DataTable dt = new DataTable(); 
                   conn.Open(); 
                 
                   using (SqlCommand cmd = new SqlCommand(Stored_procedure.feth_one_from_db, conn)) 
                   { 
                   
                       cmd.Parameters.AddWithValue("@empid",empid);
                      SqlDataAdapter da = new SqlDataAdapter(cmd); 
                       da.Fill(dt); 
                       conn.Close();
                         foreach (DataRow dr in dt.Rows) 
                        { 
                             listodemp.Add
                             ( 
                                 new EmpModal 
                                  {
                                    EMPLOYEE_ID = Convert.ToInt32(dr["EMPLOYEE_ID"]), 
                                    FIRST_NAME = Convert.ToString(dr["FIRST_NAME"]), 
                                    LAST_NAME = Convert.ToString(dr["LAST_NAME"]), 
                                    SALARY = Convert.ToInt32(dr["SALARY"]), 
                                    JOINING_DATE = Convert.ToString(dr["JOINING_DATE"]), 
                                    DEPARTMENT = Convert.ToString(dr["DEPARTMENT"]), 
                                  } 
                                ); 
                        } 
                        return listodemp;
                    }
                }
            }
  #endregion
  #region to delete one emp from db 
    public string delete_emp_byid(string empid)
            {
              List<EmpModal> listodemp=new List<EmpModal>();
                  using (SqlConnection conn = new SqlConnection(@"server=CLAP993;Initial Catalog=DBCompany;User Id=sa;Password=Affru1289@"))                { 
                 
              
                 
                   using (SqlCommand cmd = new SqlCommand(Stored_procedure.delet_one_from_db, conn)) 
                   { 
                   
                   
                       cmd.Parameters.AddWithValue("@empid",empid);
                  conn.Open();
                  cmd.ExecuteNonQuery();
                  conn.Close();
                       
                     
                        return "The employee has been deleted sucessfyly11";
                    }
                }
            }
#endregion
  #region insert new employee
 public string insert_new_employee( string DEPARTMENT, string FIRST_NAME,string LAST_NAME, int SALARY,string JOINING_DATE)
            {
              List<EmpModal> listodemp=new List<EmpModal>();
                  using (SqlConnection conn = new SqlConnection(@"server=CLAP993;Initial Catalog=DBCompany;User Id=sa;Password=Affru1289@"))                { 
                 
              
                 
                   using (SqlCommand cmd = new SqlCommand(Stored_procedure.insert_one_to_db, conn)) 
                   { 
                   
                   
                       cmd.Parameters.AddWithValue("@fName",FIRST_NAME);
                       cmd.Parameters.AddWithValue("@Laname",LAST_NAME);
                       cmd.Parameters.AddWithValue("@sal",SALARY);
                       cmd.Parameters.AddWithValue("@date",JOINING_DATE);
                       cmd.Parameters.AddWithValue("@dept",DEPARTMENT);
                     
                      conn.Open();
                  cmd.ExecuteNonQuery();
                  conn.Close();
                       
                     
                        return "The employee has been inserted  sucessfyly11";
                    }
                }
            }
#endregion


}
    
}