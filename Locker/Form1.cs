﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private bool isLocked = false;
        private Keys passkey = Keys.D;

        private static readonly int[] LOCKED_WINDOW_SIZE = { 10, 10 };
        private static readonly int[] WINDOW_SIZE = { 271, 320 };
        public static readonly Keys DEFAULT_KEY = Keys.D;

        public MainForm() {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e) {
            this.Size = new Size(WINDOW_SIZE[0], WINDOW_SIZE[1]);
            this.CenterToScreen();
            this.heightBox.Text = LOCKED_WINDOW_SIZE[1].ToString();
            this.widthBox.Text = LOCKED_WINDOW_SIZE[0].ToString();

            this.r.Text = SystemColors.Control.R.ToString();
            this.g.Text = SystemColors.Control.G.ToString();
            this.b.Text = SystemColors.Control.B.ToString();

            this.keyBox.Text = DEFAULT_KEY.ToString();

            SwitchSuppress.switchSuppress.LoadSuppressor();
        }

        private void LockClicked(object sender, EventArgs e) {
            if (!isLocked) LockMouse();
            else UnlockMouse();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == passkey && isLocked) UnlockMouse();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LockMouse() {
            isLocked = true;

            passkey = Enum.TryParse(this.keyBox.Text.ToUpper(), out Keys attempt) ? attempt : DEFAULT_KEY;
            Console.WriteLine(this.keyBox.Text);
            Console.WriteLine(this.keyBox.Text.ToUpper());

            this.FormBorderStyle = FormBorderStyle.None;

            if (this.minimize.Checked) {
                new Shell().MinimizeAll();
                Activate();
            }

            ResizeWindow();
            SetColor();
            this.CenterToScreen();

            Cursor.Hide();

            Rect windowRect;
            Rect clientRect;
            GetWindowRect(this.Handle, out windowRect);
            GetClientRect(this.Handle, out clientRect);

            windowRect.Right = windowRect.Left + clientRect.Right;
            windowRect.Bottom = windowRect.Top + clientRect.Bottom;

            ClipCursor(ref windowRect);

            this.settingsGroup.Hide();
        }

        private void UnlockMouse() {
            isLocked = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            ResizeWindow();
            SetColor();
            this.CenterToScreen();

            Cursor.Show();

            Cursor.Clip = new Rectangle();
            Console.WriteLine("u");

            this.settingsGroup.Show();
        }

        private void ResizeWindow() {
            if (isLocked) {
                int _height;
                int _width;
                _height = int.TryParse(this.heightBox.Text, out _height) ? _height : LOCKED_WINDOW_SIZE[1];
                _width = int.TryParse(this.widthBox.Text, out _width) ? _width : LOCKED_WINDOW_SIZE[0];

                this.Size = new Size(_width, _height);
            } else {
                this.Size = new Size(WINDOW_SIZE[0], WINDOW_SIZE[1]);
            }
        }
        private void PickColorPressed(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK) {
                Color color = colorPicker.Color;

                this.r.Text = color.R.ToString();
                this.g.Text = color.G.ToString();
                this.b.Text = color.B.ToString();
            }
        }
        private void SetColor() {
            if (isLocked) {
                int[] rgb = new int[3];

                this.BackColor = Color.FromArgb(
                    TryParse(this.r.Text, SystemColors.Control.R),
                    TryParse(this.g.Text, SystemColors.Control.G),
                    TryParse(this.b.Text, SystemColors.Control.B)
                );
            } else {
                this.BackColor = SystemColors.Control;
            }
        }

        public static int TryParse(string val, int def) {
            if (int.TryParse(val, out int res)) {
                return res;
            } else {
                return def;
            }
        }
    }
}