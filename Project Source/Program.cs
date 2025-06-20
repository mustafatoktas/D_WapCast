using System;
using System.Threading;
using System.Windows.Forms;

namespace WapCast
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool createdNew;
            using (var mutex = new Mutex(true, "WapCast", out createdNew))
            {
                if (!createdNew)
                {
                    MessageBox.Show(
                        "Uygulamanın zaten bir örneği çalışıyor. 1 tanesi neyine yetmiyor?",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }
                ApplicationConfiguration.Initialize();
                Application.Run(new FormWapCast());
            }
        }
    }
}
