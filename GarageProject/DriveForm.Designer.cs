namespace GarageProject
{
    partial class DriveForm
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
            buttonBrake = new Button();
            buttonDrive = new Button();
            labelCarInfo = new Label();
            SuspendLayout();
            // 
            // buttonBrake
            // 
            buttonBrake.Location = new Point(28, 67);
            buttonBrake.Name = "buttonBrake";
            buttonBrake.Size = new Size(155, 34);
            buttonBrake.TabIndex = 0;
            buttonBrake.Text = "Rem";
            buttonBrake.UseVisualStyleBackColor = true;
            buttonBrake.Click += buttonBrake_Click;
            // 
            // buttonDrive
            // 
            buttonDrive.Location = new Point(243, 67);
            buttonDrive.Name = "buttonDrive";
            buttonDrive.Size = new Size(141, 34);
            buttonDrive.TabIndex = 1;
            buttonDrive.Text = "Gas";
            buttonDrive.UseVisualStyleBackColor = true;
            buttonDrive.Click += buttonDrive_Click;
            // 
            // labelCarInfo
            // 
            labelCarInfo.AutoSize = true;
            labelCarInfo.Location = new Point(28, 27);
            labelCarInfo.Name = "labelCarInfo";
            labelCarInfo.Size = new Size(60, 15);
            labelCarInfo.TabIndex = 2;
            labelCarInfo.Text = "Auto info:";
            // 
            // DriveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 122);
            Controls.Add(labelCarInfo);
            Controls.Add(buttonDrive);
            Controls.Add(buttonBrake);
            Name = "DriveForm";
            Text = "Auto";
            Load += DriveForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBrake;
        private Button buttonDrive;
        private Label labelCarInfo;
    }
}