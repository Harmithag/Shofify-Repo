using System;
using System.Data;

using ShoppingSiteData;

namespace ShoppingSiteData
{
	public class tblDeliveryAddress:_tblDeliveryAddress
	{
		/// <summary>
		/// Instantiates an empty instance of the tblDeliveryAddress class.
		/// </summary>
		public tblDeliveryAddress():base()
		{
		}

		/// <summary>
		/// Instantiates a filled instance of the tblDeliveryAddress class.
		/// </summary>
		public tblDeliveryAddress(Int32 _deliveryId):base( _deliveryId)
		{
		}

	}
}
