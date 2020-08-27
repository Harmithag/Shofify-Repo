using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ShoppingSiteData.Data
{
	public abstract class _tblUser
	{
		/// <summary>
		/// Inserts a record into the tblUsers table.
		/// </summary>
		public static int Create(String _strname, String _stremail, String _strphoneNumber, String _strpassword, String _strrole, DateTime _dtcreatedDate, Boolean _bisDeleted, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "userId", DataRowVersion.Proposed, null),
				new SqlParameter("@name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "name", DataRowVersion.Proposed, _strname),
				new SqlParameter("@email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "email", DataRowVersion.Proposed, _stremail),
				new SqlParameter("@phoneNumber", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "phoneNumber", DataRowVersion.Proposed, _strphoneNumber),
				new SqlParameter("@password", SqlDbType.VarChar, 250, ParameterDirection.Input, false, 0, 0, "password", DataRowVersion.Proposed, _strpassword),
				new SqlParameter("@role", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "role", DataRowVersion.Proposed, _strrole),
				new SqlParameter("@createdDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "createdDate", DataRowVersion.Proposed, _dtcreatedDate),
				new SqlParameter("@isDeleted", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "isDeleted", DataRowVersion.Proposed, _bisDeleted)
			};


			//Execute the query
			SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblUsersCreate", parameters);

			// Set the output paramter value(s)
			return (int)parameters[0].Value;
		}

		/// <summary>
		/// Updates a record in the tblUsers table.
		/// </summary>
		public static bool Update(Int32 _nuserId, String _strname, String _stremail, String _strphoneNumber, String _strpassword, String _strrole, DateTime _dtcreatedDate, Boolean _bisDeleted, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, _nuserId),
				new SqlParameter("@name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "name", DataRowVersion.Proposed, _strname),
				new SqlParameter("@email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "email", DataRowVersion.Proposed, _stremail),
				new SqlParameter("@phoneNumber", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "phoneNumber", DataRowVersion.Proposed, _strphoneNumber),
				new SqlParameter("@password", SqlDbType.VarChar, 250, ParameterDirection.Input, false, 0, 0, "password", DataRowVersion.Proposed, _strpassword),
				new SqlParameter("@role", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "role", DataRowVersion.Proposed, _strrole),
				new SqlParameter("@createdDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "createdDate", DataRowVersion.Proposed, _dtcreatedDate),
				new SqlParameter("@isDeleted", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "isDeleted", DataRowVersion.Proposed, _bisDeleted)
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblUsersUpdate", parameters) == 1);
		}

		/// <summary>
		/// Deletes a record from the tblUsers table by a composite primary key.
		/// </summary>
		public static bool Delete(Int32 _nuserId, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, _nuserId),
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblUsersDelete", parameters) == 1);
		}

		/// <summary>
		/// Selects all records from the tblUsers table.
		/// </summary>
		public static DataTable RetrieveList(String connectionString)
		{
			DataTable dtReturn = null;
			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblUsersRetrieveList"))
			{
				dtReturn = dataSet.Tables[0];
			}
				return dtReturn;
		}

		/// <summary>
		/// Selects a single record from the tblUsers table.
		/// </summary>
		public static DataRow Retrieve(Int32 _nuserId, String connectionString)
		{
			DataRow drReturn = null;
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, _nuserId)
			};


			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblUsersRetrieve", parameters))
			{
				drReturn = dataSet.Tables[0].Rows[0];
			}
				return drReturn;
		}
	}
}
