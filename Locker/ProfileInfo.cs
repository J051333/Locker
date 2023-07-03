using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locker {
    internal struct ProfileInfo {
        public string name;
        public int height;
        public int width;
        public int r;
        public int g;
        public int b;
        public bool minimize;
        public string key;

        public ProfileInfo(string name, int height, int width, int r, int g, int b, bool minimize, string key) {
            this.name = name;
            this.height = height;
            this.width = width;
            this.r = r;
            this.g = g;
            this.b = b;
            this.minimize = minimize;
            this.key = key;
        }

        public override string ToString() {

            return name
                + FileManager.DELIMITER
                + height.ToString()
                + FileManager.DELIMITER
                + width.ToString()
                + FileManager.DELIMITER
                + r.ToString()
                + FileManager.DELIMITER
                + g.ToString()
                + FileManager.DELIMITER
                + b.ToString()
                + FileManager.DELIMITER
                + minimize.ToString()
                + FileManager.DELIMITER
                + key;
        }
    }
}
