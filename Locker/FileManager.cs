using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Locker {
    internal class FileManager {
        internal static readonly string DELIMITER = @"//|//";
        public static readonly string FILE_EXTENSION = ".prof";

        internal static void PrepareTestFiles() {
            ProfileInfo testProfile = new ProfileInfo {
                name = "test",
                width = 200,
                height = 200,
                r = 200,
                g = 200,
                b = 200,
                minimize = false,
                key = "D"
            };

            File.WriteAllText(Directory.GetCurrentDirectory() + "/test.prof", testProfile.ToString());
        }

        internal static List<string> GetProfiles(string dir = null) {
            dir = dir ?? Directory.GetCurrentDirectory();

            DirectoryInfo dirInf = new DirectoryInfo(dir);

            List<string> profiles = new List<string>();

            foreach (FileInfo info in dirInf.GetFiles()) {
                if (info.Name.Contains(FILE_EXTENSION)) {
                    profiles.Add(info.Name);
                }
            }

            return profiles;
        }

        internal static void WriteProfile(ProfileInfo p, string dir = null) {
            if (string.IsNullOrEmpty(p.name) || string.IsNullOrWhiteSpace(p.name)) {
                MessageBox.Show("Empty profile name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dir = dir ?? Directory.GetCurrentDirectory();

            // Make sure the profile name doesn't already exist
            if (new DirectoryInfo(dir).GetFiles(p.name + FILE_EXTENSION).Length > 0) {
                int inc = 0;

                while (new DirectoryInfo(dir).GetFiles(p.name + $" ({inc})" + FILE_EXTENSION).Length > 0) {
                    inc++;
                }

                p.name += $" ({inc})";
            }

            File.WriteAllText(dir + "/" + p.name + FILE_EXTENSION, p.ToString());
            Console.WriteLine("Writing to " + dir);
        }

        internal static ProfileInfo ReadProfile(string profileName, string dir) {
            ProfileInfo info = new ProfileInfo();
            dir = dir ?? Directory.GetCurrentDirectory();

            string readFile = File.ReadAllText(dir + "/" + profileName + FILE_EXTENSION);

            try {
                info.name = readFile.Substring(0, readFile.IndexOf(DELIMITER));

                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.height = MainForm.TryParse(readFile.Substring(0, readFile.IndexOf(DELIMITER)), MainForm.LOCKED_WINDOW_SIZE[1]);
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.width = MainForm.TryParse(readFile.Substring(0, readFile.IndexOf(DELIMITER)), MainForm.LOCKED_WINDOW_SIZE[0]);
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.r = MainForm.TryParse(readFile.Substring(0, readFile.IndexOf(DELIMITER)), SystemColors.Control.R);
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.g = MainForm.TryParse(readFile.Substring(0, readFile.IndexOf(DELIMITER)), SystemColors.Control.G);
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.b = MainForm.TryParse(readFile.Substring(0, readFile.IndexOf(DELIMITER)), SystemColors.Control.B);
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.minimize = bool.Parse(readFile.Substring(0, readFile.IndexOf(DELIMITER)));
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.key = readFile.Substring(0, readFile.IndexOf(DELIMITER));
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.x = readFile.Substring(0, readFile.IndexOf(DELIMITER));
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.y = readFile.Substring(0, readFile.IndexOf(DELIMITER));
                readFile = readFile.Substring(readFile.IndexOf(DELIMITER) + DELIMITER.Length);

                info.monitor = MainForm.TryParse(readFile, 0);
            } catch (Exception e) {
                Console.WriteLine("We have encountered an error reading this file.");
                Console.WriteLine(e.Message);
            }

            return info;
        }
    }
}
