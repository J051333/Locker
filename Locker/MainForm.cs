using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Shell32;

namespace Locker {
    public partial class MainForm : Form {

        [DllImport("user32.dll")]
        private static extern bool ShowCursor(bool bShow);

        [DllImport("user32.dll")]
        private static extern bool ClipCursor(ref Rect lpRect);

        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr hWnd, out Rect lpRect);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public enum PositionState {
            VALID,
            INVALID,
            DEFAULT,
        }

        internal bool isLocked = false;
        private Keys passkey = Keys.D;

        private Point start;

        private readonly List<MonitorIndicator> monitorIndicators = new List<MonitorIndicator>();

        internal static readonly int[] LOCKED_WINDOW_SIZE = { 10, 10 };
        internal static readonly int[] WINDOW_SIZE = { 271, 415 };
        internal static readonly Keys DEFAULT_KEY = Keys.D;

        public MainForm() {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e) {
            Size = new Size(WINDOW_SIZE[0], WINDOW_SIZE[1]);
            CenterToScreen();
            heightBox.Text = LOCKED_WINDOW_SIZE[1].ToString();
            widthBox.Text = LOCKED_WINDOW_SIZE[0].ToString();

            r.Text = SystemColors.Control.R.ToString();
            g.Text = SystemColors.Control.G.ToString();
            b.Text = SystemColors.Control.B.ToString();

            keyBox.Text = DEFAULT_KEY.ToString();

            SwitchSuppress.switchSuppress.LoadSuppressor(this);

            LoadProfileDropdown();
            LoadMonitorsDropdown();
        }

        private void LoadMonitorsDropdown() {
            for (int i = 0; i < Screen.AllScreens.Length; i++) {
                monitorsDropdown.Items.Add(i + 1);
            }
            monitorsDropdown.SelectedIndex = 0;
        }

        private void LockClicked(object sender, EventArgs e) {
            if (!isLocked) LockMouse();
            else UnlockMouse();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == passkey && isLocked) UnlockMouse();

            if (keyData == Keys.Escape) {
                DisposeMIs();
            }

            if (keyData == Keys.Enter) {
                LockClicked(null, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LockMouse() {
            isLocked = true;

            start = Location;

            passkey = Enum.TryParse(keyBox.Text.ToUpper(), out Keys attempt) ? attempt : DEFAULT_KEY;
            DisposeMIs();

            FormBorderStyle = FormBorderStyle.None;

            if (minimize.Checked) {
                new Shell().MinimizeAll();
                Activate();
            }

            ResizeWindow();
            SetColor();
            Cursor.Hide();

            // Cancel locking if pos is invalid
            if (!SetPos()) {
                UnlockMouse();
                return;
            }

            Console.WriteLine(Location.ToString());


            GetWindowRect(Handle, out Rect clipRect);
            GetClientRect(Handle, out Rect clientRect);

            clipRect.Right = clipRect.Left + clientRect.Right - 1;
            clipRect.Bottom = clipRect.Top + clientRect.Bottom - 1;
            clipRect.Left += 1;
            clipRect.Top += 1;

            Console.WriteLine($"cx: {clipRect.Left} cy: {clipRect.Top} wx: {Location.X} wy: {Location.Y}");
            Console.WriteLine($"cx: {clipRect.Right} cy: {clipRect.Bottom} wx: {Size.Width} wy: {Size.Height}");

            ClipCursor(ref clipRect);

            settingsGroup.Hide();
        }

        private bool SetPos() {
            if (isLocked) {
                CenterToScreen();
                Location = new Point(0, 0);
                Screen screen = Screen.AllScreens[monitorsDropdown.SelectedIndex];
                int x, y;

                switch (IsValidPosition(xBox.Text, yBox.Text)) {
                    case PositionState.VALID:
                        x = int.Parse(xBox.Text);
                        y = int.Parse(yBox.Text);
                        break;
                    case PositionState.INVALID:
                        return false;
                    case PositionState.DEFAULT:
                        x = screen.Bounds.Width / 2 - Size.Width / 2;
                        y = screen.Bounds.Height / 2 - Size.Height / 2;
                        break;
                    default:
                        return false;
                }

                x += screen.WorkingArea.Location.X;
                y += screen.WorkingArea.Location.Y;

                Location = new Point(x, y);

                return true;
            } else {
                Location = start;
                return false;
            }
        }

        private void UnlockMouse() {
            isLocked = false;

            SetPos();

            FormBorderStyle = FormBorderStyle.FixedSingle;

            ResizeWindow();
            SetColor();
            CenterToScreen();

            Cursor.Show();

            Cursor.Clip = new Rectangle();
            Console.WriteLine("u");

            settingsGroup.Show();
        }

        private void ResizeWindow() {
            if (isLocked) {
                int _height;
                int _width;
                _height = int.TryParse(heightBox.Text, out _height) ? _height : LOCKED_WINDOW_SIZE[1];
                _width = int.TryParse(widthBox.Text, out _width) ? _width : LOCKED_WINDOW_SIZE[0];

                Size = new Size(_width, _height);
            } else {
                Size = new Size(WINDOW_SIZE[0], WINDOW_SIZE[1]);
            }
        }
        private void PickColorPressed(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK) {
                Color color = colorPicker.Color;

                r.Text = color.R.ToString();
                g.Text = color.G.ToString();
                b.Text = color.B.ToString();
            }
        }
        private void SetColor() {
            if (isLocked) {
                BackColor = Color.FromArgb(
                    TryParse(r.Text, SystemColors.Control.R),
                    TryParse(g.Text, SystemColors.Control.G),
                    TryParse(b.Text, SystemColors.Control.B)
                );
            } else {
                BackColor = SystemColors.Control;
            }
        }

        internal void LoadProfileDropdown() {
            profileDropdown.Items.Clear();
            foreach (string profile in FileManager.GetProfiles()) {
                profileDropdown.Items.Add(profile.Substring(0, profile.LastIndexOf(".")));
            }
        }

        public static int TryParse(string val, int def) {
            if (int.TryParse(val, out int res)) {
                return res;
            } else {
                return def;
            }
        }

        private void ProfileDropdownSelectionChangeCommitted(object sender, EventArgs e) {
            ApplyProfile(profileDropdown.SelectedItem as string);
        }

        private void DeleteSelectedProfileClicked(object sender, EventArgs e) {

            FileInfo[] files = new DirectoryInfo(Directory.GetCurrentDirectory()).GetFiles(profileDropdown.SelectedItem as string + FileManager.FILE_EXTENSION);
            if (files.Length != 0) files[0].Delete();
            LoadProfileDropdown();
        }

        private void SaveProfileClicked(object sender, EventArgs e) {
            ProfileInfo savedProfile = new ProfileInfo(
                saveProfileBox.Text,
                TryParse(heightBox.Text, LOCKED_WINDOW_SIZE[1]),
                TryParse(widthBox.Text, LOCKED_WINDOW_SIZE[0]),
                TryParse(r.Text, SystemColors.Control.R),
                TryParse(g.Text, SystemColors.Control.G),
                TryParse(b.Text, SystemColors.Control.B),
                minimize.Checked,
                keyBox.Text,
                xBox.Text,
                yBox.Text,
                monitorsDropdown.SelectedIndex);

            FileManager.WriteProfile(savedProfile);
            LoadProfileDropdown();
        }

        internal void ApplyProfile(string profileName, string dir = null) {
            ProfileInfo readProfile = FileManager.ReadProfile(profileName, dir);

            heightBox.Text = readProfile.height.ToString();
            widthBox.Text = readProfile.width.ToString();
            r.Text = readProfile.r.ToString();
            g.Text = readProfile.g.ToString();
            b.Text = readProfile.b.ToString();
            minimize.Checked = readProfile.minimize;
            keyBox.Text = readProfile.key;
            xBox.Text = readProfile.x;
            yBox.Text = readProfile.y;
            monitorsDropdown.SelectedIndex = readProfile.monitor;
        }

        internal PositionState IsValidPosition(String sX, String sY) {
            Screen screen = Screen.AllScreens[monitorsDropdown.SelectedIndex];

            int x, y;

            try {
                x = int.Parse(sX);
                y = int.Parse(sY);
            } catch (FormatException) {
                return PositionState.DEFAULT;
            } catch (Exception) {
                return PositionState.INVALID;
            }

            // We can check against 0 because it never changes as the min width/height
            // We make it fit for each individual screen later
            if (x < 0 || x > screen.Bounds.Width) {
                MessageBox.Show("X position is out of bounds for the given monitor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return PositionState.INVALID;
            }

            if (y < 0 || y > screen.Bounds.Height) {
                MessageBox.Show("Y position is out of bounds for the given monitor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return PositionState.INVALID;
            }

            return PositionState.VALID;
        }

        private void ShowMonitorsClicked(object sender, EventArgs e) {
            DisposeMIs();
            for (int i = 0; i < Screen.AllScreens.Length; i++) {
                MonitorIndicator mi = new MonitorIndicator();
                mi.SetIndicator(i);
                mi.Show();
                monitorIndicators.Add(mi);
                mi.Dis += DisposeMIs;
            }
            Focus();
        }

        private void DisposeMIs() {
            foreach (MonitorIndicator mi in monitorIndicators) {
                mi.Dispose();
            }
        }
    }
}
