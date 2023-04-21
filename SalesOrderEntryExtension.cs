using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Objects.SO;

namespace JenkinsTest
{
	public class SalesOrderEntryExtension : PXGraphExtension<SOOrderEntry>
	{
        public override void Initialize() {
            base.Initialize();
        }

        protected virtual void SOOrder_RowSelected(PXCache sender, PXRowSelectedEventArgs e) {
            SOOrder row = e.Row as SOOrder;
            if (row == null) return;

            if (row.OrderType == "SO") {
                PXUIFieldAttribute.SetEnabled<SOOrder.orderType>(sender, row, false);
                PXTrace.WriteError("<!>!!!!!!!<!>SO SELECTED <!>!!!!!!!<!>");
            }
        }   
	}
}
