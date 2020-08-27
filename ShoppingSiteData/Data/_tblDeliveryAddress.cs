using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ShoppingSiteData.Data
{
	public abstract class _tblDeliveryAddress
	{
		/// <summary>
		/// Inserts a record into the tblDeliveryAddresss table.
		/// </summary>
		public static int Create(Int32 _nuserId, Int32 _ncardlistid, String _straddress1, String _straddress2, String _strzipCode, String _strphoneNumber, String _stremail, Boolean _bisActive, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@deliveryId", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "deliveryId", DataRowVersion.Proposed, null),
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, _nuserId),
				new SqlParameter("@cardlistid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "cardlistid", DataRowVersion.Proposed, _ncardlistid),
				new SqlParameter("@address1", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "address1", DataRowVersion.Proposed, _straddress1),
				new SqlParameter("@address2", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "address2", DataRowVersion.Proposed, _straddress2),
				new SqlParameter("@zipCode", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "zipCode", DataRowVersion.Proposed, _strzipCode),
				new SqlParameter("@phoneNumber", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "phoneNumber", DataRowVersion.Proposed, _strphoneNumber),
				new SqlParameter("@email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "email", DataRowVersion.Proposed, _stremail),
				new SqlParameter("@isActive", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "isActive", DataRowVersion.Proposed, _bisActive)
			};


			//Execute the query
			SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblDeliveryAddresssCreate", parameters);

			// Set the output paramter value(s)
			return (int)parameters[0].Value;
		}

		/// <summary>
		/// Updates a record in the tblDeliveryAddresss table.
		/// </summary>
		public static bool Update(Int32 _ndeliveryId, Int32 _nuserId, Int32 _ncardlistid, String _straddress1, String _straddress2, String _strzipCode, String _strphoneNumber, String _stremail, Boolean _bisActive, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@deliveryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "deliveryId", DataRowVersion.Proposed, _ndeliveryId),
				new SqlParameter("@userId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "userId", DataRowVersion.Proposed, _nuserId),
				new SqlParameter("@cardlistid", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "cardlistid", DataRowVersion.Proposed, _ncardlistid),
				new SqlParameter("@address1", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "address1", DataRowVersion.Proposed, _straddress1),
				new SqlParameter("@address2", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "address2", DataRowVersion.Proposed, _straddress2),
				new SqlParameter("@zipCode", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "zipCode", DataRowVersion.Proposed, _strzipCode),
				new SqlParameter("@phoneNumber", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "phoneNumber", DataRowVersion.Proposed, _strphoneNumber),
				new SqlParameter("@email", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "email", DataRowVersion.Proposed, _stremail),
				new SqlParameter("@isActive", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "isActive", DataRowVersion.Proposed, _bisActive)
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblDeliveryAddresssUpdate", parameters) == 1);
		}

		/// <summary>
		/// Deletes a record from the tblDeliveryAddresss table by a composite primary key.
		/// </summary>
		public static bool Delete(Int32 _ndeliveryId, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@deliveryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "deliveryId", DataRowVersion.Proposed, _ndeliveryId),
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblDeliveryAddresssDelete", parameters) == 1);
		}

		/// <summary>
		/// Selects all records from the tblDeliveryAddresss table.
		/// </summary>
		public static DataTable RetrieveList(String connectionString)
		{
			DataTable dtReturn = null;
			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblDeliveryAddresssRetrieveList"))
			{
				dtReturn = dataSet.Tables[0];
			}
				return dtReturn;
		}

		/// <summary>
		/// Selects a single record from the tblDeliveryAddresss table.
		/// </summary>
		public static DataRow Retrieve(Int32 _ndeliveryId, String connectionString)
		{
			DataRow drReturn = null;
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@deliveryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "deliveryId", DataRowVersion.Proposed, _ndeliveryId)
			};


			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblDeliveryAddresssRetrieve", parameters))
			{
				drReturn = dataSet.Tables[0].Rows[0];
			}
				return drReturn;
		}
	}
}
