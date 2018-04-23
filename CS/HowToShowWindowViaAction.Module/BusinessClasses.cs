using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace HowToShowWindowViaAction.Module {
	[DefaultClassOptions]
	public class BusinessClass1: BaseObject {
		public BusinessClass1(Session session)
			: base(session) {
		}
		private string name;

		public string Name {
			get {
				return name;
			}
			set {
				SetPropertyValue("Name", ref name, value);
			}
		}
	}
	[DefaultClassOptions]
	public class BusinessClass2 : BaseObject {
		public BusinessClass2(Session session)
			: base(session) {
		}
		private string name;

		public string Name {
			get {
				return name;
			}
			set {
				SetPropertyValue("Name", ref name, value);
			}
		}
	}
}
