using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public class tblUser:_tblUser
	{
		/// <summary>
		/// Instantiates an empty instance of the tblUser class.
		/// </summary>
		public tblUser():base()
		{
		}

		/// <summary>
		/// Instantiates a filled instance of the tblUser class.
		/// </summary>
		public tblUser(Int32 _userId):base( _userId)
		{
		}

	}
}
