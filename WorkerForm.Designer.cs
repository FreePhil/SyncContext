
namespace WorkUpdateUi
{
    partial class WorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firingWorkerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firingWorkerButton
            // 
            this.firingWorkerButton.Location = new System.Drawing.Point(104, 56);
            this.firingWorkerButton.Name = "firingWorkerButton";
            this.firingWorkerButton.Size = new System.Drawing.Size(284, 54);
            this.firingWorkerButton.TabIndex = 0;
            this.firingWorkerButton.Text = "開始執行";
            this.firingWorkerButton.UseVisualStyleBackColor = true;
            this.firingWorkerButton.Click += new System.EventHandler(this.fire);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 171);
            this.Controls.Add(this.firingWorkerButton);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firingWorkerButton;
    }
}