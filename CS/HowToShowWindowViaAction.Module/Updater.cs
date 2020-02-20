using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace HowToShowWindowViaAction.Module {
	public class Updater : ModuleUpdater {
		public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) {
		}
		public override void UpdateDatabaseAfterUpdateSchema() {
            var bo2 = ObjectSpace.CreateObject<BusinessClass2>();
            bo2.Name = "test name";
            ObjectSpace.CommitChanges();
			base.UpdateDatabaseAfterUpdateSchema();
		}
	}
}
