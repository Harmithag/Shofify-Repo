using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ShoppingSiteData.Data
{
	public abstract class _tblCardList
	{
		/// <summary>
		/// Inserts a record into the tblCardLists table.
		/// </summary>
		public static int Create(Int32 _nuserId, Int32 _nproductid, Int32 _ncount, String _strstatus, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@cardlistId", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "cardlistId", DataRowVersion.Proposed, null),
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, _nuserId),
				new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "productid", DataRowVersion.Proposed, _nproductid),
				new SqlParameter("@count", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "count", DataRowVersion.Proposed, _ncount),
				new SqlParameter("@status", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "status", DataRowVersion.Proposed, _strstatus)
			};


			//Execute the query
			SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblCardListsCreate", parameters);

			// Set the output paramter value(s)
			return (int)parameters[0].Value;
		}

		/// <summary>
		/// Updates a record in the tblCardLists table.
		/// </summary>
		public static bool Update(Int32 _ncardlistId, Int32 _nuserId, Int32 _nproductid, Int32 _ncount, String _strstatus, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@cardlistId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "cardlistId", DataRowVersion.Proposed, _ncardlistId),
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, _nuserId),
				new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "productid", DataRowVersion.Proposed, _nproductid),
				new SqlParameter("@count", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "count", DataRowVersion.Proposed, _ncount),
				new SqlParameter("@status", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "status", DataRowVersion.Proposed, _strstatus)
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblCardListsUpdate", parameters) == 1);
		}

		/// <summary>
		/// Deletes a record from the tblCardLists table by a composite primary key.
		/// </summary>
		public static bool Delete(Int32 _ncardlistId, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@cardlistId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "cardlistId", DataRowVersion.Proposed, _ncardlistId),
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblCardListsDelete", parameters) == 1);
		}

		/// <summary>
		/// Selects all records from the tblCardLists table.
		/// </summary>
		public static DataTable RetrieveList(String connectionString)
		{
			DataTable dtReturn = null;
			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblCardListsRetrieveList"))
			{
				dtReturn = dataSet.Tables[0];
			}
				return dtReturn;
		}

		/// <summary>
		/// Selects a single record from the tblCardLists table.
		/// </summary>
		public static DataRow Retrieve(Int32 _ncardlistId, String connectionString)
		{
			DataRow drReturn = null;
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@cardlistId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "cardlistId", DataRowVersion.Proposed, _ncardlistId)
			};


			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblCardListsRetrieve", parameters))
			{
				drReturn = dataSet.Tables[0].Rows[0];
			}
				return drReturn;
		}
	}
}
