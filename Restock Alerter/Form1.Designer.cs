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
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.URLbox.TextChanged += new System.EventHandler(this.URLbox_TextChanged);
            // 
            // TimeLengthBox
            // 
            this.TimeLengthBox.Location = new System.Drawing.Point(285, 111);
            this.TimeLengthBox.Name = "TimeLengthBox";
            this.TimeLengthBox.Size = new System.Drawing.Size(90, 22);
            this.TimeLengthBox.TabIndex = 3;
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
            this.TimeUnitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeUnitBox.FormattingEnabled = true;
            this.TimeUnitBox.Items.AddRange(new object[] {
            "seconds",
            "minutes",
            "hours"});
            this.TimeUnitBox.Location = new System.Drawing.Point(381, 109);
            this.TimeUnitBox.Name = "TimeUnitBox";
            this.TimeUnitBox.Size = new System.Drawing.Size(118, 24);
            this.TimeUnitBox.TabIndex = 6;
            this.TimeUnitBox.SelectedIndexChanged += new System.EventHandler(this.TimeUnitBox_SelectedIndexChanged);
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
            this.dateTimePicker.CustomFormat = "dddd, MMMM, dd, yyyy (hh:mm:ss)";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(285, 190);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(355, 22);
            this.dateTimePicker.TabIndex = 8;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartButton.Location = new System.Drawing.Point(413, 396);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(87, 36);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "List of supported Sites";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(722, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Best Buy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Walmart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gamestop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(722, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Target";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Day: Month, day, year (hour:minute:seconds)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(454, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Remember to unmute and turn up volume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(598, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "If you find any bugs, Email me at emailzaid@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 444);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.TimeUnitBox);
            this.Controls.Add(this.RepeatLabel);
            this.Controls.Add(this.TimeLengthBox);
            this.Controls.Add(this.URLbox);
            this.Controls.Add(this.URL_Label);
            this.Name = "Form1";
            this.Text = "List of supported sites";
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
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

