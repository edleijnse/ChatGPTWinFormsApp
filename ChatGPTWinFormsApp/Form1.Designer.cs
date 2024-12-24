namespace ChatGPTWinFormsApp;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        textQuestion = new System.Windows.Forms.TextBox();
        buttonAsk = new System.Windows.Forms.Button();
        textAnswer = new System.Windows.Forms.TextBox();
        textHistory = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(51, 24);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(289, 28);
        label1.TabIndex = 0;
        label1.Text = "Enter your Question:";
        label1.Click += label1_Click;
        // 
        // textQuestion
        // 
        textQuestion.Location = new System.Drawing.Point(59, 57);
        textQuestion.Multiline = true;
        textQuestion.Name = "textQuestion";
        textQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textQuestion.Size = new System.Drawing.Size(589, 96);
        textQuestion.TabIndex = 1;
        textQuestion.TextChanged += textQuestion_TextChanged;
        // 
        // buttonAsk
        // 
        buttonAsk.Location = new System.Drawing.Point(58, 180);
        buttonAsk.Name = "buttonAsk";
        buttonAsk.Size = new System.Drawing.Size(83, 32);
        buttonAsk.TabIndex = 2;
        buttonAsk.Text = "Ask";
        buttonAsk.UseVisualStyleBackColor = true;
        buttonAsk.Click += buttonAsk_Click;
        // 
        // textAnswer
        // 
        textAnswer.Location = new System.Drawing.Point(62, 233);
        textAnswer.Multiline = true;
        textAnswer.Name = "textAnswer";
        textAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textAnswer.Size = new System.Drawing.Size(585, 193);
        textAnswer.TabIndex = 3;
        // 
        // textHistory
        // 
        textHistory.Location = new System.Drawing.Point(65, 457);
        textHistory.Multiline = true;
        textHistory.Name = "textHistory";
        textHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textHistory.Size = new System.Drawing.Size(581, 247);
        textHistory.TabIndex = 4;
        textHistory.TextChanged += textHistory_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 729);
        Controls.Add(textHistory);
        Controls.Add(textAnswer);
        Controls.Add(buttonAsk);
        Controls.Add(textQuestion);
        Controls.Add(label1);
        Text = "ChatGPT Client";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textHistory;

    private System.Windows.Forms.TextBox textAnswer;

    private System.Windows.Forms.Button buttonAsk;

    private System.Windows.Forms.TextBox textQuestion;

    private System.Windows.Forms.Label label1;

    #endregion
}