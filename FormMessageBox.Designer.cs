using System.Drawing;
using System.Windows.Forms;

namespace EvaNew
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            this.mLblMsg = new MetroFramework.Controls.MetroLabel();
            this.mBtnYes = new MetroFramework.Controls.MetroButton();
            this.mBtnNo = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mLblMsg
            // 
            this.mLblMsg.BackColor = System.Drawing.Color.White;
            this.mLblMsg.Enabled = false;
            this.mLblMsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblMsg.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblMsg.ForeColor = System.Drawing.Color.Red;
            this.mLblMsg.Location = new System.Drawing.Point(124, 142);
            this.mLblMsg.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.mLblMsg.Name = "mLblMsg";
            this.mLblMsg.Size = new System.Drawing.Size(728, 186);
            this.mLblMsg.TabIndex = 2;
            this.mLblMsg.Text = "mLblMsg";
            this.mLblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mLblMsg.UseCustomForeColor = true;
            // 
            // mBtnYes
            // 
            this.mBtnYes.BackColor = System.Drawing.Color.Transparent;
            this.mBtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.mBtnYes.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnYes.ForeColor = System.Drawing.Color.Black;
            this.mBtnYes.Location = new System.Drawing.Point(246, 376);
            this.mBtnYes.Margin = new System.Windows.Forms.Padding(8);
            this.mBtnYes.Name = "mBtnYes";
            this.mBtnYes.Size = new System.Drawing.Size(176, 66);
            this.mBtnYes.TabIndex = 3;
            this.mBtnYes.Text = "mBtnYes";
            this.mBtnYes.UseCustomBackColor = true;
            this.mBtnYes.UseCustomForeColor = true;
            this.mBtnYes.UseMnemonic = false;
            this.mBtnYes.UseSelectable = true;
            // 
            // mBtnNo
            // 
            this.mBtnNo.BackColor = System.Drawing.Color.Transparent;
            this.mBtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.mBtnNo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnNo.ForeColor = System.Drawing.Color.Black;
            this.mBtnNo.Location = new System.Drawing.Point(542, 376);
            this.mBtnNo.Margin = new System.Windows.Forms.Padding(8);
            this.mBtnNo.Name = "mBtnNo";
            this.mBtnNo.Size = new System.Drawing.Size(176, 66);
            this.mBtnNo.TabIndex = 4;
            this.mBtnNo.Text = "mBtnNo";
            this.mBtnNo.UseCustomBackColor = true;
            this.mBtnNo.UseCustomForeColor = true;
            this.mBtnNo.UseMnemonic = false;
            this.mBtnNo.UseSelectable = true;
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(966, 486);
            this.Controls.Add(this.mBtnNo);
            this.Controls.Add(this.mBtnYes);
            this.Controls.Add(this.mLblMsg);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMessageBox";
            this.Padding = new System.Windows.Forms.Padding(46, 110, 46, 56);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "FormMessageBox";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Shown += new System.EventHandler(this.FormMessageBox_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mLblMsg;
        private MetroFramework.Controls.MetroButton mBtnYes;
        private MetroFramework.Controls.MetroButton mBtnNo;
    }
}