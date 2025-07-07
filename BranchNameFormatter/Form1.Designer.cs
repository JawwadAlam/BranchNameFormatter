namespace BranchNameFormatter;

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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.btnCopyToClip = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(54, 35);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(734, 27);
            this.txtInput.TabIndex = 0;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(54, 86);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.ReadOnly = true;
            this.txtBranchName.Size = new System.Drawing.Size(734, 27);
            this.txtBranchName.TabIndex = 1;
            // 
            // btnCopyToClip
            // 
            this.btnCopyToClip.Location = new System.Drawing.Point(694, 119);
            this.btnCopyToClip.Name = "btnCopyToClip";
            this.btnCopyToClip.Size = new System.Drawing.Size(94, 29);
            this.btnCopyToClip.TabIndex = 2;
            this.btnCopyToClip.Text = "Copy";
            this.btnCopyToClip.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(594, 119);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 29);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 165);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCopyToClip);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Branch Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox txtInput;
    private Label lblBranchName;
    private TextBox txtBranchName;
    private Button btnCopyToClip;
    private Button btnGenerate;
}
