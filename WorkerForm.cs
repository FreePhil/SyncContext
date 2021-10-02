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

namespace WorkUpdateUi
{
    public partial class WorkerForm : Form
    {
        ProgressBar bar;
        Button firingFormButton;

        public WorkerForm(ProgressBar bar, Button firedButton)
        {
            InitializeComponent();

            this.bar = bar;
            this.firingFormButton = firedButton;
        }

        private void fire(object sender, EventArgs e)
        {
            if (firingFormButton.Enabled == false)
            {
                return;
            }
            firingWorkerButton.Enabled = false;
            firingFormButton.Enabled = false;

            var uiContext = SynchronizationContext.Current;
            var thread = new Thread(FireTheWork);
            thread.Start(uiContext);
        }

        private void FireTheWork(object context)
        {
            var syncedContext = (SynchronizationContext)context;

            var percentage = 0;
            syncedContext.Post(UpdateUi, percentage);

            while (percentage < 100)
            {
                percentage += 10;
                syncedContext.Post(UpdateUi, percentage);
                Thread.Sleep(1000);
            }

            Thread.Sleep(2000);
            syncedContext.Post(CloseDialog, null);
        }

        private void UpdateUi(object value)
        {
            var percentage = (int)value;
            bar.Value = percentage;
        }

        private void CloseDialog(object state)
        {
            firingFormButton.Enabled = true;
            this.Close();
        }
    }
}
