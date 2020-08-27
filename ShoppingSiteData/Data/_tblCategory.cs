using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ShoppingSiteData.Data
{
	public abstract class _tblCategory
	{
		/// <summary>
		/// Inserts a record into the tblCategorys table.
		/// </summary>
		public static int Create(String _strcategoryName, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@categoryId", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "categoryId", DataRowVersion.Proposed, null),
				new SqlParameter("@categoryName", SqlDbType.VarChar, 250, ParameterDirection.Input, false, 0, 0, "categoryName", DataRowVersion.Proposed, _strcategoryName)
			};


			//Execute the query
			SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblCategorysCreate", parameters);

			// Set the output paramter value(s)
			return (int)parameters[0].Value;
		}

		/// <summary>
		/// Updates a record in the tblCategorys table.
		/// </summary>
		public static bool Update(Int32 _ncategoryId, String _strcategoryName, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@categoryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "categoryId", DataRowVersion.Proposed, _ncategoryId),
				new SqlParameter("@categoryName", SqlDbType.VarChar, 250, ParameterDirection.Input, false, 0, 0, "categoryName", DataRowVersion.Proposed, _strcategoryName)
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblCategorysUpdate", parameters) == 1);
		}

		/// <summary>
		/// Deletes a record from the tblCategorys table by a composite primary key.
		/// </summary>
		public static bool Delete(Int32 _ncategoryId, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@categoryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "categoryId", DataRowVersion.Proposed, _ncategoryId),
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblCategorysDelete", parameters) == 1);
		}

		/// <summary>
		/// Selects all records from the tblCategorys table.
		/// </summary>
		public static DataTable RetrieveList(String connectionString)
		{
			DataTable dtReturn = null;
			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblCategorysRetrieveList"))
			{
				dtReturn = dataSet.Tables[0];
			}
				return dtReturn;
		}

		/// <summary>
		/// Selects a single record from the tblCategorys table.
		/// </summary>
		public static DataRow Retrieve(Int32 _ncategoryId, String connectionString)
		{
			DataRow drReturn = null;
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@categoryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "categoryId", DataRowVersion.Proposed, _ncategoryId)
			};


			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblCategorysRetrieve", parameters))
			{
				drReturn = dataSet.Tables[0].Rows[0];
			}
				return drReturn;
		}
	}
}
