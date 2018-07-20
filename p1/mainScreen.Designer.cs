namespace p1
{
    partial class mainScreen
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
            this.txt_left = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_right = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_left
            // 
            this.txt_left.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_left.Location = new System.Drawing.Point(13, 13);
            this.txt_left.Multiline = true;
            this.txt_left.Name = "txt_left";
            this.txt_left.ReadOnly = true;
            this.txt_left.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_left.Size = new System.Drawing.Size(179, 201);
            this.txt_left.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_start.Location = new System.Drawing.Point(13, 221);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(179, 50);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Red;
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_stop.Location = new System.Drawing.Point(211, 221);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(179, 50);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Navy;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(13, 278);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(377, 41);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "MENTÉS FÁJLBA";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_right
            // 
            this.txt_right.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_right.Location = new System.Drawing.Point(211, 14);
            this.txt_right.Multiline = true;
            this.txt_right.Name = "txt_right";
            this.txt_right.ReadOnly = true;
            this.txt_right.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_right.Size = new System.Drawing.Size(179, 201);
            this.txt_right.TabIndex = 5;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 331);
            this.Controls.Add(this.txt_right);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_left;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_right;
    }
}

