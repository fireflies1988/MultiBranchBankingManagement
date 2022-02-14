
namespace BankingManagement
{
    partial class ChangeBranchDialog
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewEmployeeID = new System.Windows.Forms.TextBox();
            this.buttonChangeBranch = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(49, 34);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(344, 36);
            this.comboBoxBranch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã nhân viên mới";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(224, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "*";
            this.toolTip1.SetToolTip(this.label2, "Không được bỏ trống");
            this.label2.Visible = false;
            // 
            // textBoxNewEmployeeID
            // 
            this.textBoxNewEmployeeID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewEmployeeID.Location = new System.Drawing.Point(49, 128);
            this.textBoxNewEmployeeID.MaxLength = 10;
            this.textBoxNewEmployeeID.Name = "textBoxNewEmployeeID";
            this.textBoxNewEmployeeID.Size = new System.Drawing.Size(344, 28);
            this.textBoxNewEmployeeID.TabIndex = 3;
            this.textBoxNewEmployeeID.Visible = false;
            // 
            // buttonChangeBranch
            // 
            this.buttonChangeBranch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeBranch.Location = new System.Drawing.Point(129, 189);
            this.buttonChangeBranch.Name = "buttonChangeBranch";
            this.buttonChangeBranch.Size = new System.Drawing.Size(178, 63);
            this.buttonChangeBranch.TabIndex = 4;
            this.buttonChangeBranch.Text = "Chuyển chi nhánh";
            this.buttonChangeBranch.UseVisualStyleBackColor = true;
            this.buttonChangeBranch.Click += new System.EventHandler(this.buttonChangeBranch_Click);
            // 
            // ChangeBranchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 290);
            this.Controls.Add(this.buttonChangeBranch);
            this.Controls.Add(this.textBoxNewEmployeeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBranch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeBranchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chuyển chi nhánh";
            this.Load += new System.EventHandler(this.ChangeBranchDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewEmployeeID;
        private System.Windows.Forms.Button buttonChangeBranch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}