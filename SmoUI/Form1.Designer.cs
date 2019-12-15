namespace SmoUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartSimulation_Button = new System.Windows.Forms.Button();
            this.StopSimulation_Button = new System.Windows.Forms.Button();
            this.CountChannel_TextBox = new System.Windows.Forms.TextBox();
            this.Label_CountChannel = new System.Windows.Forms.Label();
            this.Label_CountQueue = new System.Windows.Forms.Label();
            this.CountQueue_TextBox = new System.Windows.Forms.TextBox();
            this.DelayTime_Label = new System.Windows.Forms.Label();
            this.DelayTime_TextBox = new System.Windows.Forms.TextBox();
            this.ProcessingTime_Label = new System.Windows.Forms.Label();
            this.ProcessingTime_TextBox = new System.Windows.Forms.TextBox();
            this.CurTime_Label = new System.Windows.Forms.Label();
            this.Statistic_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StartSimulation_Button
            // 
            this.StartSimulation_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartSimulation_Button.Location = new System.Drawing.Point(12, 520);
            this.StartSimulation_Button.Name = "StartSimulation_Button";
            this.StartSimulation_Button.Size = new System.Drawing.Size(151, 52);
            this.StartSimulation_Button.TabIndex = 0;
            this.StartSimulation_Button.Text = "Start Simulation";
            this.StartSimulation_Button.UseVisualStyleBackColor = true;
            this.StartSimulation_Button.Click += new System.EventHandler(this.StartSimulation_Button_Click);
            // 
            // StopSimulation_Button
            // 
            this.StopSimulation_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopSimulation_Button.Location = new System.Drawing.Point(178, 520);
            this.StopSimulation_Button.Name = "StopSimulation_Button";
            this.StopSimulation_Button.Size = new System.Drawing.Size(151, 52);
            this.StopSimulation_Button.TabIndex = 1;
            this.StopSimulation_Button.Text = "Stop Simulation";
            this.StopSimulation_Button.UseVisualStyleBackColor = true;
            this.StopSimulation_Button.Click += new System.EventHandler(this.StopSimulation_Button_Click);
            // 
            // CountChannel_TextBox
            // 
            this.CountChannel_TextBox.Location = new System.Drawing.Point(73, 53);
            this.CountChannel_TextBox.Name = "CountChannel_TextBox";
            this.CountChannel_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CountChannel_TextBox.TabIndex = 2;
            // 
            // Label_CountChannel
            // 
            this.Label_CountChannel.AutoSize = true;
            this.Label_CountChannel.Location = new System.Drawing.Point(70, 34);
            this.Label_CountChannel.Name = "Label_CountChannel";
            this.Label_CountChannel.Size = new System.Drawing.Size(111, 13);
            this.Label_CountChannel.TabIndex = 3;
            this.Label_CountChannel.Text = "Количество каналов";
            // 
            // Label_CountQueue
            // 
            this.Label_CountQueue.AutoSize = true;
            this.Label_CountQueue.Location = new System.Drawing.Point(245, 34);
            this.Label_CountQueue.Name = "Label_CountQueue";
            this.Label_CountQueue.Size = new System.Drawing.Size(84, 13);
            this.Label_CountQueue.TabIndex = 5;
            this.Label_CountQueue.Text = "Длина очереди";
            // 
            // CountQueue_TextBox
            // 
            this.CountQueue_TextBox.Location = new System.Drawing.Point(239, 53);
            this.CountQueue_TextBox.Name = "CountQueue_TextBox";
            this.CountQueue_TextBox.Size = new System.Drawing.Size(100, 20);
            this.CountQueue_TextBox.TabIndex = 4;
            // 
            // DelayTime_Label
            // 
            this.DelayTime_Label.AutoSize = true;
            this.DelayTime_Label.Location = new System.Drawing.Point(391, 34);
            this.DelayTime_Label.Name = "DelayTime_Label";
            this.DelayTime_Label.Size = new System.Drawing.Size(129, 13);
            this.DelayTime_Label.TabIndex = 7;
            this.DelayTime_Label.Text = "Время между заявками";
            // 
            // DelayTime_TextBox
            // 
            this.DelayTime_TextBox.Location = new System.Drawing.Point(404, 53);
            this.DelayTime_TextBox.Name = "DelayTime_TextBox";
            this.DelayTime_TextBox.Size = new System.Drawing.Size(100, 20);
            this.DelayTime_TextBox.TabIndex = 6;
            // 
            // ProcessingTime_Label
            // 
            this.ProcessingTime_Label.AutoSize = true;
            this.ProcessingTime_Label.Location = new System.Drawing.Point(564, 34);
            this.ProcessingTime_Label.Name = "ProcessingTime_Label";
            this.ProcessingTime_Label.Size = new System.Drawing.Size(180, 13);
            this.ProcessingTime_Label.TabIndex = 9;
            this.ProcessingTime_Label.Text = "Среднее время обработки заявки";
            // 
            // ProcessingTime_TextBox
            // 
            this.ProcessingTime_TextBox.Location = new System.Drawing.Point(607, 53);
            this.ProcessingTime_TextBox.Name = "ProcessingTime_TextBox";
            this.ProcessingTime_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ProcessingTime_TextBox.TabIndex = 8;
            // 
            // CurTime_Label
            // 
            this.CurTime_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CurTime_Label.AutoSize = true;
            this.CurTime_Label.Location = new System.Drawing.Point(877, 562);
            this.CurTime_Label.Name = "CurTime_Label";
            this.CurTime_Label.Size = new System.Drawing.Size(253, 13);
            this.CurTime_Label.TabIndex = 10;
            this.CurTime_Label.Text = "Copyright 2019, Twillight_Sparkle, All rights reserved";
            // 
            // Statistic_RichTextBox
            // 
            this.Statistic_RichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Statistic_RichTextBox.Location = new System.Drawing.Point(63, 98);
            this.Statistic_RichTextBox.Name = "Statistic_RichTextBox";
            this.Statistic_RichTextBox.ReadOnly = true;
            this.Statistic_RichTextBox.Size = new System.Drawing.Size(588, 366);
            this.Statistic_RichTextBox.TabIndex = 11;
            this.Statistic_RichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 584);
            this.Controls.Add(this.Statistic_RichTextBox);
            this.Controls.Add(this.CurTime_Label);
            this.Controls.Add(this.ProcessingTime_Label);
            this.Controls.Add(this.ProcessingTime_TextBox);
            this.Controls.Add(this.DelayTime_Label);
            this.Controls.Add(this.DelayTime_TextBox);
            this.Controls.Add(this.Label_CountQueue);
            this.Controls.Add(this.CountQueue_TextBox);
            this.Controls.Add(this.Label_CountChannel);
            this.Controls.Add(this.CountChannel_TextBox);
            this.Controls.Add(this.StopSimulation_Button);
            this.Controls.Add(this.StartSimulation_Button);
            this.Name = "MainForm";
            this.Text = "Maybe queueing system simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartSimulation_Button;
        private System.Windows.Forms.Button StopSimulation_Button;
        private System.Windows.Forms.TextBox CountChannel_TextBox;
        private System.Windows.Forms.Label Label_CountChannel;
        private System.Windows.Forms.Label Label_CountQueue;
        private System.Windows.Forms.TextBox CountQueue_TextBox;
        private System.Windows.Forms.Label DelayTime_Label;
        private System.Windows.Forms.TextBox DelayTime_TextBox;
        private System.Windows.Forms.Label ProcessingTime_Label;
        private System.Windows.Forms.TextBox ProcessingTime_TextBox;
        private System.Windows.Forms.Label CurTime_Label;
        private System.Windows.Forms.RichTextBox Statistic_RichTextBox;
    }
}

