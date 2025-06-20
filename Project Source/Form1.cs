using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WapCast
{
    public partial class FormWapCast : Form
    {
        public FormWapCast()
        {
            InitializeComponent();
        }

        private UsageForm usageForm;

        bool isExcelSelected = false;
        string selectedExcelPath = "";

        bool isImageSelected = false;
        string selectedImagePath = "";

        bool isFontSelected = false;
        string selectedFontPath = "";

        string imageText = "";
        string messageText = "";

        private bool isSending = false;
        private CancellationTokenSource cts;
        private Process currentProcess;
        private bool hadError = false;
        private bool wasCancelled = false;

        private void FormWapCast_Load(object sender, EventArgs e)
        {
            comboBoxWaitingTimeSelector.SelectedIndex = 3;
        }
        private void addImage(OpenFileDialog ofd)
        {
            btnOpenImageFile.Visible = true;
            lblImagePath.Text = Path.GetFileName(ofd.FileName);
            btnSelectImage.Text = "Se�imi Kald�r";
            isImageSelected = true;
            selectedImagePath = Path.GetFullPath(ofd.FileName);
        }
        private void removeImage()
        {
            btnOpenImageFile.Visible = false;
            lblImagePath.Text = "";
            btnSelectImage.Text = "Se�";
            isImageSelected = false;
            selectedImagePath = "";
        }
        private void addFont(OpenFileDialog ofd)
        {
            lblFontPath.Text = Path.GetFileName(ofd.FileName);
            btnSelectFont.Text = "Se�imi Kald�r";
            isFontSelected = true;
            selectedFontPath = Path.GetFullPath(ofd.FileName);
        }
        private void removeFont()
        {
            lblFontPath.Text = "";
            btnSelectFont.Text = "Se�";
            isFontSelected = false;
            selectedFontPath = "";
        }
        private void addExcel(OpenFileDialog ofd)
        {
            btnOpenExcelFile.Visible = true;
            lblExcelPath.Text = Path.GetFileName(ofd.FileName);
            btnSelectExcel.Text = "Se�imi Kald�r";
            isExcelSelected = true;
            selectedExcelPath = Path.GetFullPath(ofd.FileName);
        }
        private void removeExcel()
        {
            btnOpenExcelFile.Visible = false;
            lblExcelPath.Text = "";
            btnSelectExcel.Text = "Se�";
            isExcelSelected = false;
            selectedExcelPath = "";
        }
        private void onlyDigitEntry(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void openLink(string url)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start {url.Replace("&", "^&")}",
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }
        private void openFile(string path)
        {
            if (!File.Exists(path))
            {
                showError("Dosya bulunamad�!");
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            if (isExcelSelected)
            {
               removeExcel();
                return;
            }
            
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Excel Dosyas� Se�";
                ofd.Filter = "Excel Dosyas� (*.xlsx;*.xls)|*.xlsx;*.xls";

                if (ofd.ShowDialog() == DialogResult.OK)
                    addExcel(ofd);
            }
        }

        private void btnOpenWhatsappWEB_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://web.whatsapp.com",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                showError("WhatsApp Web a��lamad�:\n" + ex.Message);
            }
        }

        private void lblExcelPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] files || files.Length != 1)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            string extension = Path.GetExtension(files[0]);
            bool isExcel = extension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase) ||
                           extension.Equals(".xls", StringComparison.OrdinalIgnoreCase);

            e.Effect = isExcel ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void lblExcelPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] files || files.Length != 1)
                return;

            string filePath = files[0];
            string extension = Path.GetExtension(filePath);

            bool isExcel = extension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase) ||
                           extension.Equals(".xls", StringComparison.OrdinalIgnoreCase);

            if (!isExcel)
                return;

            btnOpenExcelFile.Visible = true;
            lblExcelPath.Text = Path.GetFileName(filePath);
            btnSelectExcel.Text = "Se�imi Kald�r";
            isExcelSelected = true;
            selectedExcelPath = Path.GetFullPath(filePath);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (isImageSelected)
            {
                removeImage();
                return;
            }
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Resim Dosyas� Se�";
                ofd.Filter = "Resim Dosyas� (*.jpg)|*.jpg";

                if (ofd.ShowDialog() == DialogResult.OK)
                    addImage(ofd);

            }
        }
        private void lblImagePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] files || files.Length != 1)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            string extension = Path.GetExtension(files[0]);
            bool isJpg = extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase);

            e.Effect = isJpg ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void lblImagePath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] files || files.Length != 1)
                return;

            string filePath = files[0];
            string extension = Path.GetExtension(filePath);

            if (!extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                return;

            btnOpenImageFile.Visible = true;
            lblImagePath.Text = Path.GetFileName(filePath);
            btnSelectImage.Text = "Se�imi Kald�r";
            isImageSelected = true;
            selectedImagePath = Path.GetFullPath(filePath);
        }

        private void checkBoxAddImageText_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBoxAddImageText.Checked;

            groupBoxFont.Enabled = isChecked;
            tbImageText.Enabled = isChecked;
            tbFontSize.Visible = isChecked;
            tbXKoordinat.Visible = isChecked;
            tbYKoordinat.Visible = isChecked;
            label3.Visible = isChecked;
            label4.Visible = isChecked;
            pictureBox1.Visible = isChecked;

            if (isChecked)       
                tbImageText.Text = imageText;
            else
            {
                imageText = tbImageText.Text;
                tbImageText.Clear();
                removeFont();
                checkBoxAddFont.Checked = false;
            }
        }

        private void checkBoxAddMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddMessage.Checked)
                tbImageMessageText.Text = messageText;
            else
            {
                messageText = tbImageMessageText.Text;
                tbImageMessageText.Clear();
            }

            tbImageMessageText.Enabled = checkBoxAddMessage.Checked;
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            tbLog.Clear();

            if(!isSending)
                progressBar.Visible = false;
        }

        private void checkBoxAddFont_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectFont.Enabled = checkBoxAddFont.Checked;

            if (!checkBoxAddFont.Checked)
                removeFont();
        }

        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            if (isFontSelected)
            {
                removeFont();
                return;
            }

            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Font Dosyas� Se�";
                ofd.Filter = "Font Dosyas� (*.ttf)|*.ttf";

                if (ofd.ShowDialog() == DialogResult.OK)
                    addFont(ofd);
            }
        }

        private void tbLog_TextChanged(object sender, EventArgs e)
        {
            btnClearLog.Visible = tbLog.Text.Length > 0;
        }

        private void btnExportExample_Click(object sender, EventArgs e)
        {
            if (!validateInputs(true))
                return;

            string exePath = Path.Combine(Application.StartupPath, "export_example.exe");
            var psi = new ProcessStartInfo
            {
                FileName = exePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            psi.ArgumentList.Add("--template");
            psi.ArgumentList.Add(selectedImagePath);

            if (checkBoxAddImageText.Checked)
            {
                psi.ArgumentList.Add("--text");
                psi.ArgumentList.Add(tbImageText.Text);

                psi.ArgumentList.Add("--size");
                psi.ArgumentList.Add(tbFontSize.Text);

                psi.ArgumentList.Add("--x");
                psi.ArgumentList.Add(tbXKoordinat.Text);

                psi.ArgumentList.Add("--y");
                psi.ArgumentList.Add(tbYKoordinat.Text);

                if (isFontSelected)
                {
                    psi.ArgumentList.Add("--font");
                    psi.ArgumentList.Add(selectedFontPath);
                }
            }

            try
            {
                btnExportExample.Enabled = false;
                using var proc = Process.Start(psi);
                string error = proc.StandardError.ReadToEnd();
                proc.WaitForExit();

                if (proc.ExitCode != 0)
                    MessageBox.Show(error, "Script Hatas�", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                showError("Script �al��t�r�lamad�:\n" + ex.Message);
            }
            finally
            {
                btnExportExample.Enabled = true;
            }
        }
        private void lblFontPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] files || files.Length != 1)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            bool isTtf = Path.GetExtension(files[0]).Equals(".ttf", StringComparison.OrdinalIgnoreCase);
            bool isReady = checkBoxAddImageText.Checked && checkBoxAddFont.Checked;

            e.Effect = (isTtf && isReady) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void lblFontPath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is not string[] files || files.Length != 1)
                return;

            string filePath = files[0];
            bool isTtf = Path.GetExtension(filePath).Equals(".ttf", StringComparison.OrdinalIgnoreCase);
            bool isReady = checkBoxAddImageText.Checked && checkBoxAddFont.Checked;

            if (!isTtf || !isReady)
                return;

            lblFontPath.Text = Path.GetFileName(filePath);
            btnSelectFont.Text = "Se�imi Kald�r";
            isFontSelected = true;
            selectedFontPath = Path.GetFullPath(filePath);
        }
        private void comboBoxWaitingTimeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRecommendedSecond.Visible = comboBoxWaitingTimeSelector.SelectedIndex != 3;
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://www.gnu.org/licenses/gpl-3.0.html");
        }

        private void gitHubRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://github.com/mustafatoktas/D_WapCast");
        }

        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://www.linkedin.com/in/mustafatoktas/");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openLink("https://github.com/mustafatoktas/");
        }

        private void karanl�kTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Karanl�k tema sonraki versiyonlarda eklenecektir.",
                "Karanl�k Tema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void lblRecommendedSecond_Click(object sender, EventArgs e)
        {
            comboBoxWaitingTimeSelector.SelectedIndex = 3;
        }

        private void btnOpenExcelFile_Click(object sender, EventArgs e)
        {
            openFile(selectedExcelPath);
        }

        private void btnOpenImageFile_Click(object sender, EventArgs e)
        {
            openFile(selectedImagePath);
        }

        private void orjinalFormBoyutuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(667, 873);
        }

        private void kullan�mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usageForm == null || usageForm.IsDisposed)
            {
                usageForm = new UsageForm();
                usageForm.Show();
            }
            else
                usageForm.BringToFront(); 
        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (isSending)
            {
                await stopSendingAsync();
                return;
            }

            if (!validateInputs(false))
                return;

            var result = MessageBox.Show(
                "G�nderimi ba�latmak istedi�inize emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
             );

            if (result != DialogResult.Yes)
                return;

            startSending();

            try
            {
                if (tabControl1.SelectedTab == tabPageTextMessage)
                    await startSendTextMessagesAsync(cts.Token);
                else
                    await startSendImageMessagesAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                wasCancelled = true;
            }
            finally
            {
                finishSending();
            }
        }
        private bool validateInputs(bool forExample)
        {
            if (!forExample && !isExcelSelected)
            {
                showError("Excel dosyas� se�iniz.");
                return false;
            }
            if (tabControl1.SelectedTab == tabPageTextMessage)
                return validateTextMessage();
            else
                return validateImageMessage(forExample);
        }

        private bool validateTextMessage()
        {
            if (string.IsNullOrWhiteSpace(tbTextMessageText.Text))
            {
                showError("Mesaj metni bo� b�rak�lmamal�.");
                return false;
            }
            return true;
        }

        private bool validateImageMessage(bool forExample)
        {
            if (!isImageSelected)
            {
                showError("�ablon resim se�iniz.");
                return false;
            }
            if (checkBoxAddImageText.Checked)
            {
                if (string.IsNullOrWhiteSpace(tbImageText.Text))
                {
                    showError("Resim �zerine yazd�r�lacak yaz� alan� bo� b�rak�lamaz.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(tbFontSize.Text))
                {
                    showError("Font b�y�kl��� bo� b�rak�lamaz.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(tbXKoordinat.Text) || string.IsNullOrWhiteSpace(tbYKoordinat.Text))
                {
                    showError("Koordinat alanlar� bo� b�rak�lamaz.");
                    return false;
                }
            }

            if (checkBoxAddFont.Checked && !isFontSelected)
            {
                showError("Font se�imi yap�n�z.");
                return false;
            }
            if (!forExample && checkBoxAddMessage.Checked && string.IsNullOrWhiteSpace(tbImageMessageText.Text))
            {
                showError("Mesaj metni bo� b�rak�lmamal�.");
                return false;
            }
            return true;
        }

        private Task startSendTextMessagesAsync(CancellationToken token)
        {
            string exePath = Path.Combine(Application.StartupPath, "send_text.exe");
            var args = new List<string>();

            args.Add("-e");
            args.Add(selectedExcelPath);

            args.Add("-m");
            args.Add(tbTextMessageText.Text);

            args.Add("-w");
            args.Add(comboBoxWaitingTimeSelector.SelectedItem.ToString());

            return runPythonScriptAsync(exePath, args, token);
        }
        private Task startSendImageMessagesAsync(CancellationToken token)
        {
            string exePath = Path.Combine(Application.StartupPath, "send_image.exe");
            var args = new List<string>();

            args.Add("-e");
            args.Add(selectedExcelPath);
            args.Add("-t");
            args.Add(selectedImagePath);
            args.Add("-m");
            args.Add(tbImageMessageText.Text);
            args.Add("-w");
            args.Add(comboBoxWaitingTimeSelector.SelectedItem.ToString());

            if (checkBoxAddImageText.Checked)
            {
                args.Add("--text");
                args.Add(tbImageText.Text);

                args.Add("--size");
                args.Add(tbFontSize.Text);

                args.Add("--x");
                args.Add(tbXKoordinat.Text);

                args.Add("--y");
                args.Add(tbYKoordinat.Text);
            }

            if (isFontSelected)
            {
                args.Add("--font");
                args.Add(selectedFontPath);
            }

            return runPythonScriptAsync(exePath, args, token);
        }

        private async Task runPythonScriptAsync(string exePath, List<string> args, CancellationToken token)
        {
            var psi = new ProcessStartInfo
            {
                FileName = exePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            foreach (var a in args)
                psi.ArgumentList.Add(a);

            using (currentProcess = new Process { StartInfo = psi, EnableRaisingEvents = true })
            {
                var tcs = new TaskCompletionSource<bool>();
                currentProcess.Exited += (s, e) => tcs.TrySetResult(true);

                currentProcess.OutputDataReceived += proc_OutputDataReceived;
                currentProcess.ErrorDataReceived += (s, ea) =>
                {
                    if (!string.IsNullOrEmpty(ea.Data))
                    {
                        appendLog(ea.Data, true);
                        hadError = true;
                    }
                };

                currentProcess.Start();
                currentProcess.BeginOutputReadLine();
                currentProcess.BeginErrorReadLine();

                using (token.Register(() => {
                    if (!currentProcess.HasExited)
                        currentProcess.Kill();
                }))
                {
                    await tcs.Task;
                }
            }
        }

        private void appendLog(string text, bool isError)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => appendLog(text, isError)));
                return;
            }

            tbLog.SelectionStart = tbLog.TextLength;
            tbLog.SelectionLength = 0;
            tbLog.AppendText(text + Environment.NewLine);
            tbLog.ScrollToCaret();
        }
        private void showError(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void startSending()
        {
            isSending = true;
            wasCancelled = false;
            hadError = false;

            btnStart.Text = "Durdur";
            btnStart.ForeColor = Color.Red;

            tableLayoutPanel1.Enabled = false;
            tableLayoutPanel1.AllowDrop = false;
            comboBoxWaitingTimeSelector.Enabled = false;
            btnOpenWhatsappWEB.Enabled = false;
            tabControl1.Enabled = false;
            btnExportExample.Visible = false;

            tbLog.Clear();
            progressBar.Visible = true;
            progressBar.Value = 0;

            cts?.Dispose();
            cts = new CancellationTokenSource();
        }
        private void finishSending()
        {
            isSending = false;
            btnStart.Text = "Ba�la";
            btnStart.ForeColor = Color.DodgerBlue;

            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel1.AllowDrop = true;
            comboBoxWaitingTimeSelector.Enabled = true;
            btnOpenWhatsappWEB.Enabled = true;
            tabControl1.Enabled = true;
            btnExportExample.Visible = true;

            if (!wasCancelled && !hadError)
                appendLog("T�m i�lemler tamamland�.", false);

            MessageBox.Show(
                wasCancelled ? "��lem iptal edildi." : (hadError ? "��lem tamamland� ancak baz� hatalar olu�tu." : "��lem ba�ar�yla tamamland�."),
                "Sonu�",
                MessageBoxButtons.OK,
                hadError ? MessageBoxIcon.Warning : MessageBoxIcon.Information
            );
        }
        private async Task stopSendingAsync()
        {
            wasCancelled = true;
            cts?.Cancel();

            tableLayoutPanel2.Enabled = true;
            tableLayoutPanel2.AllowDrop = true;
            groupBox2.Enabled = true;
            groupBoxFont.Enabled = true;
            btnExportExample.Enabled = true;
            groupBox3.Enabled = true;
            tableLayoutPanel1.Enabled = true;
            tableLayoutPanel1.AllowDrop = true;
            comboBoxWaitingTimeSelector.Enabled = true;
            btnOpenWhatsappWEB.Enabled = true;
            progressBar.Visible = false;

            if (currentProcess != null && !currentProcess.HasExited)
            {
                try
                {
                    currentProcess.Kill();
                    appendLog("G�nderim iptal edildi.", false);
                }
                catch (Exception ex)
                {
                    appendLog($"Process kill hatas�: {ex.Message}", true);
                    hadError = true;
                }
            }

            await Task.Delay(100);
        }
        private void proc_OutputDataReceived(object sender, DataReceivedEventArgs ea)
        {
            if (string.IsNullOrEmpty(ea.Data))
                return;

            appendLog(ea.Data, false);

            var mTotal = Regex.Match(ea.Data, @"Toplam kay�t:\s*(\d+)");
            if (mTotal.Success)
            {
                int total = int.Parse(mTotal.Groups[1].Value);
                Invoke(new Action(() =>
                {
                    progressBar.Maximum = total;
                    progressBar.Value = 0;
                }));
            }

            var mProg = Regex.Match(ea.Data, @"^(\d+)/(\d+)");
            if (mProg.Success)
            {
                int idx = int.Parse(mProg.Groups[1].Value);
                Invoke(new Action(() =>
                {
                    progressBar.Value = Math.Min(idx, progressBar.Maximum);
                }));
            }
        }   
    }
}
