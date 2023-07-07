using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker {
    public partial class MonitorIndicator : Form {
        public static readonly Size size = new Size(400, 420);
        public delegate void DisposeOfMIs();
        public DisposeOfMIs Dis;

        public MonitorIndicator() {
            InitializeComponent();
        }

        public void SetIndicator(int i) {
            monitorNum.Text = (i + 1).ToString();

            Size = size;
            CenterToScreen();
            Location = new Point(0, 0);

            int x = Location.X, y = Location.Y;

            x += Screen.AllScreens[i].WorkingArea.Location.X;
            y += Screen.AllScreens[i].WorkingArea.Location.Y;

            Location = new Point(x, y);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                Dis();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
