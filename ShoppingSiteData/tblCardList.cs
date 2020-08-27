using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public class tblCardList:_tblCardList
	{
		/// <summary>
		/// Instantiates an empty instance of the tblCardList class.
		/// </summary>
		public tblCardList():base()
		{
		}

		/// <summary>
		/// Instantiates a filled instance of the tblCardList class.
		/// </summary>
		public tblCardList(Int32 _cardlistId):base( _cardlistId)
		{
		}



		/// <summary>
		/// Updates this entry of the card class in the database.
		/// </summary>
		public DataTable GetCartList(int UserId)
		{
			DataTable data = Data.tblCardList.GetCartList(UserId, connectionString);

			return data;
		}

		
	}
}
