using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public class tblCategory:_tblCategory
	{
		/// <summary>
		/// Instantiates an empty instance of the tblCategory class.
		/// </summary>
		public tblCategory():base()
		{
		}

		/// <summary>
		/// Instantiates a filled instance of the tblCategory class.
		/// </summary>
		public tblCategory(Int32 _categoryId):base( _categoryId)
		{
		}

	}
}
