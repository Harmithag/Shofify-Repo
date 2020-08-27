using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public abstract class _tblCategory
	{
		protected String connectionString;
		protected Int32 m_ncategoryId;
		protected String m_strcategoryName;

		/// <summary>
		/// Instantiates an empty instance of the tblCategory class.
		/// </summary>
		public _tblCategory()
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
		}

		/// <summary>
		/// Instantiates a filled instance of the tblCategory class.
		/// </summary>
		public _tblCategory(Int32 _categoryId)
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
			DataRow row = Data.tblCategory.Retrieve(_categoryId, connectionString);
			categoryId = SqlNullHelper.NullInt32Check(row["categoryId"]);
			categoryName = SqlNullHelper.NullStringCheck(row["categoryName"]);
		}

		/// <summary>
		/// Creates an entry of the tblCategory class in the database.
		/// </summary>
		public int Create()
		{
			m_ncategoryId = Data.tblCategory.Create(m_strcategoryName, connectionString);
			return m_ncategoryId;
		}

		/// <summary>
		/// Updates this entry of the tblCategory class in the database.
		/// </summary>
		public bool Update()
		{
			return Data.tblCategory.Update(m_ncategoryId, m_strcategoryName, connectionString);
		}

		/// <summary>
		/// Deletes this entry of the tblCategory class in the database.
		/// </summary>
		public bool Delete()
		{
			return Data.tblCategory.Delete(m_ncategoryId, connectionString);
		}

		/// <summary>
		/// Retrieves a DataTable list of the tblCategory class in the database.
		/// </summary>
		public DataTable GetList()
		{
			return Data.tblCategory.RetrieveList(connectionString);
		}

		public Int32 categoryId
		{
			get { return m_ncategoryId; }
			set { m_ncategoryId = value; }
		}

		public String categoryName
		{
			get { return m_strcategoryName; }
			set { m_strcategoryName = value; }
		}

	}
}
