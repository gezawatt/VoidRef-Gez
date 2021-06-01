
namespace VoidRef_Gez
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enlargeCB = new System.Windows.Forms.CheckBox();
            this.reduceCB = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deleteCB = new System.Windows.Forms.CheckBox();
            this.normalizeCB = new System.Windows.Forms.CheckBox();
            this.normalizeTB = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // enlargeCB
            // 
            this.enlargeCB.AutoSize = true;
            this.enlargeCB.Location = new System.Drawing.Point(8, 10);
            this.enlargeCB.Name = "enlargeCB";
            this.enlargeCB.Size = new System.Drawing.Size(85, 19);
            this.enlargeCB.TabIndex = 1;
            this.enlargeCB.Text = "Increase by";
            this.enlargeCB.UseVisualStyleBackColor = true;
            this.enlargeCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // reduceCB
            // 
            this.reduceCB.AutoSize = true;
            this.reduceCB.Location = new System.Drawing.Point(8, 35);
            this.reduceCB.Name = "reduceCB";
            this.reduceCB.Size = new System.Drawing.Size(81, 19);
            this.reduceCB.TabIndex = 2;
            this.reduceCB.Text = "Reduce by";
            this.reduceCB.UseVisualStyleBackColor = true;
            this.reduceCB.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "1.1";
            // 
            // deleteCB
            // 
            this.deleteCB.AutoSize = true;
            this.deleteCB.Location = new System.Drawing.Point(8, 60);
            this.deleteCB.Name = "deleteCB";
            this.deleteCB.Size = new System.Drawing.Size(59, 19);
            this.deleteCB.TabIndex = 5;
            this.deleteCB.Text = "Delete";
            this.deleteCB.UseVisualStyleBackColor = true;
            this.deleteCB.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // normalizeCB
            // 
            this.normalizeCB.AutoSize = true;
            this.normalizeCB.Checked = true;
            this.normalizeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalizeCB.Location = new System.Drawing.Point(165, 10);
            this.normalizeCB.Name = "normalizeCB";
            this.normalizeCB.Size = new System.Drawing.Size(120, 19);
            this.normalizeCB.TabIndex = 7;
            this.normalizeCB.Text = "Normalize height:";
            this.toolTip1.SetToolTip(this.normalizeCB, "Use this checkbox to normalize image size on import. \r\nYou can set the desired he" +
        "ight in the text box on the right.");
            this.normalizeCB.UseVisualStyleBackColor = true;
            // 
            // normalizeTB
            // 
            this.normalizeTB.Location = new System.Drawing.Point(286, 8);
            this.normalizeTB.Name = "normalizeTB";
            this.normalizeTB.Size = new System.Drawing.Size(39, 23);
            this.normalizeTB.TabIndex = 8;
            this.normalizeTB.Text = "200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.normalizeTB);
            this.Controls.Add(this.normalizeCB);
            this.Controls.Add(this.deleteCB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reduceCB);
            this.Controls.Add(this.enlargeCB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "VoidRef";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox enlargeCB;
        private System.Windows.Forms.CheckBox reduceCB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox deleteCB;
        private System.Windows.Forms.CheckBox normalizeCB;
        private System.Windows.Forms.TextBox normalizeTB;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

