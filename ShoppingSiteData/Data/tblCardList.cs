using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ShoppingSiteData.Data
{
	public class tblCardList:_tblCardList
	{
		private tblCardList() {}


        public static DataTable GetCartList(Int32 userId, String connectionString)
        {
            DataTable dtReturn = null;


            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userId", userId));


            //Create the parameters in the SqlParameter array
            //SqlParameter[] parameters =
            //{
            //    new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, userId)
            //};

            //Execute the query
            using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "spGetCartList",parameters.ToArray()))
            {
                dtReturn = dataSet.Tables[0];
            }
            return dtReturn;
        }
    }
}
