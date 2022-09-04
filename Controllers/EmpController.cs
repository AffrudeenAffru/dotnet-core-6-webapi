using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text.Json;

using Microsoft.AspNetCore.Cors;
namespace Emp.Controllers
{


      //  [Route("api/[Controller]")]
            [ApiController]
            public class EMpController : ControllerBase
            {
            private readonly IConfiguration _configuratin;
            public EMpController(IConfiguration configuration)
            {
                _configuratin=configuration;
            }
          #region to get all employye from db

            [HttpGet]

            [Route("GetItems")]
          public List<EmpModal> GetItems(){
         
            DBClayers obj=new DBClayers();
            obj.Loadallemp();
                       

           return   obj.Loadallemp();;
          }

          #endregion
          #region to get emp by id

            [HttpGet]
            [Route("GetItemsbyid")]
            public List<EmpModal> GetItemsbyid(string empid)
              {
    
                DBClayers obj=new DBClayers();
                obj.Loadallemp();
                return   obj.Load_one_emp(empid);
              }

          #endregion
         
          #region to delete one emp from db
          
          [HttpDelete]
            [Route("delebyid")]
            public  string delebyid (string empid)
              {
    
                DBClayers obj=new DBClayers();
                obj.Loadallemp();
                
                return   obj.delete_emp_byid(empid);;
              }

     
         #endregion
           #region to add one emp to db
              [HttpPost]
              [Route("createnew")]
            public  string create_new (EmpModal  aa)
              {
    
                DBClayers obj=new DBClayers();
                obj.Loadallemp() ;
                
                return   obj.insert_new_employee(aa.DEPARTMENT,
                                                  aa.FIRST_NAME,
                                                  aa.LAST_NAME,
                                                  aa.SALARY,
                                                  aa.JOINING_DATE);
              }

     
         #endregion

        }
        
    }
    
    



