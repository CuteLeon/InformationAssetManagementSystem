using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IAMS.Client.Forms
{
    public partial class ColumnCheckDialog : Form
    {
        public ColumnCheckDialog()
        {
            this.Icon = AppResource.AppIcon;
            this.InitializeComponent();
        }

        private ColumnCheckDialog(IEnumerable<string> columns)
            : this()
        {
            if (columns == null || columns.Count() == 0)
            {
                return;
            }

            columns.Select((column, index) =>
            {
                this.ColumnCheckList.Items.Add(column);
                this.ColumnCheckList.SetItemChecked(index, true);
                return true;
            }).ToArray();
        }

        public static int[] ShowColumnCheckDialog(IEnumerable<string> columns)
        {
            using (var dialog = new ColumnCheckDialog(columns))
            {
                dialog.ShowDialog();

                return dialog.ColumnCheckList.Items
                    .Cast<object>()
                    .Select((item, index) => dialog.ColumnCheckList.GetItemChecked(index) ? index : -1)
                    .Where(index => index > -1)
                    .ToArray();
            }
        }
    }
}
