using System;

namespace ShoppingSiteData
{
	/// <summary>
	/// Conversion utilities
	/// </summary>
	public class Conversion
	{

#region Construction

		/// <summary>
		/// Can't instantiate.
		/// </summary>
		private Conversion()
		{
		}

#endregion

#region Conversions

		/// <summary>
		/// Convert the string date into a DateTime.
		/// </summary>
		/// <param name="_strDate">Date to convert</param>
		/// <returns>Converted DateTime</returns>
		public static DateTime ConvertToDate( String _strDate )
		{
			DateTime dtReturn = System.DateTime.MinValue;

			try
			{
				dtReturn = Convert.ToDateTime( _strDate );
			}
			catch ( Exception )
			{
			}

			return( dtReturn );
		}

		/// <summary>
		/// Convert the string date into a DateTime.
		/// </summary>
		/// <param name="_objDate">Date to convert</param>
		/// <returns>Converted DateTime</returns>
		public static DateTime ConvertToDate( Object _objDate )
		{
			DateTime dtReturn = System.DateTime.MinValue;

			try
			{
				dtReturn = Convert.ToDateTime( _objDate );
			}
			catch ( Exception )
			{
			}

			return( dtReturn );
		}

		/// <summary>
		/// Convert to Int32
		/// </summary>
		/// <param name="_strValue">Value to convert</param>
		/// <returns>Converted Int32</returns>
		public static Int32 ConvertToInt32( String _strValue )
		{
			Int32 nReturn = 0;

			try
			{
				nReturn = Convert.ToInt32( _strValue );
			}
			catch ( Exception )
			{
			}

			return( nReturn );
		}

		/// <summary>
		/// Convert to Int32
		/// </summary>
		/// <param name="_oValue">Value to convert</param>
		/// <returns>Converted Int32</returns>
		public static Int32 ConvertToInt32( Object _oValue )
		{
			Int32 nReturn = 0;

			try
			{
				if( _oValue != null )
					nReturn = Convert.ToInt32( _oValue );
			}
			catch ( Exception )
			{
			}

			return( nReturn );
		}

		/// <summary>
		/// Convert to Int64
		/// </summary>
		/// <param name="_strValue">Value to convert</param>
		/// <returns>Converted Int64</returns>
		public static Int64 ConvertToInt64( String _strValue )
		{
			Int64 nReturn = 0;

			try
			{
				nReturn = Convert.ToInt64( _strValue );
			}
			catch ( Exception )
			{
			}

			return( nReturn );
		}

		/// <summary>
		/// Convert to Int64
		/// </summary>
		/// <param name="_oValue">Value to convert</param>
		/// <returns>Converted Int64</returns>
		public static Int64 ConvertToInt64( Object _oValue )
		{
			Int64 nReturn = 0;

			try
			{
				if( _oValue != null )
					nReturn = Convert.ToInt64( _oValue );
			}
			catch ( Exception )
			{
			}

			return( nReturn );
		}

		/// <summary>
		/// Convert to String
		/// </summary>
		/// <param name="_oValue">Value to convert</param>
		/// <returns>Converted String</returns>
		public static String ConvertToString( Object _oValue )
		{
			String strReturn = "";

			if( _oValue != null )
				strReturn = _oValue.ToString().Trim();

			return( strReturn );
		}

		/// <summary>
		/// Convert to Boolean
		/// </summary>
		/// <param name="_strValue">Value to convert</param>
		/// <returns>Converted Boolean</returns>
		public static Boolean ConvertToBoolean0( String _strValue )
		{
			return( _strValue.Trim() != "0" );
		}

		/// <summary>
		/// Convert to Boolean
		/// </summary>
		/// <param name="_oValue">Value to convert</param>
		/// <returns>Converted Boolean</returns>
		public static Boolean ConvertToBoolean( Object _oValue )
		{
			Boolean bReturn = false;

			try
			{
				if( _oValue != null )
					bReturn = Convert.ToBoolean( _oValue );
			}
			catch ( Exception )
			{
			}

			return( bReturn );
		}

		/// <summary>
		/// Convert to Boolean
		/// </summary>
		/// <param name="_strValue">Value to convert</param>
		/// <returns>Converted Boolean</returns>
		public static Boolean ConvertToBoolean( String _strValue )
		{
			Boolean bReturn = false;

			try
			{
				bReturn = Convert.ToBoolean( _strValue );
			}
			catch ( Exception )
			{
			}

			return( bReturn );
		}

		/// <summary>
		/// Convert to Boolean
		/// </summary>
		/// <param name="_strValue">Value to convert</param>
		/// <returns>Converted Boolean</returns>
		public static Boolean ConvertToBooleanYES( String _strValue )
		{
			return( _strValue.Trim()[0] == 'Y' );
		}

		/// <summary>
		/// Convert to Decimal
		/// </summary>
		/// <param name="_strValue">Value to convert</param>
		/// <returns>Converted Decimal</returns>
		public static Decimal ConvertToDecimal( String _strValue )
		{
			Decimal fReturn = 0;

			try
			{
				fReturn = Convert.ToDecimal( _strValue );
			}
			catch ( Exception )
			{
			}

			return( fReturn );
		}

		/// <summary>
		/// Convert to Decimal
		/// </summary>
		/// <param name="_objValue">Value to convert</param>
		/// <returns>Converted Decimal</returns>
		public static Decimal ConvertToDecimal( Object _objValue )
		{
			Decimal fReturn = 0;

			try
			{
				if( _objValue != null )
					fReturn = Convert.ToDecimal( _objValue );
			}
			catch ( Exception )
			{
			}

			return( fReturn );
		}

		/// <summary>
		/// Convert to Decimal
		/// </summary>
		/// <param name="_strValue">Value to convert</param>
		/// <returns>Converted Double</returns>
		public static Double ConvertToDouble( String _strValue )
		{
			Double fReturn = 0;

			try
			{
				fReturn = Convert.ToDouble( _strValue );
			}
			catch ( Exception )
			{
			}

			return( fReturn );
		}

		/// <summary>
		/// Convert to Decimal
		/// </summary>
		/// <param name="_objValue">Value to convert</param>
		/// <returns>Converted Double</returns>
		public static Double ConvertToDouble( Object _objValue )
		{
			Double fReturn = 0;

			try
			{
				if( _objValue != null )
					fReturn = Convert.ToDouble( _objValue );
			}
			catch ( Exception )
			{
			}

			return( fReturn );
		}


#endregion

	}
}

