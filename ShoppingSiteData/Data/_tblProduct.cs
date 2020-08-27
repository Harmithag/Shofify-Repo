using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace ShoppingSiteData.Data
{
	public abstract class _tblProduct
	{
		/// <summary>
		/// Inserts a record into the tblProducts table.
		/// </summary>
		public static int Create(String _strproductName, String _strbrandName, String _strimageurl, String _strproductDetails, Int32 _ncategoryId, Decimal _decPrice, DateTime _dtcreatedDate, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@productId", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "productId", DataRowVersion.Proposed, null),
				new SqlParameter("@productName", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "productName", DataRowVersion.Proposed, _strproductName),
				new SqlParameter("@brandName", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "brandName", DataRowVersion.Proposed, _strbrandName),
				new SqlParameter("@imageurl", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "imageurl", DataRowVersion.Proposed, _strimageurl),
				new SqlParameter("@productDetails", SqlDbType.VarChar, 250, ParameterDirection.Input, false, 0, 0, "productDetails", DataRowVersion.Proposed, _strproductDetails),
				new SqlParameter("@categoryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "categoryId", DataRowVersion.Proposed, _ncategoryId),
				new SqlParameter("@Price", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "Price", DataRowVersion.Proposed, _decPrice),
				new SqlParameter("@createdDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "createdDate", DataRowVersion.Proposed, _dtcreatedDate)
			};


			//Execute the query
			SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblProductsCreate", parameters);

			// Set the output paramter value(s)
			return (int)parameters[0].Value;
		}

		/// <summary>
		/// Updates a record in the tblProducts table.
		/// </summary>
		public static bool Update(Int32 _nproductId, String _strproductName, String _strbrandName, String _strimageurl, String _strproductDetails, Int32 _ncategoryId, Decimal _decPrice, DateTime _dtcreatedDate, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@productId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "productId", DataRowVersion.Proposed, _nproductId),
				new SqlParameter("@productName", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "productName", DataRowVersion.Proposed, _strproductName),
				new SqlParameter("@brandName", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "brandName", DataRowVersion.Proposed, _strbrandName),
				new SqlParameter("@imageurl", SqlDbType.VarChar, 25, ParameterDirection.Input, false, 0, 0, "imageurl", DataRowVersion.Proposed, _strimageurl),
				new SqlParameter("@productDetails", SqlDbType.VarChar, 250, ParameterDirection.Input, false, 0, 0, "productDetails", DataRowVersion.Proposed, _strproductDetails),
				new SqlParameter("@categoryId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "categoryId", DataRowVersion.Proposed, _ncategoryId),
				new SqlParameter("@Price", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "Price", DataRowVersion.Proposed, _decPrice),
				new SqlParameter("@createdDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "createdDate", DataRowVersion.Proposed, _dtcreatedDate)
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblProductsUpdate", parameters) == 1);
		}

		/// <summary>
		/// Deletes a record from the tblProducts table by a composite primary key.
		/// </summary>
		public static bool Delete(Int32 _nproductId, String connectionString)
		{
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@productId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "productId", DataRowVersion.Proposed, _nproductId),
			};


			//Execute the query
			return (SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "tblProductsDelete", parameters) == 1);
		}

		/// <summary>
		/// Selects all records from the tblProducts table.
		/// </summary>
		public static DataTable RetrieveList(String connectionString)
		{
			DataTable dtReturn = null;
			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblProductsRetrieveList"))
			{
				dtReturn = dataSet.Tables[0];
			}
				return dtReturn;
		}

		/// <summary>
		/// Selects a single record from the tblProducts table.
		/// </summary>
		public static DataRow Retrieve(Int32 _nproductId, String connectionString)
		{
			DataRow drReturn = null;
			//Create the parameters in the SqlParameter array
			SqlParameter[] parameters =
			{
				new SqlParameter("@productId", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "productId", DataRowVersion.Proposed, _nproductId)
			};


			//Execute the query
			using (DataSet dataSet = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, "tblProductsRetrieve", parameters))
			{
				drReturn = dataSet.Tables[0].Rows[0];
			}
				return drReturn;
		}
	}
}
