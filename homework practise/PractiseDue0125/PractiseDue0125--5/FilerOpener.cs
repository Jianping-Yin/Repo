using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0125__5
{
    class FilerOpener
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }

        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FilePath + "\\" + this.FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
        }

    }
}
