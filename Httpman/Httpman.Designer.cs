namespace Httpman
{
    partial class Httpman
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
            urlInput = new TextBox();
            goButton = new Button();
            resultTextbox = new TextBox();
            statusStrip1 = new StatusStrip();
            statusStripText = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // urlInput
            // 
            urlInput.BorderStyle = BorderStyle.FixedSingle;
            urlInput.Location = new Point(12, 77);
            urlInput.Name = "urlInput";
            urlInput.PlaceholderText = "http://example.com";
            urlInput.Size = new Size(848, 33);
            urlInput.TabIndex = 0;
            // 
            // goButton
            // 
            goButton.Location = new Point(866, 77);
            goButton.Name = "goButton";
            goButton.Size = new Size(122, 33);
            goButton.TabIndex = 1;
            goButton.Text = "Go";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // resultTextbox
            // 
            resultTextbox.BorderStyle = BorderStyle.FixedSingle;
            resultTextbox.Location = new Point(12, 175);
            resultTextbox.Multiline = true;
            resultTextbox.Name = "resultTextbox";
            resultTextbox.ReadOnly = true;
            resultTextbox.ScrollBars = ScrollBars.Vertical;
            resultTextbox.Size = new Size(848, 494);
            resultTextbox.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusStripText });
            statusStrip1.Location = new Point(0, 701);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusStripText
            // 
            statusStripText.Name = "statusStripText";
            statusStripText.Size = new Size(0, 17);
            // 
            // Httpman
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 723);
            Controls.Add(statusStrip1);
            Controls.Add(resultTextbox);
            Controls.Add(goButton);
            Controls.Add(urlInput);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Httpman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Httpman";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlInput;
        private Button goButton;
        private TextBox resultTextbox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStripText;
    }
}
