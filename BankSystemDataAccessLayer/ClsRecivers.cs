﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class ClsRecivers
    {
        public static DataTable GetAllRecivers(int PageNumber)
        {
            DataTable AllCLients = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsSettings.connectionString))
            {
                try
                {
                    string Query = "exec [SP_GetAllRecivers] @PageNumber";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@PageNumber", PageNumber);
                        connection.Open();

                        using (SqlDataReader READER = command.ExecuteReader())
                        {
                            AllCLients.Load(READER);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ClsSettings.ErrorsToEventLog(ex);
                }
            }
            return AllCLients;
        }

    }
}
