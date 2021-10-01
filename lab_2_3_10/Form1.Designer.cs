
namespace lab_2_3_10 {
  partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.showTaskButton = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.sentence1 = new System.Windows.Forms.TextBox();
      this.sentence2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.doubles = new System.Windows.Forms.TextBox();
      this.singles = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // showTaskButton
      // 
      this.showTaskButton.Location = new System.Drawing.Point(12, 12);
      this.showTaskButton.Name = "showTaskButton";
      this.showTaskButton.Size = new System.Drawing.Size(180, 34);
      this.showTaskButton.TabIndex = 0;
      this.showTaskButton.TabStop = false;
      this.showTaskButton.Text = "Показать задание";
      this.showTaskButton.UseVisualStyleBackColor = true;
      this.showTaskButton.Click += new System.EventHandler(this.ShowTask);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(765, 12);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(153, 34);
      this.button2.TabIndex = 3;
      this.button2.Text = "Очистить ввод";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.ClearInput);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 76);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(137, 58);
      this.label1.TabIndex = 2;
      this.label1.Text = "Первое предложение:";
      // 
      // sentence1
      // 
      this.sentence1.Location = new System.Drawing.Point(155, 76);
      this.sentence1.Multiline = true;
      this.sentence1.Name = "sentence1";
      this.sentence1.PlaceholderText = "Введите сюда первое предложение";
      this.sentence1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.sentence1.Size = new System.Drawing.Size(763, 105);
      this.sentence1.TabIndex = 1;
      this.sentence1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputChanged);
      // 
      // sentence2
      // 
      this.sentence2.Location = new System.Drawing.Point(155, 205);
      this.sentence2.Multiline = true;
      this.sentence2.Name = "sentence2";
      this.sentence2.PlaceholderText = "Введите сюда второе предложение";
      this.sentence2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.sentence2.Size = new System.Drawing.Size(763, 105);
      this.sentence2.TabIndex = 2;
      this.sentence2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputChanged);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 205);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(137, 58);
      this.label2.TabIndex = 4;
      this.label2.Text = "Второе предложение:";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 349);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(438, 33);
      this.label3.TabIndex = 6;
      this.label3.Text = "Слова, входящие в оба предложения:";
      // 
      // doubles
      // 
      this.doubles.Location = new System.Drawing.Point(12, 385);
      this.doubles.Multiline = true;
      this.doubles.Name = "doubles";
      this.doubles.PlaceholderText = "Слова отсутствуют";
      this.doubles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.doubles.Size = new System.Drawing.Size(438, 246);
      this.doubles.TabIndex = 7;
      this.doubles.TabStop = false;
      // 
      // singles
      // 
      this.singles.Location = new System.Drawing.Point(480, 385);
      this.singles.Multiline = true;
      this.singles.Name = "singles";
      this.singles.PlaceholderText = "Слова отсутствуют";
      this.singles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.singles.Size = new System.Drawing.Size(438, 246);
      this.singles.TabIndex = 9;
      this.singles.TabStop = false;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(480, 349);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(438, 33);
      this.label4.TabIndex = 8;
      this.label4.Text = "Слова, входящие только в первое предложение:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(930, 643);
      this.Controls.Add(this.singles);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.doubles);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.sentence2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.sentence1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.showTaskButton);
      this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Form1";
      this.Text = "Вхождение слов в предложения";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button showTaskButton;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox sentence1;
    private System.Windows.Forms.TextBox sentence2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox doubles;
    private System.Windows.Forms.TextBox singles;
    private System.Windows.Forms.Label label4;
  }
}

