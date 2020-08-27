using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public abstract class _tblProduct
	{
		protected String connectionString;
		protected Int32 m_nproductId;
		protected String m_strproductName;
		protected String m_strbrandName;
		protected String m_strimageurl;
		protected String m_strproductDetails;
		protected Int32 m_ncategoryId;
		protected Decimal m_decPrice;
		protected DateTime m_dtcreatedDate;

		/// <summary>
		/// Instantiates an empty instance of the tblProduct class.
		/// </summary>
		public _tblProduct()
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
		}

		/// <summary>
		/// Instantiates a filled instance of the tblProduct class.
		/// </summary>
		public _tblProduct(Int32 _productId)
		{
			connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
			DataRow row = Data.tblProduct.Retrieve(_productId, connectionString);
			productId = SqlNullHelper.NullInt32Check(row["productId"]);
			productName = SqlNullHelper.NullStringCheck(row["productName"]);
			brandName = SqlNullHelper.NullStringCheck(row["brandName"]);
			imageurl = SqlNullHelper.NullStringCheck(row["imageurl"]);
			productDetails = SqlNullHelper.NullStringCheck(row["productDetails"]);
			categoryId = SqlNullHelper.NullInt32Check(row["categoryId"]);
			Price = SqlNullHelper.NullDecimalCheck(row["Price"]);
			createdDate = Conversion.ConvertToDate(row["createdDate"]);
		}

		/// <summary>
		/// Creates an entry of the tblProduct class in the database.
		/// </summary>
		public int Create()
		{
			m_nproductId = Data.tblProduct.Create(m_strproductName, m_strbrandName, m_strimageurl, m_strproductDetails, m_ncategoryId, m_decPrice, m_dtcreatedDate, connectionString);
			return m_nproductId;
		}

		/// <summary>
		/// Updates this entry of the tblProduct class in the database.
		/// </summary>
		public bool Update()
		{
			return Data.tblProduct.Update(m_nproductId, m_strproductName, m_strbrandName, m_strimageurl, m_strproductDetails, m_ncategoryId, m_decPrice, m_dtcreatedDate, connectionString);
		}

		/// <summary>
		/// Deletes this entry of the tblProduct class in the database.
		/// </summary>
		public bool Delete()
		{
			return Data.tblProduct.Delete(m_nproductId, connectionString);
		}

		/// <summary>
		/// Retrieves a DataTable list of the tblProduct class in the database.
		/// </summary>
		public DataTable GetList()
		{
			return Data.tblProduct.RetrieveList(connectionString);
		}

		public Int32 productId
		{
			get { return m_nproductId; }
			set { m_nproductId = value; }
		}

		public String productName
		{
			get { return m_strproductName; }
			set { m_strproductName = value; }
		}

		public String brandName
		{
			get { return m_strbrandName; }
			set { m_strbrandName = value; }
		}

		public String imageurl
		{
			get { return m_strimageurl; }
			set { m_strimageurl = value; }
		}

		public String productDetails
		{
			get { return m_strproductDetails; }
			set { m_strproductDetails = value; }
		}

		public Int32 categoryId
		{
			get { return m_ncategoryId; }
			set { m_ncategoryId = value; }
		}

		public Decimal Price
		{
			get { return m_decPrice; }
			set { m_decPrice = value; }
		}

		public DateTime createdDate
		{
			get { return m_dtcreatedDate; }
			set { m_dtcreatedDate = value; }
		}

	}
}
