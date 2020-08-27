using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public abstract class _tblCardList
	{
		protected String connectionString;
		protected Int32 m_ncardlistId;
		protected Int32 m_nuserId;
		protected Int32 m_nproductid;
		protected Int32 m_ncount;
		protected String m_strstatus;

		/// <summary>
		/// Instantiates an empty instance of the tblCardList class.
		/// </summary>
		public _tblCardList()
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
		}

		/// <summary>
		/// Instantiates a filled instance of the tblCardList class.
		/// </summary>
		public _tblCardList(Int32 _cardlistId)
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
			DataRow row = Data.tblCardList.Retrieve(_cardlistId, connectionString);
			cardlistId = SqlNullHelper.NullInt32Check(row["cardlistId"]);
			userId = SqlNullHelper.NullInt32Check(row["userId"]);
			productid = SqlNullHelper.NullInt32Check(row["productid"]);
			count = SqlNullHelper.NullInt32Check(row["count"]);
			status = SqlNullHelper.NullStringCheck(row["status"]);
		}

		/// <summary>
		/// Creates an entry of the tblCardList class in the database.
		/// </summary>
		public int Create()
		{
			m_ncardlistId = Data.tblCardList.Create(m_nuserId, m_nproductid, m_ncount, m_strstatus, connectionString);
			return m_ncardlistId;
		}

		/// <summary>
		/// Updates this entry of the tblCardList class in the database.
		/// </summary>
		public bool Update()
		{
			return Data.tblCardList.Update(m_ncardlistId, m_nuserId, m_nproductid, m_ncount, m_strstatus, connectionString);
		}

		/// <summary>
		/// Deletes this entry of the tblCardList class in the database.
		/// </summary>
		public bool Delete()
		{
			return Data.tblCardList.Delete(m_ncardlistId, connectionString);
		}

		/// <summary>
		/// Retrieves a DataTable list of the tblCardList class in the database.
		/// </summary>
		public DataTable GetList()
		{
			return Data.tblCardList.RetrieveList(connectionString);
		}

		public Int32 cardlistId
		{
			get { return m_ncardlistId; }
			set { m_ncardlistId = value; }
		}

		public Int32 userId
		{
			get { return m_nuserId; }
			set { m_nuserId = value; }
		}

		public Int32 productid
		{
			get { return m_nproductid; }
			set { m_nproductid = value; }
		}

		public Int32 count
		{
			get { return m_ncount; }
			set { m_ncount = value; }
		}

		public String status
		{
			get { return m_strstatus; }
			set { m_strstatus = value; }
		}

	}
}
