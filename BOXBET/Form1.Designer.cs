namespace BOXBET
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameTitle = new System.Windows.Forms.Label();
            this.verlauf = new System.Windows.Forms.Label();
            this.ausgabe = new System.Windows.Forms.Label();
            this.leftboxer = new System.Windows.Forms.Label();
            this.rightboxer = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.fightBTN = new System.Windows.Forms.Button();
            this.hpLeft = new System.Windows.Forms.ProgressBar();
            this.hpRight = new System.Windows.Forms.ProgressBar();
            this.tenon2 = new System.Windows.Forms.Button();
            this.hundredon2 = new System.Windows.Forms.Button();
            this.tenon1 = new System.Windows.Forms.Button();
            this.hundredon1 = new System.Windows.Forms.Button();
            this.moneylbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(6, 8);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(741, 28);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "BoxBet Simulator";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // verlauf
            // 
            this.verlauf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.verlauf.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.verlauf.Location = new System.Drawing.Point(272, 49);
            this.verlauf.Name = "verlauf";
            this.verlauf.Size = new System.Drawing.Size(207, 238);
            this.verlauf.TabIndex = 1;
            this.verlauf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
           
            // 
            // ausgabe
            // 
            this.ausgabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ausgabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ausgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausgabe.ForeColor = System.Drawing.Color.Black;
            this.ausgabe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ausgabe.Location = new System.Drawing.Point(6, 300);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.Size = new System.Drawing.Size(741, 56);
            this.ausgabe.TabIndex = 2;
            this.ausgabe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ausgabe.UseMnemonic = false;
            this.ausgabe.TextChanged += new System.EventHandler(this.ausgabe_TextChanged);
           
            // 
            // leftboxer
            // 
            this.leftboxer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftboxer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftboxer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.leftboxer.Location = new System.Drawing.Point(134, 49);
            this.leftboxer.Name = "leftboxer";
            this.leftboxer.Size = new System.Drawing.Size(108, 195);
            this.leftboxer.TabIndex = 3;
            this.leftboxer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        
            // 
            // rightboxer
            // 
            this.rightboxer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rightboxer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightboxer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rightboxer.Location = new System.Drawing.Point(513, 49);
            this.rightboxer.Name = "rightboxer";
            this.rightboxer.Size = new System.Drawing.Size(108, 195);
            this.rightboxer.TabIndex = 4;
            this.rightboxer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.startBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBTN.ForeColor = System.Drawing.Color.Cornsilk;
            this.startBTN.Location = new System.Drawing.Point(685, 377);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(62, 42);
            this.startBTN.TabIndex = 5;
            this.startBTN.Text = "prepare the Ring";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // fightBTN
            // 
            this.fightBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.fightBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fightBTN.Location = new System.Drawing.Point(685, 444);
            this.fightBTN.Name = "fightBTN";
            this.fightBTN.Size = new System.Drawing.Size(62, 44);
            this.fightBTN.TabIndex = 6;
            this.fightBTN.Text = "FIGHT!";
            this.fightBTN.UseVisualStyleBackColor = false;
            this.fightBTN.Visible = false;
            this.fightBTN.Click += new System.EventHandler(this.fightBTN_Click);
            // 
            // hpLeft
            // 
            this.hpLeft.Location = new System.Drawing.Point(6, 259);
            this.hpLeft.Name = "hpLeft";
            this.hpLeft.Size = new System.Drawing.Size(260, 27);
            this.hpLeft.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hpLeft.TabIndex = 7;
        
            // 
            // hpRight
            // 
            this.hpRight.Location = new System.Drawing.Point(485, 259);
            this.hpRight.Name = "hpRight";
            this.hpRight.Size = new System.Drawing.Size(262, 27);
            this.hpRight.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.hpRight.TabIndex = 8;
   
            // 
            // tenon2
            // 
            this.tenon2.Location = new System.Drawing.Point(627, 180);
            this.tenon2.Name = "tenon2";
            this.tenon2.Size = new System.Drawing.Size(75, 23);
            this.tenon2.TabIndex = 9;
            this.tenon2.Text = "Bet 10$";
            this.tenon2.UseVisualStyleBackColor = true;
            this.tenon2.Visible = false;
            this.tenon2.Click += new System.EventHandler(this.tenon2_Click);
            // 
            // hundredon2
            // 
            this.hundredon2.Location = new System.Drawing.Point(627, 219);
            this.hundredon2.Name = "hundredon2";
            this.hundredon2.Size = new System.Drawing.Size(75, 23);
            this.hundredon2.TabIndex = 10;
            this.hundredon2.Text = "Bet 100$";
            this.hundredon2.UseVisualStyleBackColor = true;
            this.hundredon2.Visible = false;
            this.hundredon2.Click += new System.EventHandler(this.hundredon2_Click);
            // 
            // tenon1
            // 
            this.tenon1.Location = new System.Drawing.Point(53, 180);
            this.tenon1.Name = "tenon1";
            this.tenon1.Size = new System.Drawing.Size(75, 23);
            this.tenon1.TabIndex = 11;
            this.tenon1.Text = "Bet 10$";
            this.tenon1.UseVisualStyleBackColor = true;
            this.tenon1.Visible = false;
            this.tenon1.Click += new System.EventHandler(this.tenon1_Click);
            // 
            // hundredon1
            // 
            this.hundredon1.Location = new System.Drawing.Point(53, 219);
            this.hundredon1.Name = "hundredon1";
            this.hundredon1.Size = new System.Drawing.Size(75, 23);
            this.hundredon1.TabIndex = 12;
            this.hundredon1.Text = "Bet 100$";
            this.hundredon1.UseVisualStyleBackColor = true;
            this.hundredon1.Visible = false;
            this.hundredon1.Click += new System.EventHandler(this.hundredon1_Click);
            // 
            // moneylbl
            // 
            this.moneylbl.BackColor = System.Drawing.Color.Yellow;
            this.moneylbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moneylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneylbl.Location = new System.Drawing.Point(3, 8);
            this.moneylbl.Name = "moneylbl";
            this.moneylbl.Size = new System.Drawing.Size(77, 28);
            this.moneylbl.TabIndex = 13;
            this.moneylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(754, 580);
            this.Controls.Add(this.moneylbl);
            this.Controls.Add(this.hundredon1);
            this.Controls.Add(this.tenon1);
            this.Controls.Add(this.hundredon2);
            this.Controls.Add(this.tenon2);
            this.Controls.Add(this.hpRight);
            this.Controls.Add(this.hpLeft);
            this.Controls.Add(this.fightBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.rightboxer);
            this.Controls.Add(this.leftboxer);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.verlauf);
            this.Controls.Add(this.gameTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label verlauf;
        private System.Windows.Forms.Label ausgabe;
        private System.Windows.Forms.Label leftboxer;
        private System.Windows.Forms.Label rightboxer;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button fightBTN;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar hpLeft;
        private System.Windows.Forms.ProgressBar hpRight;
        private System.Windows.Forms.Button tenon2;
        private System.Windows.Forms.Button hundredon2;
        private System.Windows.Forms.Button tenon1;
        private System.Windows.Forms.Button hundredon1;
        private System.Windows.Forms.Label moneylbl;
    }
}

