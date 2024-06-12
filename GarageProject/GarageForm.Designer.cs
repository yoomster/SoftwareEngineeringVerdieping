namespace GarageProject
{
    partial class GarageForm
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
            label1 = new Label();
            listBoxCars = new ListBox();
            buttonStartCar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Auto's :";
            // 
            // listBoxCars
            // 
            listBoxCars.FormattingEnabled = true;
            listBoxCars.ItemHeight = 15;
            listBoxCars.Location = new Point(25, 58);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.Size = new Size(415, 154);
            listBoxCars.TabIndex = 1;
            // 
            // buttonStartCar
            // 
            buttonStartCar.Location = new Point(25, 238);
            buttonStartCar.Name = "buttonStartCar";
            buttonStartCar.Size = new Size(415, 23);
            buttonStartCar.TabIndex = 2;
            buttonStartCar.Text = "Start proefrit in geselecteerde auto";
            buttonStartCar.UseVisualStyleBackColor = true;
            buttonStartCar.Click += buttonStartCar_Click;
            // 
            // GarageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 293);
            Controls.Add(buttonStartCar);
            Controls.Add(listBoxCars);
            Controls.Add(label1);
            Name = "GarageForm";
            Text = "Garage";
            Load += GarageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxCars;
        private Button buttonStartCar;
    }
}