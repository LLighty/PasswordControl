namespace PasswordGenerator
{
    partial class PasswordForm
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnToCracker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToChecker = new System.Windows.Forms.Button();
            this.btnToGen = new System.Windows.Forms.Button();
            this.panelGen = new System.Windows.Forms.Panel();
            this.labelPass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxStrength = new System.Windows.Forms.TextBox();
            this.tboxLength = new System.Windows.Forms.TextBox();
            this.btnCopyClipboard = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChecker = new System.Windows.Forms.Panel();
            this.labelUnique = new System.Windows.Forms.Label();
            this.labelSpecial = new System.Windows.Forms.Label();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.labelUpperCase = new System.Windows.Forms.Label();
            this.labelLowerCase = new System.Windows.Forms.Label();
            this.btnAssessStrength = new System.Windows.Forms.Button();
            this.labelPasswordStrength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPasswordChecker = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panelCracker = new System.Windows.Forms.Panel();
            this.labelTimeTaken = new System.Windows.Forms.Label();
            this.labelCanCrack = new System.Windows.Forms.Label();
            this.buttonTestInternalList = new System.Windows.Forms.Button();
            this.comboBoxPasswordLists = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTimeAllowed = new System.Windows.Forms.TextBox();
            this.buttonSimpleBF = new System.Windows.Forms.Button();
            this.buttonTestProvidedList = new System.Windows.Forms.Button();
            this.textBoxListLocation = new System.Windows.Forms.TextBox();
            this.labelPasswordListLocation = new System.Windows.Forms.Label();
            this.textBoxPasswordCracker = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelHome.SuspendLayout();
            this.panelGen.SuspendLayout();
            this.panelChecker.SuspendLayout();
            this.panelCracker.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnToCracker);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.btnToChecker);
            this.panelHome.Controls.Add(this.btnToGen);
            this.panelHome.Location = new System.Drawing.Point(1, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(885, 590);
            this.panelHome.TabIndex = 6;
            // 
            // btnToCracker
            // 
            this.btnToCracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnToCracker.Location = new System.Drawing.Point(290, 357);
            this.btnToCracker.Name = "btnToCracker";
            this.btnToCracker.Size = new System.Drawing.Size(290, 92);
            this.btnToCracker.TabIndex = 3;
            this.btnToCracker.Text = "To Password Cracker";
            this.btnToCracker.UseVisualStyleBackColor = true;
            this.btnToCracker.Click += new System.EventHandler(this.btnToCracker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F);
            this.label1.Location = new System.Drawing.Point(185, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToChecker
            // 
            this.btnToChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnToChecker.Location = new System.Drawing.Point(290, 237);
            this.btnToChecker.Name = "btnToChecker";
            this.btnToChecker.Size = new System.Drawing.Size(290, 91);
            this.btnToChecker.TabIndex = 2;
            this.btnToChecker.Text = "To Password Checker";
            this.btnToChecker.UseVisualStyleBackColor = true;
            this.btnToChecker.Click += new System.EventHandler(this.btnToChecker_Click);
            // 
            // btnToGen
            // 
            this.btnToGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnToGen.Location = new System.Drawing.Point(290, 120);
            this.btnToGen.Name = "btnToGen";
            this.btnToGen.Size = new System.Drawing.Size(290, 91);
            this.btnToGen.TabIndex = 1;
            this.btnToGen.Text = "To Password Generator";
            this.btnToGen.UseVisualStyleBackColor = true;
            this.btnToGen.Click += new System.EventHandler(this.btnToGen_Click);
            // 
            // panelGen
            // 
            this.panelGen.Controls.Add(this.labelPass);
            this.panelGen.Controls.Add(this.label5);
            this.panelGen.Controls.Add(this.label4);
            this.panelGen.Controls.Add(this.tboxStrength);
            this.panelGen.Controls.Add(this.tboxLength);
            this.panelGen.Controls.Add(this.btnCopyClipboard);
            this.panelGen.Controls.Add(this.labelPassword);
            this.panelGen.Controls.Add(this.btnGeneratePassword);
            this.panelGen.Controls.Add(this.label3);
            this.panelGen.Controls.Add(this.button1);
            this.panelGen.Controls.Add(this.label2);
            this.panelGen.Location = new System.Drawing.Point(1, 0);
            this.panelGen.Name = "panelGen";
            this.panelGen.Size = new System.Drawing.Size(885, 590);
            this.panelGen.TabIndex = 7;
            this.panelGen.Visible = false;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPass.Location = new System.Drawing.Point(387, 185);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(120, 26);
            this.labelPass.TabIndex = 12;
            this.labelPass.Text = "[Password]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Strength (0-2)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Length";
            // 
            // tboxStrength
            // 
            this.tboxStrength.Location = new System.Drawing.Point(446, 344);
            this.tboxStrength.Name = "tboxStrength";
            this.tboxStrength.Size = new System.Drawing.Size(131, 20);
            this.tboxStrength.TabIndex = 9;
            // 
            // tboxLength
            // 
            this.tboxLength.Location = new System.Drawing.Point(446, 308);
            this.tboxLength.Name = "tboxLength";
            this.tboxLength.Size = new System.Drawing.Size(131, 20);
            this.tboxLength.TabIndex = 8;
            // 
            // btnCopyClipboard
            // 
            this.btnCopyClipboard.Location = new System.Drawing.Point(446, 384);
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            this.btnCopyClipboard.Size = new System.Drawing.Size(134, 45);
            this.btnCopyClipboard.TabIndex = 7;
            this.btnCopyClipboard.Text = "Copy To Clipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Click += new System.EventHandler(this.btnCopyClipboard_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelPassword.Location = new System.Drawing.Point(283, 226);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 37);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(290, 384);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(134, 45);
            this.btnGeneratePassword.TabIndex = 5;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(283, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password Generator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(290, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 92);
            this.button1.TabIndex = 3;
            this.button1.Text = "To Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F);
            this.label2.Location = new System.Drawing.Point(185, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 71);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password Control";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChecker
            // 
            this.panelChecker.Controls.Add(this.labelUnique);
            this.panelChecker.Controls.Add(this.labelSpecial);
            this.panelChecker.Controls.Add(this.labelNumbers);
            this.panelChecker.Controls.Add(this.labelUpperCase);
            this.panelChecker.Controls.Add(this.labelLowerCase);
            this.panelChecker.Controls.Add(this.btnAssessStrength);
            this.panelChecker.Controls.Add(this.labelPasswordStrength);
            this.panelChecker.Controls.Add(this.label8);
            this.panelChecker.Controls.Add(this.textBoxPasswordChecker);
            this.panelChecker.Controls.Add(this.label10);
            this.panelChecker.Controls.Add(this.btnHome1);
            this.panelChecker.Controls.Add(this.label11);
            this.panelChecker.Location = new System.Drawing.Point(892, 0);
            this.panelChecker.Name = "panelChecker";
            this.panelChecker.Size = new System.Drawing.Size(885, 590);
            this.panelChecker.TabIndex = 13;
            this.panelChecker.Visible = false;
            // 
            // labelUnique
            // 
            this.labelUnique.AutoSize = true;
            this.labelUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelUnique.Location = new System.Drawing.Point(167, 369);
            this.labelUnique.Name = "labelUnique";
            this.labelUnique.Size = new System.Drawing.Size(110, 26);
            this.labelUnique.TabIndex = 13;
            this.labelUnique.Text = "Is Unique:";
            // 
            // labelSpecial
            // 
            this.labelSpecial.AutoSize = true;
            this.labelSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSpecial.Location = new System.Drawing.Point(167, 334);
            this.labelSpecial.Name = "labelSpecial";
            this.labelSpecial.Size = new System.Drawing.Size(135, 26);
            this.labelSpecial.TabIndex = 12;
            this.labelSpecial.Text = "Has Special:";
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSize = true;
            this.labelNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNumbers.Location = new System.Drawing.Point(167, 302);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(158, 26);
            this.labelNumbers.TabIndex = 11;
            this.labelNumbers.Text = "Has Numbers: ";
            // 
            // labelUpperCase
            // 
            this.labelUpperCase.AutoSize = true;
            this.labelUpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelUpperCase.Location = new System.Drawing.Point(167, 270);
            this.labelUpperCase.Name = "labelUpperCase";
            this.labelUpperCase.Size = new System.Drawing.Size(168, 26);
            this.labelUpperCase.TabIndex = 10;
            this.labelUpperCase.Text = "Has Uppercase:";
            // 
            // labelLowerCase
            // 
            this.labelLowerCase.AutoSize = true;
            this.labelLowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelLowerCase.Location = new System.Drawing.Point(167, 237);
            this.labelLowerCase.Name = "labelLowerCase";
            this.labelLowerCase.Size = new System.Drawing.Size(168, 26);
            this.labelLowerCase.TabIndex = 9;
            this.labelLowerCase.Text = "Has Lowercase:";
            // 
            // btnAssessStrength
            // 
            this.btnAssessStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAssessStrength.Location = new System.Drawing.Point(300, 422);
            this.btnAssessStrength.Name = "btnAssessStrength";
            this.btnAssessStrength.Size = new System.Drawing.Size(259, 50);
            this.btnAssessStrength.TabIndex = 8;
            this.btnAssessStrength.Text = "Assess Strength";
            this.btnAssessStrength.UseVisualStyleBackColor = true;
            this.btnAssessStrength.Click += new System.EventHandler(this.btnAssessStrength_Click);
            // 
            // labelPasswordStrength
            // 
            this.labelPasswordStrength.AutoSize = true;
            this.labelPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPasswordStrength.Location = new System.Drawing.Point(167, 202);
            this.labelPasswordStrength.Name = "labelPasswordStrength";
            this.labelPasswordStrength.Size = new System.Drawing.Size(202, 26);
            this.labelPasswordStrength.TabIndex = 7;
            this.labelPasswordStrength.Text = "Password Strength:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(167, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password:";
            // 
            // textBoxPasswordChecker
            // 
            this.textBoxPasswordChecker.Location = new System.Drawing.Point(287, 159);
            this.textBoxPasswordChecker.Name = "textBoxPasswordChecker";
            this.textBoxPasswordChecker.Size = new System.Drawing.Size(360, 20);
            this.textBoxPasswordChecker.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label10.Location = new System.Drawing.Point(283, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 37);
            this.label10.TabIndex = 4;
            this.label10.Text = "Password Checker";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome1
            // 
            this.btnHome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnHome1.Location = new System.Drawing.Point(290, 478);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(290, 92);
            this.btnHome1.TabIndex = 3;
            this.btnHome1.Text = "To Home";
            this.btnHome1.UseVisualStyleBackColor = true;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F);
            this.label11.Location = new System.Drawing.Point(185, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(516, 71);
            this.label11.TabIndex = 0;
            this.label11.Text = "Password Control";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCracker
            // 
            this.panelCracker.Controls.Add(this.labelTimeTaken);
            this.panelCracker.Controls.Add(this.labelCanCrack);
            this.panelCracker.Controls.Add(this.buttonTestInternalList);
            this.panelCracker.Controls.Add(this.comboBoxPasswordLists);
            this.panelCracker.Controls.Add(this.label12);
            this.panelCracker.Controls.Add(this.textBoxTimeAllowed);
            this.panelCracker.Controls.Add(this.buttonSimpleBF);
            this.panelCracker.Controls.Add(this.buttonTestProvidedList);
            this.panelCracker.Controls.Add(this.textBoxListLocation);
            this.panelCracker.Controls.Add(this.labelPasswordListLocation);
            this.panelCracker.Controls.Add(this.textBoxPasswordCracker);
            this.panelCracker.Controls.Add(this.label9);
            this.panelCracker.Controls.Add(this.label6);
            this.panelCracker.Controls.Add(this.button2);
            this.panelCracker.Controls.Add(this.label7);
            this.panelCracker.Location = new System.Drawing.Point(889, 0);
            this.panelCracker.Name = "panelCracker";
            this.panelCracker.Size = new System.Drawing.Size(885, 590);
            this.panelCracker.TabIndex = 14;
            this.panelCracker.Visible = false;
            // 
            // labelTimeTaken
            // 
            this.labelTimeTaken.AutoSize = true;
            this.labelTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelTimeTaken.Location = new System.Drawing.Point(441, 435);
            this.labelTimeTaken.Name = "labelTimeTaken";
            this.labelTimeTaken.Size = new System.Drawing.Size(242, 26);
            this.labelTimeTaken.TabIndex = 18;
            this.labelTimeTaken.Text = "Time Taken (Seconds): ";
            // 
            // labelCanCrack
            // 
            this.labelCanCrack.AutoSize = true;
            this.labelCanCrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCanCrack.Location = new System.Drawing.Point(170, 435);
            this.labelCanCrack.Name = "labelCanCrack";
            this.labelCanCrack.Size = new System.Drawing.Size(121, 26);
            this.labelCanCrack.TabIndex = 17;
            this.labelCanCrack.Text = "Can Crack:";
            // 
            // buttonTestInternalList
            // 
            this.buttonTestInternalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTestInternalList.Location = new System.Drawing.Point(290, 374);
            this.buttonTestInternalList.Name = "buttonTestInternalList";
            this.buttonTestInternalList.Size = new System.Drawing.Size(286, 42);
            this.buttonTestInternalList.TabIndex = 16;
            this.buttonTestInternalList.Text = "Test List";
            this.buttonTestInternalList.UseVisualStyleBackColor = true;
            this.buttonTestInternalList.Click += new System.EventHandler(this.buttonTestInternalList_Click);
            // 
            // comboBoxPasswordLists
            // 
            this.comboBoxPasswordLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPasswordLists.FormattingEnabled = true;
            this.comboBoxPasswordLists.Items.AddRange(new object[] {
            "Common Passwords"});
            this.comboBoxPasswordLists.Location = new System.Drawing.Point(286, 347);
            this.comboBoxPasswordLists.Name = "comboBoxPasswordLists";
            this.comboBoxPasswordLists.Size = new System.Drawing.Size(360, 21);
            this.comboBoxPasswordLists.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label12.Location = new System.Drawing.Point(39, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 26);
            this.label12.TabIndex = 14;
            this.label12.Text = "BruteForce Exit Time (minutes):";
            // 
            // textBoxTimeAllowed
            // 
            this.textBoxTimeAllowed.Location = new System.Drawing.Point(364, 199);
            this.textBoxTimeAllowed.Name = "textBoxTimeAllowed";
            this.textBoxTimeAllowed.Size = new System.Drawing.Size(73, 20);
            this.textBoxTimeAllowed.TabIndex = 13;
            // 
            // buttonSimpleBF
            // 
            this.buttonSimpleBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSimpleBF.Location = new System.Drawing.Point(483, 186);
            this.buttonSimpleBF.Name = "buttonSimpleBF";
            this.buttonSimpleBF.Size = new System.Drawing.Size(170, 42);
            this.buttonSimpleBF.TabIndex = 12;
            this.buttonSimpleBF.Text = "Simple Bruteforce";
            this.buttonSimpleBF.UseVisualStyleBackColor = true;
            this.buttonSimpleBF.Click += new System.EventHandler(this.buttonSimpleBF_Click);
            // 
            // buttonTestProvidedList
            // 
            this.buttonTestProvidedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTestProvidedList.Location = new System.Drawing.Point(285, 295);
            this.buttonTestProvidedList.Name = "buttonTestProvidedList";
            this.buttonTestProvidedList.Size = new System.Drawing.Size(286, 42);
            this.buttonTestProvidedList.TabIndex = 11;
            this.buttonTestProvidedList.Text = "Test Against Provided List";
            this.buttonTestProvidedList.UseVisualStyleBackColor = true;
            this.buttonTestProvidedList.Click += new System.EventHandler(this.buttonTestProvidedList_Click);
            // 
            // textBoxListLocation
            // 
            this.textBoxListLocation.Location = new System.Drawing.Point(286, 269);
            this.textBoxListLocation.Name = "textBoxListLocation";
            this.textBoxListLocation.Size = new System.Drawing.Size(360, 20);
            this.textBoxListLocation.TabIndex = 10;
            // 
            // labelPasswordListLocation
            // 
            this.labelPasswordListLocation.AutoSize = true;
            this.labelPasswordListLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPasswordListLocation.Location = new System.Drawing.Point(140, 263);
            this.labelPasswordListLocation.Name = "labelPasswordListLocation";
            this.labelPasswordListLocation.Size = new System.Drawing.Size(140, 26);
            this.labelPasswordListLocation.TabIndex = 9;
            this.labelPasswordListLocation.Text = "List Location:";
            // 
            // textBoxPasswordCracker
            // 
            this.textBoxPasswordCracker.Location = new System.Drawing.Point(293, 159);
            this.textBoxPasswordCracker.Name = "textBoxPasswordCracker";
            this.textBoxPasswordCracker.Size = new System.Drawing.Size(360, 20);
            this.textBoxPasswordCracker.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(170, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.Location = new System.Drawing.Point(283, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password Cracker";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(290, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "To Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F);
            this.label7.Location = new System.Drawing.Point(185, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(516, 71);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password Control";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 597);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelGen);
            this.Controls.Add(this.panelCracker);
            this.Controls.Add(this.panelChecker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordForm";
            this.Text = "Password Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelGen.ResumeLayout(false);
            this.panelGen.PerformLayout();
            this.panelChecker.ResumeLayout(false);
            this.panelChecker.PerformLayout();
            this.panelCracker.ResumeLayout(false);
            this.panelCracker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnToCracker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToChecker;
        private System.Windows.Forms.Button btnToGen;
        private System.Windows.Forms.Panel panelGen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyClipboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxStrength;
        private System.Windows.Forms.TextBox tboxLength;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Panel panelChecker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelCracker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAssessStrength;
        private System.Windows.Forms.Label labelPasswordStrength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPasswordChecker;
        private System.Windows.Forms.Label labelSpecial;
        private System.Windows.Forms.Label labelNumbers;
        private System.Windows.Forms.Label labelUpperCase;
        private System.Windows.Forms.Label labelLowerCase;
        private System.Windows.Forms.Label labelUnique;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTimeAllowed;
        private System.Windows.Forms.Button buttonSimpleBF;
        private System.Windows.Forms.Button buttonTestProvidedList;
        private System.Windows.Forms.TextBox textBoxListLocation;
        private System.Windows.Forms.Label labelPasswordListLocation;
        private System.Windows.Forms.TextBox textBoxPasswordCracker;
        private System.Windows.Forms.Label labelTimeTaken;
        private System.Windows.Forms.Label labelCanCrack;
        private System.Windows.Forms.Button buttonTestInternalList;
        private System.Windows.Forms.ComboBox comboBoxPasswordLists;
    }
}

