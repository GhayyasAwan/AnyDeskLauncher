namespace AnyDeskLauncher
{
    partial class Form1
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
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtAnyDeskID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstAnyDesk = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(16, 33);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(236, 29);
            this.txtAlias.TabIndex = 0;
            // 
            // txtAnyDeskID
            // 
            this.txtAnyDeskID.Location = new System.Drawing.Point(258, 33);
            this.txtAnyDeskID.Name = "txtAnyDeskID";
            this.txtAnyDeskID.Size = new System.Drawing.Size(236, 29);
            this.txtAnyDeskID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstAnyDesk
            // 
            this.lstAnyDesk.FormattingEnabled = true;
            this.lstAnyDesk.ItemHeight = 21;
            this.lstAnyDesk.Location = new System.Drawing.Point(16, 68);
            this.lstAnyDesk.Name = "lstAnyDesk";
            this.lstAnyDesk.Size = new System.Drawing.Size(478, 361);
            this.lstAnyDesk.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(500, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 27);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Save";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lstAnyDesk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnyDeskID);
            this.Controls.Add(this.txtAlias);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtAnyDeskID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstAnyDesk;
        private System.Windows.Forms.Button btnConnect;
    }
}

