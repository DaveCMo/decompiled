using System;

namespace SwrveUnity.IAP
{
	public class Base64EncodedReceipt : IapReceipt
	{
		private string base64encodedreceipt;

		private Base64EncodedReceipt(string r)
		{
			this.base64encodedreceipt = r;
		}

		public static IapReceipt FromString(string r)
		{
			return new Base64EncodedReceipt(r);
		}

		public string GetBase64EncodedReceipt()
		{
			return this.base64encodedreceipt;
		}
	}
}
