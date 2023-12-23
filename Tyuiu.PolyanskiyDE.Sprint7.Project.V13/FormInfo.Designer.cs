
namespace Tyuiu.PolyanskiyDE.Sprint7.Project.V13
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.textBoxBDInfo_PDE = new System.Windows.Forms.TextBox();
            this.textBoxControlPanel_PDE = new System.Windows.Forms.TextBox();
            this.buttonOKInfo_PDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBDInfo_PDE
            // 
            this.textBoxBDInfo_PDE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBDInfo_PDE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBDInfo_PDE.Location = new System.Drawing.Point(400, 12);
            this.textBoxBDInfo_PDE.Multiline = true;
            this.textBoxBDInfo_PDE.Name = "textBoxBDInfo_PDE";
            this.textBoxBDInfo_PDE.ReadOnly = true;
            this.textBoxBDInfo_PDE.Size = new System.Drawing.Size(420, 363);
            this.textBoxBDInfo_PDE.TabIndex = 0;
            this.textBoxBDInfo_PDE.Text = resources.GetString("textBoxBDInfo_PDE.Text");
            // 
            // textBoxControlPanel_PDE
            // 
            this.textBoxControlPanel_PDE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxControlPanel_PDE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxControlPanel_PDE.Location = new System.Drawing.Point(12, 12);
            this.textBoxControlPanel_PDE.Multiline = true;
            this.textBoxControlPanel_PDE.Name = "textBoxControlPanel_PDE";
            this.textBoxControlPanel_PDE.ReadOnly = true;
            this.textBoxControlPanel_PDE.Size = new System.Drawing.Size(382, 400);
            this.textBoxControlPanel_PDE.TabIndex = 1;
            this.textBoxControlPanel_PDE.Text = resources.GetString("textBoxControlPanel_PDE.Text");
            // 
            // buttonOKInfo_PDE
            // 
            this.buttonOKInfo_PDE.Location = new System.Drawing.Point(724, 381);
            this.buttonOKInfo_PDE.Name = "buttonOKInfo_PDE";
            this.buttonOKInfo_PDE.Size = new System.Drawing.Size(96, 31);
            this.buttonOKInfo_PDE.TabIndex = 2;
            this.buttonOKInfo_PDE.Text = "OK";
            this.buttonOKInfo_PDE.UseVisualStyleBackColor = true;
            this.buttonOKInfo_PDE.Click += new System.EventHandler(this.buttonOKInfo_PDE_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 423);
            this.Controls.Add(this.buttonOKInfo_PDE);
            this.Controls.Add(this.textBoxControlPanel_PDE);
            this.Controls.Add(this.textBoxBDInfo_PDE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBDInfo_PDE;
        private System.Windows.Forms.TextBox textBoxControlPanel_PDE;
        private System.Windows.Forms.Button buttonOKInfo_PDE;
    }
}