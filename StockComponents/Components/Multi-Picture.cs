using System.ComponentModel;

using BasicAttributes.Attributes;
using BasicAttributes;

namespace StockComponents
{
	public class MultiPicture
	{
		private Collection _Items = new Collection(typeof(Picture));
		public Collection Items {
			get {
				return _Items;
			}
		}

		private Registry _Registry = new Registry();
		public Registry Registry {
			get {
				return _Registry;
			}
			set {
				_Registry = value;
			}
		}

		private Common _Common = new Common();
		public Common Common {
			get {
				return _Common;
			}
			set {
				_Common = value;
			}
		}
	}
}
