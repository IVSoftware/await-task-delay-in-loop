
namespace manage_global_rp_value
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.labelGlobalRPValue = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.labelWantedLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(29, 108);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(99, 35);
            this.checkBoxLoop.TabIndex = 0;
            this.checkBoxLoop.Text = "Run Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // labelGlobalRPValue
            // 
            this.labelGlobalRPValue.AutoSize = true;
            this.labelGlobalRPValue.Location = new System.Drawing.Point(29, 25);
            this.labelGlobalRPValue.Name = "labelGlobalRPValue";
            this.labelGlobalRPValue.Size = new System.Drawing.Size(158, 25);
            this.labelGlobalRPValue.TabIndex = 1;
            this.labelGlobalRPValue.Text = "GlobalRPValue is 1";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConsole.Location = new System.Drawing.Point(29, 164);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(412, 596);
            this.textBoxConsole.TabIndex = 2;
            // 
            // labelWantedLevel
            // 
            this.labelWantedLevel.AutoSize = true;
            this.labelWantedLevel.Location = new System.Drawing.Point(29, 64);
            this.labelWantedLevel.Name = "labelWantedLevel";
            this.labelWantedLevel.Size = new System.Drawing.Size(144, 25);
            this.labelWantedLevel.TabIndex = 1;
            this.labelWantedLevel.Text = "WantedLevel is 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 801);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.labelWantedLevel);
            this.Controls.Add(this.labelGlobalRPValue);
            this.Controls.Add(this.checkBoxLoop);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Label labelGlobalRPValue;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Label labelWantedLevel;
    }
}

