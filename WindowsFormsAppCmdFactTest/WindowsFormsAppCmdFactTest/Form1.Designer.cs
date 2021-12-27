
namespace WindowsFormsAppCmdFactTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbBoxProtocole = new System.Windows.Forms.ComboBox();
            this.btnCmdA = new System.Windows.Forms.Button();
            this.btnCmdB = new System.Windows.Forms.Button();
            this.btnCmdC = new System.Windows.Forms.Button();
            this.btnCmdD = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCmdE = new System.Windows.Forms.Button();
            this.btnCmdAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBoxProtocole
            // 
            this.cmbBoxProtocole.FormattingEnabled = true;
            this.cmbBoxProtocole.Location = new System.Drawing.Point(667, 12);
            this.cmbBoxProtocole.Name = "cmbBoxProtocole";
            this.cmbBoxProtocole.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxProtocole.TabIndex = 0;
            this.cmbBoxProtocole.SelectedIndexChanged += new System.EventHandler(this.OnCmbBoxProtocoleSelectedIndexChanged);
            // 
            // btnCmdA
            // 
            this.btnCmdA.Location = new System.Drawing.Point(667, 39);
            this.btnCmdA.Name = "btnCmdA";
            this.btnCmdA.Size = new System.Drawing.Size(121, 29);
            this.btnCmdA.TabIndex = 1;
            this.btnCmdA.Text = "Command A";
            this.btnCmdA.UseVisualStyleBackColor = true;
            this.btnCmdA.Click += new System.EventHandler(this.OnClickCmdA);
            // 
            // btnCmdB
            // 
            this.btnCmdB.Location = new System.Drawing.Point(667, 74);
            this.btnCmdB.Name = "btnCmdB";
            this.btnCmdB.Size = new System.Drawing.Size(121, 29);
            this.btnCmdB.TabIndex = 2;
            this.btnCmdB.Text = "Command B";
            this.btnCmdB.UseMnemonic = false;
            this.btnCmdB.UseVisualStyleBackColor = true;
            this.btnCmdB.Click += new System.EventHandler(this.OnClickCmdB);
            // 
            // btnCmdC
            // 
            this.btnCmdC.Location = new System.Drawing.Point(667, 109);
            this.btnCmdC.Name = "btnCmdC";
            this.btnCmdC.Size = new System.Drawing.Size(121, 29);
            this.btnCmdC.TabIndex = 3;
            this.btnCmdC.Text = "Command C";
            this.btnCmdC.UseVisualStyleBackColor = true;
            this.btnCmdC.Click += new System.EventHandler(this.OnClickCmdC);
            // 
            // btnCmdD
            // 
            this.btnCmdD.Location = new System.Drawing.Point(667, 144);
            this.btnCmdD.Name = "btnCmdD";
            this.btnCmdD.Size = new System.Drawing.Size(121, 29);
            this.btnCmdD.TabIndex = 4;
            this.btnCmdD.Text = "Command D";
            this.btnCmdD.UseVisualStyleBackColor = true;
            this.btnCmdD.Click += new System.EventHandler(this.OnClickCmdD);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(649, 413);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickClear);
            // 
            // btnCmdE
            // 
            this.btnCmdE.Location = new System.Drawing.Point(667, 179);
            this.btnCmdE.Name = "btnCmdE";
            this.btnCmdE.Size = new System.Drawing.Size(121, 29);
            this.btnCmdE.TabIndex = 8;
            this.btnCmdE.Text = "Command E";
            this.btnCmdE.UseVisualStyleBackColor = true;
            this.btnCmdE.Click += new System.EventHandler(this.OnClickCmdE);
            // 
            // btnCmdAll
            // 
            this.btnCmdAll.Location = new System.Drawing.Point(667, 214);
            this.btnCmdAll.Name = "btnCmdAll";
            this.btnCmdAll.Size = new System.Drawing.Size(121, 29);
            this.btnCmdAll.TabIndex = 9;
            this.btnCmdAll.Text = "Command All";
            this.btnCmdAll.UseVisualStyleBackColor = true;
            this.btnCmdAll.Click += new System.EventHandler(this.OnClickCmdAll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCmdAll);
            this.Controls.Add(this.btnCmdE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCmdD);
            this.Controls.Add(this.btnCmdC);
            this.Controls.Add(this.btnCmdB);
            this.Controls.Add(this.btnCmdA);
            this.Controls.Add(this.cmbBoxProtocole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxProtocole;
        private System.Windows.Forms.Button btnCmdA;
        private System.Windows.Forms.Button btnCmdB;
        private System.Windows.Forms.Button btnCmdC;
        private System.Windows.Forms.Button btnCmdD;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCmdE;
        private System.Windows.Forms.Button btnCmdAll;
    }
}

