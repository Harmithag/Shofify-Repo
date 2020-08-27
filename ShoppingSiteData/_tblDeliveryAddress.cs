using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public abstract class _tblDeliveryAddress
	{
		protected String connectionString;
		protected Int32 m_ndeliveryId;
		protected Int32 m_nuserId;
		protected Int32 m_ncardlistid;
		protected String m_straddress1;
		protected String m_straddress2;
		protected String m_strzipCode;
		protected String m_strphoneNumber;
		protected String m_stremail;
		protected Boolean m_bisActive;

		/// <summary>
		/// Instantiates an empty instance of the tblDeliveryAddress class.
		/// </summary>
		public _tblDeliveryAddress()
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
		}

		/// <summary>
		/// Instantiates a filled instance of the tblDeliveryAddress class.
		/// </summary>
		public _tblDeliveryAddress(Int32 _deliveryId)
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
			DataRow row = Data.tblDeliveryAddress.Retrieve(_deliveryId, connectionString);
			deliveryId = SqlNullHelper.NullInt32Check(row["deliveryId"]);
			userId = SqlNullHelper.NullInt32Check(row["userId"]);
			cardlistid = SqlNullHelper.NullInt32Check(row["cardlistid"]);
			address1 = SqlNullHelper.NullStringCheck(row["address1"]);
			address2 = SqlNullHelper.NullStringCheck(row["address2"]);
			zipCode = SqlNullHelper.NullStringCheck(row["zipCode"]);
			phoneNumber = SqlNullHelper.NullStringCheck(row["phoneNumber"]);
			email = SqlNullHelper.NullStringCheck(row["email"]);
			isActive = SqlNullHelper.NullBooleanCheck(row["isActive"]);
		}

		/// <summary>
		/// Creates an entry of the tblDeliveryAddress class in the database.
		/// </summary>
		public int Create()
		{
			m_ndeliveryId = Data.tblDeliveryAddress.Create(m_nuserId, m_ncardlistid, m_straddress1, m_straddress2, m_strzipCode, m_strphoneNumber, m_stremail, m_bisActive, connectionString);
			return m_ndeliveryId;
		}

		/// <summary>
		/// Updates this entry of the tblDeliveryAddress class in the database.
		/// </summary>
		public bool Update()
		{
			return Data.tblDeliveryAddress.Update(m_ndeliveryId, m_nuserId, m_ncardlistid, m_straddress1, m_straddress2, m_strzipCode, m_strphoneNumber, m_stremail, m_bisActive, connectionString);
		}

		/// <summary>
		/// Deletes this entry of the tblDeliveryAddress class in the database.
		/// </summary>
		public bool Delete()
		{
			return Data.tblDeliveryAddress.Delete(m_ndeliveryId, connectionString);
		}

		/// <summary>
		/// Retrieves a DataTable list of the tblDeliveryAddress class in the database.
		/// </summary>
		public DataTable GetList()
		{
			return Data.tblDeliveryAddress.RetrieveList(connectionString);
		}

		public Int32 deliveryId
		{
			get { return m_ndeliveryId; }
			set { m_ndeliveryId = value; }
		}

		public Int32 userId
		{
			get { return m_nuserId; }
			set { m_nuserId = value; }
		}

		public Int32 cardlistid
		{
			get { return m_ncardlistid; }
			set { m_ncardlistid = value; }
		}

		public String address1
		{
			get { return m_straddress1; }
			set { m_straddress1 = value; }
		}

		public String address2
		{
			get { return m_straddress2; }
			set { m_straddress2 = value; }
		}

		public String zipCode
		{
			get { return m_strzipCode; }
			set { m_strzipCode = value; }
		}

		public String phoneNumber
		{
			get { return m_strphoneNumber; }
			set { m_strphoneNumber = value; }
		}

		public String email
		{
			get { return m_stremail; }
			set { m_stremail = value; }
		}

		public Boolean isActive
		{
			get { return m_bisActive; }
			set { m_bisActive = value; }
		}

	}
}
