namespace BigBallGame
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
            this.components = new System.ComponentModel.Container();
            this.pb = new System.Windows.Forms.PictureBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_Monster = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Repelent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Tick = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Regular = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Repelent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Regular)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(12, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(500, 500);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(518, 186);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 23);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown_Monster
            // 
            this.numericUpDown_Monster.Location = new System.Drawing.Point(518, 67);
            this.numericUpDown_Monster.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Monster.Name = "numericUpDown_Monster";
            this.numericUpDown_Monster.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Monster.TabIndex = 2;
            this.numericUpDown_Monster.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_Repelent
            // 
            this.numericUpDown_Repelent.Location = new System.Drawing.Point(518, 106);
            this.numericUpDown_Repelent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Repelent.Name = "numericUpDown_Repelent";
            this.numericUpDown_Repelent.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Repelent.TabIndex = 3;
            this.numericUpDown_Repelent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_Tick
            // 
            this.numericUpDown_Tick.Location = new System.Drawing.Point(518, 145);
            this.numericUpDown_Tick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Tick.Name = "numericUpDown_Tick";
            this.numericUpDown_Tick.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Tick.TabIndex = 4;
            this.numericUpDown_Tick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_Regular
            // 
            this.numericUpDown_Regular.Location = new System.Drawing.Point(518, 28);
            this.numericUpDown_Regular.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Regular.Name = "numericUpDown_Regular";
            this.numericUpDown_Regular.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Regular.TabIndex = 5;
            this.numericUpDown_Regular.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Regular balls:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monster balls:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Repelent balls:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Game speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Regular);
            this.Controls.Add(this.numericUpDown_Tick);
            this.Controls.Add(this.numericUpDown_Repelent);
            this.Controls.Add(this.numericUpDown_Monster);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Repelent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Regular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Monster;
        private System.Windows.Forms.NumericUpDown numericUpDown_Repelent;
        private System.Windows.Forms.NumericUpDown numericUpDown_Tick;
        private System.Windows.Forms.NumericUpDown numericUpDown_Regular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

