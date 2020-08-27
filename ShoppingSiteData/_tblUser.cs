using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public abstract class _tblUser
	{
		protected String connectionString;
		protected Int32 m_nuserId;
		protected String m_strname;
		protected String m_stremail;
		protected String m_strphoneNumber;
		protected String m_strpassword;
		protected String m_strrole;
		protected DateTime m_dtcreatedDate;
		protected Boolean m_bisDeleted;

		/// <summary>
		/// Instantiates an empty instance of the tblUser class.
		/// </summary>
		public _tblUser()
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
		}

		/// <summary>
		/// Instantiates a filled instance of the tblUser class.
		/// </summary>
		public _tblUser(Int32 _userId)
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
			DataRow row = Data.tblUser.Retrieve(_userId, connectionString);
			userId = SqlNullHelper.NullInt32Check(row["userId"]);
			name = SqlNullHelper.NullStringCheck(row["name"]);
			email = SqlNullHelper.NullStringCheck(row["email"]);
			phoneNumber = SqlNullHelper.NullStringCheck(row["phoneNumber"]);
			password = SqlNullHelper.NullStringCheck(row["password"]);
			role = SqlNullHelper.NullStringCheck(row["role"]);
			createdDate = Conversion.ConvertToDate(row["createdDate"]);
			isDeleted = SqlNullHelper.NullBooleanCheck(row["isDeleted"]);
		}

		/// <summary>
		/// Creates an entry of the tblUser class in the database.
		/// </summary>
		public int Create()
		{
			m_nuserId = Data.tblUser.Create(m_strname, m_stremail, m_strphoneNumber, m_strpassword, m_strrole, m_dtcreatedDate, m_bisDeleted, connectionString);
			return m_nuserId;
		}

		/// <summary>
		/// Updates this entry of the tblUser class in the database.
		/// </summary>
		public bool Update()
		{
			return Data.tblUser.Update(m_nuserId, m_strname, m_stremail, m_strphoneNumber, m_strpassword, m_strrole, m_dtcreatedDate, m_bisDeleted, connectionString);
		}

		/// <summary>
		/// Deletes this entry of the tblUser class in the database.
		/// </summary>
		public bool Delete()
		{
			return Data.tblUser.Delete(m_nuserId, connectionString);
		}

		/// <summary>
		/// Retrieves a DataTable list of the tblUser class in the database.
		/// </summary>
		public DataTable GetList()
		{
			return Data.tblUser.RetrieveList(connectionString);
		}

		public Int32 userId
		{
			get { return m_nuserId; }
			set { m_nuserId = value; }
		}

		public String name
		{
			get { return m_strname; }
			set { m_strname = value; }
		}

		public String email
		{
			get { return m_stremail; }
			set { m_stremail = value; }
		}

		public String phoneNumber
		{
			get { return m_strphoneNumber; }
			set { m_strphoneNumber = value; }
		}

		public String password
		{
			get { return m_strpassword; }
			set { m_strpassword = value; }
		}

		public String role
		{
			get { return m_strrole; }
			set { m_strrole = value; }
		}

		public DateTime createdDate
		{
			get { return m_dtcreatedDate; }
			set { m_dtcreatedDate = value; }
		}

		public Boolean isDeleted
		{
			get { return m_bisDeleted; }
			set { m_bisDeleted = value; }
		}

	}
}
