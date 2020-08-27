using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public class tblProduct:_tblProduct
	{
		/// <summary>
		/// Instantiates an empty instance of the tblProduct class.
		/// </summary>
		public tblProduct():base()
		{
		}

		/// <summary>
		/// Instantiates a filled instance of the tblProduct class.
		/// </summary>
		public tblProduct(Int32 _productId):base( _productId)
		{
		}

	}
}
