namespace WindowsFormsApplication1
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
            this.rest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.NumericUpDown();
            this.txtHeight = new System.Windows.Forms.NumericUpDown();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // rest
            // 
            this.rest.Location = new System.Drawing.Point(210, 256);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(47, 23);
            this.rest.TabIndex = 0;
            this.rest.Text = "Reset";
            this.rest.UseVisualStyleBackColor = true;
            this.rest.Visible = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblHeight);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.txtHeight);
            this.panel1.Location = new System.Drawing.Point(95, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 157);
            this.panel1.TabIndex = 1;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(100, 107);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(80, 25);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Start Game";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(162, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Width";
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(44, 36);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(92, 27);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Enter Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(164, 65);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(90, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(46, 65);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(90, 20);
            this.txtHeight.TabIndex = 0;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(260, 256);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(47, 23);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(313, 256);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 3;
            this.btnResize.Text = "New Size";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Visible = false;
            this.btnResize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 289);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown txtWidth;
        private System.Windows.Forms.NumericUpDown txtHeight;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnResize;
    }
}

