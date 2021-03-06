﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DevDataControl
{
    public class FrmObjectDataSourceClass
    {
        public SqlDataReader GetMemos()
        {
            SqlConnection objCon = new SqlConnection();
            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["DevADONETConnectionString"].ConnectionString;
            objCon.Open();

            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objCon;
            objCmd.CommandText = "ListMemo";
            objCmd.CommandType = CommandType.StoredProcedure;

            return objCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}