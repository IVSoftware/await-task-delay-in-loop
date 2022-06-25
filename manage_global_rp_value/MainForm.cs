using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_global_rp_value
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        CancellationTokenSource _cts = null;
        private async void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxLoop.Checked)
            {
                labelGlobalRPValue.Text = "GlobalRPValue=500";
                textBoxConsole.Text = $"{DateTime.Now.ToString(@"mm:ss")}: Start clicked{Environment.NewLine}";

                textBoxConsole.AppendText($"{DateTime.Now.ToString(@"mm:ss")}: {labelGlobalRPValue.Text} {Environment.NewLine}");
                _cts = new CancellationTokenSource();
                while (checkBoxLoop.Checked)
                {
                    try {
                        await onTick(_cts.Token);
                        await Task.Delay(1000, _cts.Token);
                    }
                    catch(TaskCanceledException)
                    {
                        break;
                    }
                }
                ResetDefaults();
            }
            else
            {
                textBoxConsole.AppendText($"{DateTime.Now.ToString(@"mm:ss")}: Stop clicked{Environment.NewLine}");
                _cts?.Cancel();
            }
        }

        private void ResetDefaults()
        {
            labelGlobalRPValue.Text = "GlobalRPValue=1";
            labelWantedLevel.Text = "WantedLevel=0";
            textBoxConsole.AppendText($"{DateTime.Now.ToString(@"mm:ss")}: Cancelled (reset defaults) {Environment.NewLine}");
            textBoxConsole.AppendText($"{labelGlobalRPValue.Text} {Environment.NewLine}");
            textBoxConsole.AppendText($"{labelWantedLevel.Text} {Environment.NewLine}");
        }

        private async Task onTick(CancellationToken token)
        {
            labelWantedLevel.Text = "WantedLevel=1";
            textBoxConsole.AppendText($"{DateTime.Now.ToString(@"mm:ss")}: {labelWantedLevel.Text} {Environment.NewLine}");
            await Task.Delay(1000, token);

            labelWantedLevel.Text = "WantedLevel=0";
            textBoxConsole.AppendText($"{DateTime.Now.ToString(@"mm:ss")}: {labelWantedLevel.Text} {Environment.NewLine}");
        }
    }
}
