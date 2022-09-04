using System;
 namespace Emp.Controllers

 {
     public static class Stored_procedure
     {
        public const String feth_all_from_db ="select * from Employee  ";//to fethc all employyess from database table
        public const String feth_one_from_db ="select * from Employee  where EMPLOYEE_ID =@empid";//to fethc one employee from database table
        public const String delet_one_from_db ="delete from  Employee  where EMPLOYEE_ID =@empid";//to delete  one  employee  from database table
        public const String insert_one_to_db ="insert into Employee values (@fName,@Laname,@sal,@date,@dept)";//to delete  one  employee  from database table

   
     }
 }

