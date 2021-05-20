
namespace MrRobotGame
{
    partial class FormMain
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
            this.progressBarFood = new System.Windows.Forms.ProgressBar();
            this.progressBarSkill = new System.Windows.Forms.ProgressBar();
            this.progressBarSanity = new System.Windows.Forms.ProgressBar();
            this.progressBarSleep = new System.Windows.Forms.ProgressBar();
            this.progressBarDrugs = new System.Windows.Forms.ProgressBar();
            this.progressBarEcoin = new System.Windows.Forms.ProgressBar();
            this.labelHunger = new System.Windows.Forms.Label();
            this.labelSkil = new System.Windows.Forms.Label();
            this.labelSanity = new System.Windows.Forms.Label();
            this.labelSleep = new System.Windows.Forms.Label();
            this.labelDrugs = new System.Windows.Forms.Label();
            this.labelEcoin = new System.Windows.Forms.Label();
            this.labelDialog = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonWipe = new System.Windows.Forms.Button();
            this.buttonHack = new System.Windows.Forms.Button();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonWin = new System.Windows.Forms.Button();
            this.buttonEat = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonDrugs = new System.Windows.Forms.Button();
            this.buttonPsychologist = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.pictureBoxCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarFood
            // 
            this.progressBarFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBarFood.Location = new System.Drawing.Point(594, 352);
            this.progressBarFood.Name = "progressBarFood";
            this.progressBarFood.Size = new System.Drawing.Size(254, 18);
            this.progressBarFood.TabIndex = 1;
            this.progressBarFood.Value = 50;
            // 
            // progressBarSkill
            // 
            this.progressBarSkill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.progressBarSkill.Location = new System.Drawing.Point(594, 376);
            this.progressBarSkill.Name = "progressBarSkill";
            this.progressBarSkill.Size = new System.Drawing.Size(254, 18);
            this.progressBarSkill.TabIndex = 2;
            this.progressBarSkill.Value = 50;
            // 
            // progressBarSanity
            // 
            this.progressBarSanity.Location = new System.Drawing.Point(594, 400);
            this.progressBarSanity.Name = "progressBarSanity";
            this.progressBarSanity.Size = new System.Drawing.Size(254, 18);
            this.progressBarSanity.TabIndex = 3;
            this.progressBarSanity.Value = 50;
            // 
            // progressBarSleep
            // 
            this.progressBarSleep.Location = new System.Drawing.Point(594, 424);
            this.progressBarSleep.Name = "progressBarSleep";
            this.progressBarSleep.Size = new System.Drawing.Size(254, 18);
            this.progressBarSleep.TabIndex = 4;
            this.progressBarSleep.Value = 50;
            // 
            // progressBarDrugs
            // 
            this.progressBarDrugs.Location = new System.Drawing.Point(594, 448);
            this.progressBarDrugs.Name = "progressBarDrugs";
            this.progressBarDrugs.Size = new System.Drawing.Size(254, 18);
            this.progressBarDrugs.TabIndex = 5;
            this.progressBarDrugs.Value = 50;
            // 
            // progressBarEcoin
            // 
            this.progressBarEcoin.Location = new System.Drawing.Point(594, 472);
            this.progressBarEcoin.Name = "progressBarEcoin";
            this.progressBarEcoin.Size = new System.Drawing.Size(254, 18);
            this.progressBarEcoin.TabIndex = 6;
            this.progressBarEcoin.Tag = "";
            this.progressBarEcoin.Value = 50;
            // 
            // labelHunger
            // 
            this.labelHunger.AutoSize = true;
            this.labelHunger.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHunger.Location = new System.Drawing.Point(526, 352);
            this.labelHunger.Name = "labelHunger";
            this.labelHunger.Size = new System.Drawing.Size(54, 13);
            this.labelHunger.TabIndex = 7;
            this.labelHunger.Text = "HUNGER";
            // 
            // labelSkil
            // 
            this.labelSkil.AutoSize = true;
            this.labelSkil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSkil.Location = new System.Drawing.Point(544, 376);
            this.labelSkil.Name = "labelSkil";
            this.labelSkil.Size = new System.Drawing.Size(36, 13);
            this.labelSkil.TabIndex = 8;
            this.labelSkil.Text = "SKILL";
            // 
            // labelSanity
            // 
            this.labelSanity.AutoSize = true;
            this.labelSanity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSanity.Location = new System.Drawing.Point(534, 400);
            this.labelSanity.Name = "labelSanity";
            this.labelSanity.Size = new System.Drawing.Size(46, 13);
            this.labelSanity.TabIndex = 9;
            this.labelSanity.Text = "SANITY";
            // 
            // labelSleep
            // 
            this.labelSleep.AutoSize = true;
            this.labelSleep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSleep.Location = new System.Drawing.Point(539, 424);
            this.labelSleep.Name = "labelSleep";
            this.labelSleep.Size = new System.Drawing.Size(41, 13);
            this.labelSleep.TabIndex = 10;
            this.labelSleep.Text = "SLEEP";
            // 
            // labelDrugs
            // 
            this.labelDrugs.AutoSize = true;
            this.labelDrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDrugs.Location = new System.Drawing.Point(534, 448);
            this.labelDrugs.Name = "labelDrugs";
            this.labelDrugs.Size = new System.Drawing.Size(46, 13);
            this.labelDrugs.TabIndex = 11;
            this.labelDrugs.Text = "DRUGS";
            // 
            // labelEcoin
            // 
            this.labelEcoin.AutoSize = true;
            this.labelEcoin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEcoin.Location = new System.Drawing.Point(540, 472);
            this.labelEcoin.Name = "labelEcoin";
            this.labelEcoin.Size = new System.Drawing.Size(40, 13);
            this.labelEcoin.TabIndex = 12;
            this.labelEcoin.Text = "ECOIN";
            // 
            // labelDialog
            // 
            this.labelDialog.AutoSize = true;
            this.labelDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDialog.ForeColor = System.Drawing.Color.White;
            this.labelDialog.Location = new System.Drawing.Point(74, 48);
            this.labelDialog.Name = "labelDialog";
            this.labelDialog.Size = new System.Drawing.Size(295, 24);
            this.labelDialog.TabIndex = 13;
            this.labelDialog.Text = "Enter a password (default: admin):";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(78, 96);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(206, 20);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.Text = "admin";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(337, 97);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(58, 19);
            this.buttonEnter.TabIndex = 15;
            this.buttonEnter.Tag = "Set";
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonWipe
            // 
            this.buttonWipe.Location = new System.Drawing.Point(78, 425);
            this.buttonWipe.Name = "buttonWipe";
            this.buttonWipe.Size = new System.Drawing.Size(96, 59);
            this.buttonWipe.TabIndex = 16;
            this.buttonWipe.Text = "Wipedown (+Safety, -Ecoin, +Sanity)";
            this.buttonWipe.UseVisualStyleBackColor = true;
            this.buttonWipe.Visible = false;
            this.buttonWipe.Click += new System.EventHandler(this.buttonWipe_Click);
            // 
            // buttonHack
            // 
            this.buttonHack.Location = new System.Drawing.Point(78, 358);
            this.buttonHack.Name = "buttonHack";
            this.buttonHack.Size = new System.Drawing.Size(96, 59);
            this.buttonHack.TabIndex = 17;
            this.buttonHack.Text = "Hack (+Skill, +Hunger, -Sanity)";
            this.buttonHack.UseVisualStyleBackColor = true;
            this.buttonHack.Visible = false;
            this.buttonHack.Click += new System.EventHandler(this.buttonHack_Click);
            // 
            // timerCounter
            // 
            this.timerCounter.Enabled = true;
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Location = new System.Drawing.Point(188, 358);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(96, 59);
            this.buttonUpgrade.TabIndex = 18;
            this.buttonUpgrade.Text = "Upgrade PC (+Efficiency, -Ecoin";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Visible = false;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(188, 426);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(96, 59);
            this.buttonChange.TabIndex = 19;
            this.buttonChange.Tag = "";
            this.buttonChange.Text = "Change password (+Safety)";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Visible = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonWin
            // 
            this.buttonWin.Location = new System.Drawing.Point(299, 358);
            this.buttonWin.Name = "buttonWin";
            this.buttonWin.Size = new System.Drawing.Size(96, 127);
            this.buttonWin.TabIndex = 20;
            this.buttonWin.Text = "Win the game by destroying Ecorp";
            this.buttonWin.UseVisualStyleBackColor = true;
            this.buttonWin.Visible = false;
            this.buttonWin.Click += new System.EventHandler(this.buttonWin_Click);
            // 
            // buttonEat
            // 
            this.buttonEat.Location = new System.Drawing.Point(78, 196);
            this.buttonEat.Name = "buttonEat";
            this.buttonEat.Size = new System.Drawing.Size(96, 51);
            this.buttonEat.TabIndex = 21;
            this.buttonEat.Text = "Eat ( -Hunger, -Ecoin)";
            this.buttonEat.UseVisualStyleBackColor = true;
            this.buttonEat.Click += new System.EventHandler(this.buttonEat_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.Location = new System.Drawing.Point(188, 196);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(96, 51);
            this.buttonSleep.TabIndex = 22;
            this.buttonSleep.Text = "Sleep (+Sleep, +Hunger, -Drugs, +Sanity)";
            this.buttonSleep.UseVisualStyleBackColor = true;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // buttonDrugs
            // 
            this.buttonDrugs.Location = new System.Drawing.Point(78, 262);
            this.buttonDrugs.Name = "buttonDrugs";
            this.buttonDrugs.Size = new System.Drawing.Size(206, 51);
            this.buttonDrugs.TabIndex = 23;
            this.buttonDrugs.Text = "Take Drugs (-Sanity, +Hunger, +Drugs, +Skill, -Ecoin)";
            this.buttonDrugs.UseVisualStyleBackColor = true;
            this.buttonDrugs.Click += new System.EventHandler(this.buttonDrugs_Click);
            // 
            // buttonPsychologist
            // 
            this.buttonPsychologist.Location = new System.Drawing.Point(299, 196);
            this.buttonPsychologist.Name = "buttonPsychologist";
            this.buttonPsychologist.Size = new System.Drawing.Size(96, 51);
            this.buttonPsychologist.TabIndex = 24;
            this.buttonPsychologist.Text = "Go to a psychologist (+Sanity, -Ecoin)";
            this.buttonPsychologist.UseVisualStyleBackColor = true;
            this.buttonPsychologist.Click += new System.EventHandler(this.buttonPsychologist_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(299, 262);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(96, 51);
            this.buttonWork.TabIndex = 25;
            this.buttonWork.Text = "Work (-Sleep, +Ecoin, -Hunger)";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // pictureBoxCharacter
            // 
            this.pictureBoxCharacter.Image = global::MrRobotGame.Properties.Resources.Eliot;
            this.pictureBoxCharacter.InitialImage = global::MrRobotGame.Properties.Resources.Eliot;
            this.pictureBoxCharacter.Location = new System.Drawing.Point(578, 24);
            this.pictureBoxCharacter.Name = "pictureBoxCharacter";
            this.pictureBoxCharacter.Size = new System.Drawing.Size(270, 302);
            this.pictureBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCharacter.TabIndex = 26;
            this.pictureBoxCharacter.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(922, 527);
            this.Controls.Add(this.pictureBoxCharacter);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonPsychologist);
            this.Controls.Add(this.buttonDrugs);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonEat);
            this.Controls.Add(this.buttonWin);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonUpgrade);
            this.Controls.Add(this.buttonHack);
            this.Controls.Add(this.buttonWipe);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelDialog);
            this.Controls.Add(this.labelEcoin);
            this.Controls.Add(this.labelDrugs);
            this.Controls.Add(this.labelSleep);
            this.Controls.Add(this.labelSanity);
            this.Controls.Add(this.labelSkil);
            this.Controls.Add(this.labelHunger);
            this.Controls.Add(this.progressBarEcoin);
            this.Controls.Add(this.progressBarDrugs);
            this.Controls.Add(this.progressBarSleep);
            this.Controls.Add(this.progressBarSanity);
            this.Controls.Add(this.progressBarSkill);
            this.Controls.Add(this.progressBarFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Mr. Robot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarFood;
        private System.Windows.Forms.ProgressBar progressBarSkill;
        private System.Windows.Forms.ProgressBar progressBarSanity;
        private System.Windows.Forms.ProgressBar progressBarSleep;
        private System.Windows.Forms.ProgressBar progressBarDrugs;
        private System.Windows.Forms.ProgressBar progressBarEcoin;
        private System.Windows.Forms.Label labelHunger;
        private System.Windows.Forms.Label labelSkil;
        private System.Windows.Forms.Label labelSanity;
        private System.Windows.Forms.Label labelSleep;
        private System.Windows.Forms.Label labelDrugs;
        private System.Windows.Forms.Label labelEcoin;
        private System.Windows.Forms.Label labelDialog;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonWipe;
        private System.Windows.Forms.Button buttonHack;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonWin;
        private System.Windows.Forms.Button buttonEat;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonDrugs;
        private System.Windows.Forms.Button buttonPsychologist;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.PictureBox pictureBoxCharacter;
    }
}

