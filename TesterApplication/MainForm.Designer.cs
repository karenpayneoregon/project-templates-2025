namespace TesterApplication;

partial class MainForm
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
        GetHelpDeskButton = new Button();
        GetConnectionStringsButton = new Button();
        SuspendLayout();
        // 
        // GetHelpDeskButton
        // 
        GetHelpDeskButton.Location = new Point(12, 36);
        GetHelpDeskButton.Name = "GetHelpDeskButton";
        GetHelpDeskButton.Size = new Size(316, 29);
        GetHelpDeskButton.TabIndex = 0;
        GetHelpDeskButton.Text = "Get Help desk settings";
        GetHelpDeskButton.UseVisualStyleBackColor = true;
        GetHelpDeskButton.Click += GetHelpDeskButton_Click;
        // 
        // GetConnectionStringsButton
        // 
        GetConnectionStringsButton.Location = new Point(12, 88);
        GetConnectionStringsButton.Name = "GetConnectionStringsButton";
        GetConnectionStringsButton.Size = new Size(316, 29);
        GetConnectionStringsButton.TabIndex = 1;
        GetConnectionStringsButton.Text = "Get connection strings";
        GetConnectionStringsButton.UseVisualStyleBackColor = true;
        GetConnectionStringsButton.Click += GetConnectionStringsButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(GetConnectionStringsButton);
        Controls.Add(GetHelpDeskButton);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button GetHelpDeskButton;
    private Button GetConnectionStringsButton;
}
