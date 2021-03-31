using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordForm : Form
    {
        PasswordGen passwordGenerator = new PasswordGen();
        PasswordChecker passwordChecker = new PasswordChecker();
        PasswordCracker passwordCracker = new PasswordCracker();
        const String PASSWORDSTRENGTH = "Password Strength: ";
        const String HASLOWER = "Has Lowercase: ";
        const String HASUPPER = "Has Uppercase: ";
        const String HASNUMBERS = "Has Numbers: ";
        const String HASSPECIAL = "Has Special: ";
        const String ISUNIQUE = "Is Unique: ";
        const String CANCRACK = "Can Crack: ";
        const String TIMETAKEN = "Time Taken (Seconds): ";

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelChecker.Left = 0;
            panelChecker.Top = 0;
            panelCracker.Left = 0;
            panelCracker.Top = 0;
            this.ClientSize = new System.Drawing.Size(900, 597);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelGen.Visible = false;
        }

        private void btnToGen_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelGen.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int length, strength;
            try
            {
                length = Int32.Parse(tboxLength.Text);
            } catch (FormatException)
            {
                Console.WriteLine("Incorrect formatting of Length");
                return;
            }

            try
            {
                strength = Int32.Parse(tboxStrength.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect formatting of strength");
                return;
            }

            //Making sure passwords aren't too long
            if (length > 50)
            {
                length = 50;
            }

            //Strength needs to be within 0-2
            if(strength > 2 || strength < 0)
            {
                return;
            }

            Password pass;
            pass = passwordGenerator.GeneratePassword(strength, length, 0);
            labelPass.Text = pass.password;

        }

        private void btnCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelPass.Text);
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelChecker.Visible = false;
        }

        private void btnToChecker_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelChecker.Visible = true;
        }

        private void btnToCracker_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelCracker.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelCracker.Visible = false;
        }

        private void btnAssessStrength_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Begin password assess");
            Password pass = new Password(textBoxPasswordChecker.Text);
            passwordChecker.CalculatePasswordStrength(ref pass);

            if(String.Equals("weak", pass.strength))
            {
                labelPasswordStrength.Text = PASSWORDSTRENGTH + pass.strength;
            }
            else if(String.Equals("moderate", pass.strength))
            {
                labelPasswordStrength.Text = PASSWORDSTRENGTH + pass.strength;
            }
            else if (String.Equals("strong", pass.strength))
            {
                labelPasswordStrength.Text = PASSWORDSTRENGTH + pass.strength;
            }
            else
            {
                labelPasswordStrength.Text = PASSWORDSTRENGTH;
            }

            labelUpperCase.Text = pass.config.hasUpperCase ? HASUPPER + "Yes" : HASUPPER + "No";
            labelLowerCase.Text = pass.config.hasLowerCase ? HASLOWER + "Yes" : HASLOWER + "No";
            labelNumbers.Text = pass.config.hasNumber ? HASNUMBERS + "Yes" : HASNUMBERS + "No";
            labelSpecial.Text = pass.config.hasExtraCharacters ? HASSPECIAL + "Yes" : HASSPECIAL + "No";
            labelUnique.Text = pass.config.isUnique ? ISUNIQUE + "Yes" : ISUNIQUE + "No";
        }

        private void buttonSimpleBF_Click(object sender, EventArgs e)
        {
            clearCrackerTextBoxes();
            if (textBoxPasswordCracker.Text.Length <= 0) { return; }
            double time = 0.0;
            try
            {
                time = Double.Parse(textBoxTimeAllowed.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect formatting of Time");
                return;
            }

            Password pass = new Password(textBoxPasswordCracker.Text);
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Boolean canCrack = passwordCracker.BruteForceSimple(pass, time);
            watch.Stop();

            labelCanCrack.Text = canCrack ? CANCRACK + "Yes" : CANCRACK + "No";
            labelTimeTaken.Text = canCrack ? TIMETAKEN + (watch.ElapsedMilliseconds / 1000) : TIMETAKEN + " > " + (watch.ElapsedMilliseconds / 1000);
        }

        private void clearCrackerTextBoxes()
        {
            labelCanCrack.Text = CANCRACK;
            labelTimeTaken.Text = TIMETAKEN;
        }

        private void buttonTestInternalList_Click(object sender, EventArgs e)
        {
            clearCrackerTextBoxes();

            Password pass = new Password(textBoxPasswordCracker.Text);
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Boolean canCrack = passwordCracker.CheckFromInternalList(pass, comboBoxPasswordLists.SelectedIndex);
            watch.Stop();

            labelCanCrack.Text = canCrack ? CANCRACK + "Yes" : CANCRACK + "No";
            labelTimeTaken.Text = canCrack ? TIMETAKEN + (watch.ElapsedMilliseconds / 1000) : TIMETAKEN + (watch.ElapsedMilliseconds / 1000);
        }

        private void buttonTestProvidedList_Click(object sender, EventArgs e)
        {
            String pathToList = textBoxListLocation.Text;

            Password pass = new Password(textBoxPasswordCracker.Text);
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Boolean canCrack = passwordCracker.CheckFromExternalList(pass, pathToList);
            watch.Stop();

            labelCanCrack.Text = canCrack ? CANCRACK + "Yes" : CANCRACK + "No";
            labelTimeTaken.Text = canCrack ? TIMETAKEN + (watch.ElapsedMilliseconds / 1000) : TIMETAKEN + (watch.ElapsedMilliseconds / 1000);
        }

        private void buttonGenerateSecurePassword_Click(object sender, EventArgs e)
        {
            int length, strength;
            try
            {
                length = Int32.Parse(tboxLength.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect formatting of Length");
                return;
            }

            try
            {
                strength = Int32.Parse(tboxStrength.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect formatting of strength");
                return;
            }

            //Making sure passwords aren't too long
            if (length > 50)
            {
                length = 50;
            }

            //Strength needs to be within 0-2
            if (strength > 2 || strength < 0)
            {
                return;
            }

            Password pass;
            pass = passwordGenerator.GeneratePassword(strength, length, 1);
            labelPass.Text = pass.password;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxListLocation.Text = openFileDialog.FileName;
            }
        }

        private void buttonExtensiveBruteForce_Click(object sender, EventArgs e)
        {
            clearCrackerTextBoxes();
            if (textBoxPasswordCracker.Text.Length <= 0) { return; }
            double time = 0.0;
            try
            {
                time = Double.Parse(textBoxTimeAllowed.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect formatting of Time");
                return;
            }

            Password pass = new Password(textBoxPasswordCracker.Text);
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            Boolean canCrack = passwordCracker.BruteForceExtensive(pass, time);
            watch.Stop();

            labelCanCrack.Text = canCrack ? CANCRACK + "Yes" : CANCRACK + "No";
            labelTimeTaken.Text = canCrack ? TIMETAKEN + (watch.ElapsedMilliseconds / 1000) : TIMETAKEN + " > " + (watch.ElapsedMilliseconds / 1000);
        }
    }
}
