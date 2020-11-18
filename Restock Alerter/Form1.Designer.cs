namespace Restock_Alerter
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
            this.URL_Label = new System.Windows.Forms.Label();
            this.URLbox = new System.Windows.Forms.TextBox();
            this.TimeLengthBox = new System.Windows.Forms.TextBox();
            this.RepeatLabel = new System.Windows.Forms.Label();
            this.TimeUnitBox = new System.Windows.Forms.ComboBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndNowButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URL_Label
            // 
            this.URL_Label.AutoSize = true;
            this.URL_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL_Label.Location = new System.Drawing.Point(12, 22);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(66, 29);
            this.URL_Label.TabIndex = 0;
            this.URL_Label.Text = "URL:";
            this.URL_Label.Click += new System.EventHandler(this.URL_Label_Click);
            // 
            // URLbox
            // 
            this.URLbox.Location = new System.Drawing.Point(285, 29);
            this.URLbox.Name = "URLbox";
            this.URLbox.Size = new System.Drawing.Size(278, 22);
            this.URLbox.TabIndex = 1;
            this.URLbox.Text = "(Paste the URL here)";
            this.URLbox.TextChanged += new System.EventHandler(this.URLbox_TextChanged);
            // 
            // TimeLengthBox
            // 
            this.TimeLengthBox.Location = new System.Drawing.Point(285, 111);
            this.TimeLengthBox.Name = "TimeLengthBox";
            this.TimeLengthBox.Size = new System.Drawing.Size(90, 22);
            this.TimeLengthBox.TabIndex = 3;
            this.TimeLengthBox.Text = "(Time Length)";
            // 
            // RepeatLabel
            // 
            this.RepeatLabel.AutoSize = true;
            this.RepeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatLabel.Location = new System.Drawing.Point(12, 104);
            this.RepeatLabel.Name = "RepeatLabel";
            this.RepeatLabel.Size = new System.Drawing.Size(249, 29);
            this.RepeatLabel.TabIndex = 4;
            this.RepeatLabel.Text = "Frequency of Refresh:";
            // 
            // TimeUnitBox
            // 
            this.TimeUnitBox.FormattingEnabled = true;
            this.TimeUnitBox.Items.AddRange(new object[] {
            "s",
            "min",
            "hr"});
            this.TimeUnitBox.Location = new System.Drawing.Point(381, 109);
            this.TimeUnitBox.Name = "TimeUnitBox";
            this.TimeUnitBox.Size = new System.Drawing.Size(97, 24);
            this.TimeUnitBox.TabIndex = 6;
            this.TimeUnitBox.Text = "(Time Unit)";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLabel.Location = new System.Drawing.Point(12, 183);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(124, 29);
            this.EndTimeLabel.TabIndex = 7;
            this.EndTimeLabel.Text = "End Time:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(285, 190);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 8;
            // 
            // EndNowButton
            // 
            this.EndNowButton.Location = new System.Drawing.Point(518, 187);
            this.EndNowButton.Name = "EndNowButton";
            this.EndNowButton.Size = new System.Drawing.Size(77, 29);
            this.EndNowButton.TabIndex = 9;
            this.EndNowButton.Text = "End Now";
            this.EndNowButton.UseVisualStyleBackColor = true;
            this.EndNowButton.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartButton.Location = new System.Drawing.Point(320, 271);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(87, 36);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 319);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.EndNowButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.TimeUnitBox);
            this.Controls.Add(this.RepeatLabel);
            this.Controls.Add(this.TimeLengthBox);
            this.Controls.Add(this.URLbox);
            this.Controls.Add(this.URL_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URL_Label;
        private System.Windows.Forms.TextBox URLbox;
        private System.Windows.Forms.TextBox TimeLengthBox;
        private System.Windows.Forms.Label RepeatLabel;
        private System.Windows.Forms.ComboBox TimeUnitBox;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button EndNowButton;
        private System.Windows.Forms.Button StartButton;
    }
}

