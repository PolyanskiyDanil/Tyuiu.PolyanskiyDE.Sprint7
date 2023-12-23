
namespace Tyuiu.PolyanskiyDE.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxMe_PDE = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_PDE = new System.Windows.Forms.TextBox();
            this.buttonOkAbout_PDE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PDE)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMe_PDE
            // 
            this.pictureBoxMe_PDE.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMe_PDE.Image")));
            this.pictureBoxMe_PDE.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_PDE.Name = "pictureBoxMe_PDE";
            this.pictureBoxMe_PDE.Size = new System.Drawing.Size(387, 221);
            this.pictureBoxMe_PDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMe_PDE.TabIndex = 0;
            this.pictureBoxMe_PDE.TabStop = false;
            // 
            // textBoxAbout_PDE
            // 
            this.textBoxAbout_PDE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_PDE.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAbout_PDE.Location = new System.Drawing.Point(405, 12);
            this.textBoxAbout_PDE.Multiline = true;
            this.textBoxAbout_PDE.Name = "textBoxAbout_PDE";
            this.textBoxAbout_PDE.ReadOnly = true;
            this.textBoxAbout_PDE.Size = new System.Drawing.Size(308, 146);
            this.textBoxAbout_PDE.TabIndex = 1;
            this.textBoxAbout_PDE.Text = resources.GetString("textBoxAbout_PDE.Text");
            // 
            // buttonOkAbout_PDE
            // 
            this.buttonOkAbout_PDE.Location = new System.Drawing.Point(610, 202);
            this.buttonOkAbout_PDE.Name = "buttonOkAbout_PDE";
            this.buttonOkAbout_PDE.Size = new System.Drawing.Size(96, 31);
            this.buttonOkAbout_PDE.TabIndex = 2;
            this.buttonOkAbout_PDE.Text = "OK";
            this.buttonOkAbout_PDE.UseVisualStyleBackColor = true;
            this.buttonOkAbout_PDE.Click += new System.EventHandler(this.buttonOkAbout_PDE_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 241);
            this.Controls.Add(this.buttonOkAbout_PDE);
            this.Controls.Add(this.textBoxAbout_PDE);
            this.Controls.Add(this.pictureBoxMe_PDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_PDE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_PDE;
        private System.Windows.Forms.TextBox textBoxAbout_PDE;
        private System.Windows.Forms.Button buttonOkAbout_PDE;
    }
}