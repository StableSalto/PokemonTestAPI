namespace PokemonTestAPI
{
    partial class frmPokemonLookup
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
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHappiness = new System.Windows.Forms.TextBox();
            this.txtCaptureRate = new System.Windows.Forms.TextBox();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.txtFlavor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEggGroup = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(129, 28);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(100, 20);
            this.txtSpecies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Species Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base Happiness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capture Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Habitat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Growth Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Flavor Text";
            // 
            // txtHappiness
            // 
            this.txtHappiness.Location = new System.Drawing.Point(129, 54);
            this.txtHappiness.Name = "txtHappiness";
            this.txtHappiness.Size = new System.Drawing.Size(100, 20);
            this.txtHappiness.TabIndex = 7;
            // 
            // txtCaptureRate
            // 
            this.txtCaptureRate.Location = new System.Drawing.Point(129, 80);
            this.txtCaptureRate.Name = "txtCaptureRate";
            this.txtCaptureRate.Size = new System.Drawing.Size(100, 20);
            this.txtCaptureRate.TabIndex = 8;
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(129, 106);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(100, 20);
            this.txtHabitat.TabIndex = 9;
            // 
            // txtGrowthRate
            // 
            this.txtGrowthRate.Location = new System.Drawing.Point(129, 132);
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.Size = new System.Drawing.Size(100, 20);
            this.txtGrowthRate.TabIndex = 10;
            // 
            // txtFlavor
            // 
            this.txtFlavor.Location = new System.Drawing.Point(129, 158);
            this.txtFlavor.Name = "txtFlavor";
            this.txtFlavor.Size = new System.Drawing.Size(659, 20);
            this.txtFlavor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Egg Group";
            // 
            // txtEggGroup
            // 
            this.txtEggGroup.Location = new System.Drawing.Point(129, 184);
            this.txtEggGroup.Name = "txtEggGroup";
            this.txtEggGroup.Size = new System.Drawing.Size(100, 20);
            this.txtEggGroup.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter a Pokemon Species Name to Lookup:";
            // 
            // frmPokemonLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEggGroup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFlavor);
            this.Controls.Add(this.txtGrowthRate);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.txtCaptureRate);
            this.Controls.Add(this.txtHappiness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpecies);
            this.Name = "frmPokemonLookup";
            this.Text = "Pokemon Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHappiness;
        private System.Windows.Forms.TextBox txtCaptureRate;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.TextBox txtGrowthRate;
        private System.Windows.Forms.TextBox txtFlavor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEggGroup;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
    }
}

