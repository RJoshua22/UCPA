namespace UCP_Activity
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2Btn = new System.Windows.Forms.Button();
            this.panelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InputOneOut = new System.Windows.Forms.TextBox();
            this.InputTwoOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTwo1 = new UCP_Activity.PanelTwo();
            this.panelOne1 = new UCP_Activity.PanelOne();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2Btn);
            this.panel1.Controls.Add(this.panelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 437);
            this.panel1.TabIndex = 0;
            // 
            // panel2Btn
            // 
            this.panel2Btn.Location = new System.Drawing.Point(46, 189);
            this.panel2Btn.Name = "panel2Btn";
            this.panel2Btn.Size = new System.Drawing.Size(115, 42);
            this.panel2Btn.TabIndex = 1;
            this.panel2Btn.Text = "Panel Two";
            this.panel2Btn.UseVisualStyleBackColor = true;
            this.panel2Btn.Click += new System.EventHandler(this.panel2Btn_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBtn.Location = new System.Drawing.Point(46, 125);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(115, 42);
            this.panelBtn.TabIndex = 0;
            this.panelBtn.Text = "Panel One";
            this.panelBtn.UseVisualStyleBackColor = true;
            this.panelBtn.Click += new System.EventHandler(this.panelBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.InputOneOut);
            this.panel2.Controls.Add(this.InputTwoOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(619, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 437);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Control Panel Application";
            // 
            // InputOneOut
            // 
            this.InputOneOut.Location = new System.Drawing.Point(15, 98);
            this.InputOneOut.Name = "InputOneOut";
            this.InputOneOut.Size = new System.Drawing.Size(157, 20);
            this.InputOneOut.TabIndex = 3;
            // 
            // InputTwoOut
            // 
            this.InputTwoOut.Location = new System.Drawing.Point(15, 220);
            this.InputTwoOut.Name = "InputTwoOut";
            this.InputTwoOut.Size = new System.Drawing.Size(157, 20);
            this.InputTwoOut.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input One:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Two:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelTwo1
            // 
            this.panelTwo1.BackColor = System.Drawing.SystemColors.Info;
            this.panelTwo1.Location = new System.Drawing.Point(210, 55);
            this.panelTwo1.Name = "panelTwo1";
            this.panelTwo1.Size = new System.Drawing.Size(398, 373);
            this.panelTwo1.TabIndex = 4;
            // 
            // panelOne1
            // 
            this.panelOne1.BackColor = System.Drawing.Color.Wheat;
            this.panelOne1.Location = new System.Drawing.Point(211, 55);
            this.panelOne1.Name = "panelOne1";
            this.panelOne1.Size = new System.Drawing.Size(397, 373);
            this.panelOne1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 437);
            this.Controls.Add(this.panelOne1);
            this.Controls.Add(this.panelTwo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button panel2Btn;
        private System.Windows.Forms.Button panelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputOneOut;
        private System.Windows.Forms.TextBox InputTwoOut;
        private System.Windows.Forms.Label label1;
        private PanelTwo panelTwo1;
        private System.Windows.Forms.Label label4;
        private PanelOne panelOne1;
    }
}
